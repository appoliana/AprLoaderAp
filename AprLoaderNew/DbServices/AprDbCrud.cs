using AprLoader.Models;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using AprLoaderNew.APR;
using AprLoaderNew.EPO_Hardware;
using AprLoaderNew.WGD;
using System.Windows;
using System.Text.RegularExpressions;

namespace AprLoader.Core
{
    internal class AprDbCrud
    {
        public static AutoResetEvent Wait = new AutoResetEvent(false);

        /// <summary>
        /// Ивент перед началом очистки таблицы или при обработке экспешена
        /// </summary>
        public event Action<string> TableRemoveEvent;

        /// <summary>
        /// Ивент по критическим и информационным событиям UpdateDB
        /// </summary>
        public event Action<int> DbUpdateFeedbackEvent;

        /// <summary>
        /// Ивент по успешному или не успешному окончанию обновления
        /// </summary>
        public event Action DbUpdateEndEvent;

        #region Селекты из APR и HW
        internal string GetHardwareDetectorUniqueNameById(int detectorId)
        {
            using (EPO_hardwareContext db = new EPO_hardwareContext())
                return db.HardwareDetectors.FirstOrDefault(a => a.Id == detectorId).UniqueName;
        }

        internal LogicalWorkstation GetLogicalWorkstationByToolTip(string toolTip)
        {
            using (APRContext db = new APRContext())
                return db.LogicalWorkstations.FirstOrDefault(a => a.ToolTip == toolTip);
        }

        internal DetectorWorkstation[] GetDetectorWorkstationsById(int workstationId)
        {
            using (APRContext db = new APRContext())
                return db.DetectorWorkstations.Where(a => a.LogicalWorkstationId == workstationId)?.ToArray();
        }

        internal LogicalWorkstation[] GetLogicalWorkstations()
        {
            using (APRContext db = new APRContext())
            {
                var lw = db.LogicalWorkstations;
                return lw?.ToArray();
            }
        }

        internal SoftwareInnerType[] GetSoftwareInnerTypes()
        {
            using (APRContext db = new APRContext())
            {
                var sit = db.SoftwareInnerTypes;
                return sit?.ToArray();
            }
        }
        #endregion

        /// <summary>
        /// Словарь сопоставлений русских символов английским. Key - русский символ, Value - английский.
        /// </summary>
        Dictionary<string, string> matchingCharactersDic = new Dictionary<string, string>
        {
            { "А", "A"},
            { "С", "C"},
            { "В", "B"},
            { "Е", "E"},
            { "Н", "H"},
            { "К", "K"},
            { "М", "M"},
            { "Х", "X"},
            { "У", "Y"},
            { "О", "O"},
            { "Р", "P"},
        };

        #region CRUD
        internal void UpdateDB(int detectorIndex, int workstationIndex, int xlsxListIndex, int softwareId,
                ExcelLoader excelLoader, ShootingParamSet shootingParamSet)
        {
            // Алгоритм загрузки является собственностью компании НИПК Электрон и не может быть опубликован.
        }

        internal void EraseTables()
        {
            try
            {
                var helper = new WorkWithWgd();
                TableRemoveEvent?.Invoke("Clear WgdTables...");
                helper.ClearDb();
                using (APRContext db = new APRContext())
                {
                    TableRemoveEvent?.Invoke("Clear AprSpecificParameters...");
                    db.AprSpecificParameters.RemoveRange(db.AprSpecificParameters);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear SoftwareAprType...");
                    db.SoftwareAprTypes.RemoveRange(db.SoftwareAprTypes);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Apr...");
                    db.Aprs.RemoveRange(db.Aprs);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear DisplayAprs...");
                    db.DisplayAprs.RemoveRange(db.DisplayAprs);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear ShootingParameters...");
                    db.ShootingParameters.RemoveRange(db.ShootingParameters);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear ExaminationParameter...");
                    db.ExaminationParameters.RemoveRange(db.ExaminationParameters);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Rating...");
                    db.Ratings.RemoveRange(db.Ratings);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear DefaultApr...");
                    db.DefaultAprs.RemoveRange(db.DefaultAprs);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Report30Types...");
                    db.Report30Types.RemoveRange(db.Report30Types);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Report3DozTypes...");
                    db.Report3DozTypes.RemoveRange(db.Report3DozTypes);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Generator...");
                    db.Generators.RemoveRange(db.Generators);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Rack...");
                    db.Racks.RemoveRange(db.Racks);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear Collimator...");
                    db.Collimators.RemoveRange(db.Collimators);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear TlsDirectory...");
                    db.TlsDirectories.RemoveRange(db.TlsDirectories);
                    db.SaveChanges();

                    TableRemoveEvent?.Invoke("Clear TomoParameter...");
                    db.TomoParameters.RemoveRange(db.TomoParameters);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                TableRemoveEvent?.Invoke($"Сбой в работе функции очистки. {e.Message} \n {e.InnerException.InnerException.Message}");
            }

            Wait.Set();
        }

        //todo: нет окончательной уверенности в том, при каком типе АКЭ используется этот код для генератора 
        // на данный момент мы считаем что этот код используется только для внешнего АКЭ, которое подключается напрямую в генератор
        // АКЭ встроенное в детектор работает с генератором через БС
        /// <summary>
        /// Получаем код для генератора обозначающий комбинацию используемых зон АКЭ 
        /// </summary>
        /// <param name="t">Строка обозначающая комбинацию используемых зон АКЭ</param>
        /// <returns>Целое от 0 до 7</returns>

        internal int GetAecZoneForGenerator(string t)
        {
            var SelectGenAecMode = new Dictionary<string, int>(){
                { "C",2 },  //010
                { "RL",5},  //101
                { "R",1},   //001
                { "L",4},   //100
                { "N",0},   //000
                { "LC",6},  //110
                { "CR",3 }, //011
                { "LCR",7}  //111
                }.WithDefaultValue(0);

            return SelectGenAecMode[t?.Trim().ToUpper()];
        }

        /// <summary>
        /// Проверка при загрузке проставлены Ma Ms или нет
        /// </summary>
        /// <param name="genma">Ма</param>
        /// <param name="genms">Мс</param>
        /// <returns>True/False</returns>
        internal bool IsThreepointTech(float genma, float genms)
        {
            return (genma > 0 && genms > 0);
        }

        internal void ClearAprsByWSID(int id, int? apr_type = null)
        {
            using (var db = new APRContext())
            {
                if (apr_type == null)
                {
                    db.AprSpecificParameters.RemoveRange(
                    db.AprSpecificParameters.Where(
                        o => db.Aprs.Where(x => x.LogicalWorkstationId == id)
                        .Select(xx => xx.Id)
                        .Contains(o.AprId)));
                    db.SaveChanges();

                    db.Aprs.RemoveRange(
                    db.Aprs.Where(
                        o => o.LogicalWorkstationId == id));
                    db.SaveChanges();
                }
                else
                {
                    db.AprSpecificParameters.RemoveRange(
                    db.AprSpecificParameters.Where(
                        o => db.Aprs.Where(x => x.LogicalWorkstationId == id)
                        .Select(xx => xx.Id)
                        .Contains(o.AprId) && o.Type == apr_type));
                    db.SaveChanges();

                    db.Aprs.RemoveRange(
                        db.Aprs.Where(
                            o => !db.AprSpecificParameters.
                            Select(x => x.AprId)
                            .Contains(o.Id)));
                    db.SaveChanges();

                }

                db.Collimators.RemoveRange(
                    db.Collimators.Where(
                        o => !db.AprSpecificParameters.
                        Select(x => x.CollimatorId)
                        .Contains(o.Id)));
                db.SaveChanges();

                db.Generators.RemoveRange(
                    db.Generators.Where(
                        o => !db.AprSpecificParameters
                        .Select(x => x.GeneratorId)
                        .Contains(o.Id)));
                db.SaveChanges();

                db.Racks.RemoveRange(
                    db.Racks.Where(
                        o => !db.AprSpecificParameters
                        .Select(x => x.RackId)
                        .Contains(o.Id)));
                db.SaveChanges();

                db.TlsDirectories.RemoveRange(
                    db.TlsDirectories.Where(
                        o => !db.AprSpecificParameters
                        .Select(x => x.TlsDirectoryId)
                        .Union(
                            db.AprSpecificParameters
                            .Select(xx => xx.ShotTypeTlsId))
                        .Contains(o.Id)));
                db.SaveChanges();

                db.ShootingParameters.RemoveRange(
                    db.ShootingParameters.Where(
                        o => !db.AprSpecificParameters
                        .Select(x => x.ShootingParamId)
                        .Contains(o.Id)));
                db.SaveChanges();

                db.Ratings.RemoveRange(
                    db.Ratings.Where(
                        o => !db.Aprs
                        .Join(
                            db.ExaminationParameters,
                            f => f.ExaminationParamId,
                            s => s.Id,
                            (f, s) => new
                            {
                                ExaminationId = s.ExaminationId
                            }
                        )
                        .Select(x => x.ExaminationId)
                        .Contains(o.ExaminationId)));
                db.SaveChanges();
            }
        }
        #endregion
    }
}
