using AprLoader;
using AprLoader.Core;
using AprLoader.Models;
using AprLoaderNew.APR;
using AprLoaderNew.EPO_Hardware;
using AprLoaderNew.Models;
using AprLoaderNew.ViewModel;
using AprLoaderNew.WGD;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AprLoaderNew
{
    public class Model : OnPropertyChangedClass
    {
        private ExcelLoader excelLoader;
        private int WorkstationIndex;
        private int DetectorIndex;
        private int SoftwareIndex;
        private int detectorIndex;
        private int xlsxListIndex;
        private ShootingParamSet shootingParamSet = new ShootingParamSet();
        private AprDbCrud aprDbCrud = new AprDbCrud();

        /// <summary>
        /// Событие по окончанию загрузки всего АПР-файла.
        /// </summary>
        public event Action<string> DbUpdateRowEndEvent;

        /// <summary>
        /// Событие сбоя загрузки всего АПР-файла.
        /// </summary>
        public event Action<Exception> DbUpdateFalseEvent;

        public bool IsTomoChecked { get => isTomoChecked; set { isTomoChecked = value; OnPropertyChanged(); } }
        private bool isTomoChecked = false;

        public bool IsGraphyShootingChecked { get => isGraphyShootingChecked; set { isGraphyShootingChecked = value; OnPropertyChanged(); } }
        private bool isGraphyShootingChecked = true;

        public bool IsSerialGraphyChecked { get => isSerialGraphyChecked; set { isSerialGraphyChecked = value; OnPropertyChanged(); } }
        private bool isSerialGraphyChecked = false;

        public bool IsScopyShootingChecked { get => isScopyShootingChecked; set { isScopyShootingChecked = value; OnPropertyChanged(); } }
        private bool isScopyShootingChecked = false;

        public bool IsScopyHdShootingChecked { get => isScopyHdShootingChecked; set { isScopyHdShootingChecked = value; OnPropertyChanged(); } }
        private bool isScopyHdShootingChecked = false;

        public bool IsTomoSyntChecked { get => isTomoSyntChecked; set { isTomoSyntChecked = value; OnPropertyChanged(); } }
        private bool isTomoSyntChecked = false;

        public string AprTextUpdate { get => loadFilePath; set { loadFilePath = value; OnPropertyChanged(); } }
        private string loadFilePath = string.Empty;

        public List<string> LoadedList { get => loadedList; set { loadedList = value; OnPropertyChanged(); } }
        private List<string> loadedList = new List<string>();

        public List<string> WorkstationList { get => workstationList; set { loadedList = value; OnPropertyChanged(); } }
        private List<string> workstationList = new List<string>();

        public List<string> DetectorList { get => detectorList; set { detectorList = value; OnPropertyChanged(); } }
        private List<string> detectorList = new List<string>();

        public List<string> SoftwareList { get => softwareList; set { softwareList = value; OnPropertyChanged(); } }
        private List<string> softwareList = new List<string>();

        public string WorkStationListSelectedItem { get => workStationListSelectedItem; set { workStationListSelectedItem = value; OnPropertyChanged(); } }
        private string workStationListSelectedItem = String.Empty;

        public string DetectorListSelectedItem { get => detectorListSelectedItem; set { detectorListSelectedItem = value; OnPropertyChanged(); } }
        private string detectorListSelectedItem = String.Empty;

        public string SoftwareListSelectedItem { get => softwareListSelectedItem; set { softwareListSelectedItem = value; OnPropertyChanged(); } }
        private string softwareListSelectedItem;

        public int SoftwareListSelectedIndex { get => softwareListSelectedIndex; set { softwareListSelectedIndex = value; OnPropertyChanged(); } }
        private int softwareListSelectedIndex;

        public bool ChangeStateOfUI { get => stateOfUI; set { stateOfUI = value; OnPropertyChanged(); } }
        private bool stateOfUI = true;

        public int WorkstationListSelectedIndex 
        { 
            get => workstationListSelectedIndex; 
            set 
            { 
                workstationListSelectedIndex = value;
                var ws = aprDbCrud.GetLogicalWorkstationByToolTip(workstationList[workstationListSelectedIndex]);
                WorkstationBackgrounds(ws);
                OnPropertyChanged(); 
            } 
        }
        private int workstationListSelectedIndex;

        public int DetectorListSelectedIndex { get => detectorListSelectedIndex; set { detectorListSelectedIndex = value; OnPropertyChanged(); } }
        private int detectorListSelectedIndex;

        public int ListSelectedIndex { get => listSelectedIndex; set { listSelectedIndex = value; OnPropertyChanged(); } }
        private int listSelectedIndex;

        public bool IsNeededClearDb { get => isNeededClearDb; set { isNeededClearDb = value; OnPropertyChanged(); } }
        private bool isNeededClearDb;

        public ObservableCollection<string> Logger { get => logger; set { logger = value; OnPropertyChanged(); } }
        private ObservableCollection<string> logger = new ObservableCollection<string>();

        public SolidColorBrush AprPathTextBoxBorderColor { get => borderColor; set { borderColor = value; OnPropertyChanged(); } }
        private SolidColorBrush borderColor = Brushes.Gray;

        public Brush ScopyBackground { get => scopyBackground; set { scopyBackground = value; OnPropertyChanged(); } }
        private Brush scopyBackground = Brushes.Gray;

        public Brush TomoBackground { get => tomoBackground; set { tomoBackground = value; OnPropertyChanged(); } }
        private Brush tomoBackground = Brushes.Gray;

        public Brush SerialGraphyBackground { get => serialGraphyBackground; set { serialGraphyBackground = value; OnPropertyChanged(); } }
        private Brush serialGraphyBackground = Brushes.Gray;

        public Brush AecBackground { get => aecBackground; set { aecBackground = value; OnPropertyChanged(); } }
        private Brush aecBackground = Brushes.Gray;

        /// <summary>
        /// Загрузить файл excel.
        /// </summary>
        public void FindFile()
        {
            try
            {
                loadedList.Clear();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel 2017 (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                dialog.DefaultExt = "xlsx";
                if (dialog.ShowDialog() == true)
                {
                    excelLoader = new ExcelLoader(dialog.FileName);
                    loadFilePath = dialog.FileName;
                    AprTextUpdate = loadFilePath;
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать файл с АПРами");
                    return;
                }
                for (int i = 0; i < excelLoader.DataSet.Tables.Count; i++)
                {
                    loadedList.Add(excelLoader.DataSet.Tables[i].TableName);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                }
                listSelectedIndex = 0;
                ListSelectedIndex = listSelectedIndex;
                borderColor = Brushes.Green;
                AprPathTextBoxBorderColor = borderColor;
                logger.Insert(0, $"{DateTime.Now} АПР файл по пути загружен: {dialog.FileName}");
                Logger = logger;

                DbUpdateRowEndEvent += ActionAfterLoadingApr;
                DbUpdateFalseEvent += ActionAfterFalseLoadingApr;
            }
            catch (Exception ex)
            {
                borderColor = Brushes.Red;
                AprPathTextBoxBorderColor = borderColor;
                logger.Insert(0, $"{DateTime.Now} При загрузке файла конфигураций возникло исключение. {ex.Message}");
                Logger = logger;
            }
        }

        /// <summary>
        /// Событие после завершения загрузки АПР.
        /// </summary>
        private void ActionAfterLoadingApr(string message)
        {
            logger.Insert(0, $"{DateTime.Now} {message}.");
            Logger = logger;
        }

        /// <summary>
        /// Событие сбоя загрузки АПР.
        /// </summary>
        private void ActionAfterFalseLoadingApr(Exception exc)
        {
            logger.Insert(0, $"{DateTime.Now} При загрузке файла АПР произошла ошибка. {exc.Message}");
            Logger = logger;
        }

        /// <summary>
        /// Очистить рабочее место.
        /// </summary>
        public void CleanUpWorkspace()
        {
            LockUI();
            var db = new APRContext();
            WorkstationIndex = db.LogicalWorkstations.First(a => a.ToolTip == WorkStationListSelectedItem).Id;
            Task.Run(() => {
                aprDbCrud.ClearAprsByWSID(WorkstationIndex);
            });
            logger.Insert(0, $"{DateTime.Now} Рабочее место очищено.");
            Logger = logger;
            UnlockUI();
        }

        public void RemoveTechnique()
        {
            LockUI();
            UpdateShootingParamSet();
            Task.Run(() => {
                aprDbCrud.ClearAprsByWSID(WorkstationIndex, CommonMapper.GetAprType(shootingParamSet));               
            });
            logger.Insert(0, $"{DateTime.Now} Техника удалена.");
            Logger = logger;
            UnlockUI();
        }

        private void UpdateShootingParamSet() =>
               shootingParamSet.Update(IsGraphyShootingChecked,
               IsSerialGraphyChecked,
               IsScopyShootingChecked,
               IsScopyHdShootingChecked,
               IsTomoSyntChecked,
               IsTomoChecked);

        public void CleanUpWgd()
        {
            var answer = MessageBox.Show("Вы уверены, что хотите очистить базу WGD? ☠", "Предупреждение", MessageBoxButton.YesNoCancel);
            if (answer == MessageBoxResult.Yes)
            {
                LockUI();
                try
                {
                    new WorkWithWgd().ClearStudies();
                    logger.Insert(0, $"{DateTime.Now} База данных WGD очищена.");
                    Logger = logger;                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось подключиться к базе данных WGD. Проверьте соединение и повторите попытку. {ex.Message}");
                    logger.Insert(0, $"{DateTime.Now} Отсутствует соединение с WGD.");
                    Logger = logger;
                }
                finally
                {
                    UnlockUI();
                }
            }
        }

        /// <summary>
        /// Заблокировать пользовательский интерфейс.
        /// </summary>
        private void UnlockUI()
        {
            stateOfUI = true;
            ChangeStateOfUI = stateOfUI;
        }

        /// <summary>
        /// Разблокировать пользовательский интерфейс.
        /// </summary>
        private void LockUI()
        {
            stateOfUI = false;
            ChangeStateOfUI = stateOfUI;
        }

        /// <summary>
        /// Загрузить апр.
        /// </summary>
        public void LoadApr()
        {
            try
            {
                if (excelLoader == null)
                {
                    MessageBox.Show("Необходимо выбрать файл с АПРами");
                    return;
                }
                LockUI();
                // в базе Id начинаются с единицы, а тут индексы с 0
                detectorIndex++;
                xlsxListIndex = listSelectedIndex;

                using (var db = new APRContext())
                {
                    var dbhw = new EPO_hardwareContext();

                    DetectorIndex = dbhw.HardwareDetectors.First(a => a.UniqueName == DetectorListSelectedItem).DetectorType;
                    WorkstationIndex = db.LogicalWorkstations.First(a => a.ToolTip == WorkStationListSelectedItem).Id;
                    SoftwareIndex = db.SoftwareInnerTypes.First(a => a.Comment == SoftwareListSelectedItem).Id;
                }

                UpdateShootingParamSet();

                //Запуск апдейта таблиц
                aprDbCrud.UpdateDB(DetectorIndex, WorkstationIndex, xlsxListIndex, SoftwareIndex, excelLoader, shootingParamSet);

                //Очищаем таблицы
                if (isNeededClearDb)
                {
                    Thread thread = new Thread(aprDbCrud.EraseTables);
                    thread.Priority = ThreadPriority.Highest;
                    thread.Start();
                    isNeededClearDb = false;
                }
                else
                {
                    AprDbCrud.Wait.Set();
                }
                DbUpdateRowEndEvent?.Invoke("Обновление успешно завершено");
                UnlockUI();
            }
            catch (Exception exc)
            {
                DbUpdateFalseEvent?.Invoke(exc);
            }  
        }

        /// <summary>
        /// Получить значение варианта поставки из базы.
        /// </summary>
        public static string GetSoftwareTypeFromDb()
        {
            try
            {
                var wgd = new WGDContext();

                string softwareType = wgd.CommonParameters.First(a => a.ParamName == "SoftwareType").ParamValue;
                string[] dop = softwareType.Split(':');
                int softwareTypeId = Convert.ToInt32(dop[0]);
                int uniqueId = Convert.ToInt32(dop[1]);

                var apr = new APRContext();
                string result = apr.SoftwareInnerTypes.First(a => a.SoftwareTypeId == softwareTypeId && a.UniqueId == uniqueId).Comment;
                return result;
            }
            catch (Exception exc)
            {
                return "Maxima";
            }
        }

        /// <summary>
        /// Инициалировать коллекции комбо боксов UI.
        /// </summary>
        internal void InitializeComboCollections()
        {
            try
            {
                var logicalWorkstations = aprDbCrud.GetLogicalWorkstations();
                foreach (var w in logicalWorkstations)
                    workstationList.Add(w.ToolTip);
                workstationListSelectedIndex = 0;
                WorkstationListSelectedIndex = workstationListSelectedIndex;

                foreach (var s in aprDbCrud.GetSoftwareInnerTypes())
                    softwareList.Add(s.Comment);
                softwareListSelectedItem  = GetSoftwareTypeFromDb();
                softwareListSelectedIndex = SoftwareList.IndexOf(softwareListSelectedItem);
                SoftwareListSelectedIndex = softwareListSelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось подключиться к базе данных APR. Проверьте соединение и повторите попытку. {ex.Message}");
                Environment.Exit(0);
            }
            try
            {
                var ws = aprDbCrud.GetLogicalWorkstationByToolTip(workstationList[0]);
                WorkstationIndex = ws.Id;
                WorkstationBackgrounds(ws);
                foreach (var r in aprDbCrud.GetDetectorWorkstationsById(ws.Id))
                    detectorList.Add(aprDbCrud.GetHardwareDetectorUniqueNameById(r.DetectorId));
                detectorListSelectedIndex = 0;
                DetectorListSelectedIndex = detectorListSelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось подключиться к базе данных HW. Проверьте соединение и повторите попытку. {ex.Message}");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Установить определенный цвет заднего фона в зависимости от логической рабочей станции.
        /// </summary>
        private void WorkstationBackgrounds(LogicalWorkstation ws)
        {
            tomoBackground = GetLedColor(ws.IsTomo);
            TomoBackground = tomoBackground;
            serialGraphyBackground = GetLedColor(ws.IsSerialGraphy);
            SerialGraphyBackground = serialGraphyBackground;
            scopyBackground = GetLedColor(ws.IsScopy);
            ScopyBackground = scopyBackground;
            aecBackground = GetLedColor(ws.IsAecEnabled);
            AecBackground = aecBackground;
        }

        /// <summary>
        /// Получить цвет, который необходимо установить.
        /// </summary>
        private Brush GetLedColor(bool state)
        {
            if (state) return Brushes.GreenYellow;
            else return Brushes.Gold;
        }
    }
}

