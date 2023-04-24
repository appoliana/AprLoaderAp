using AprLoader.Core;
using AprLoader.Core.DbServices;
using AprLoaderNew.APR;
using AprLoaderNew.EPO_Hardware;
using AprLoaderNew.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AprLoaderNew
{
    public class DetectorModel : OnPropertyChangedClass
    {
        public DetectorModel()
        {
            InitializeDbServices();
            InitializeCollectionsAsync();
        }

        // Db Service classes
        private IBasicDbService<DetectorType> detectorTypeDbService;
        private IBasicDbService<DetectorWorkstation> detectorWorkstationDbService;
        private IBasicDbService<HardwareDetector> hardwareDetectorDbService;
        private IBasicDbService<LogicalWorkstation> logicalWorkstationDbService;
        private IBasicDbService<GeneratorWorkStation> generatorWorkstationDbService;

        // Table Collections
        private List<DetectorType> detectorTypes = new List<DetectorType>();
        private List<DetectorWorkstation> detectorWorkstations = new List<DetectorWorkstation>();
        private List<HardwareDetector> hardwareDetectors = new List<HardwareDetector>();
        private List<LogicalWorkstation> logicalWorkstations = new List<LogicalWorkstation>();
        private List<GeneratorWorkStation> generatorWorkstations = new List<GeneratorWorkStation>();

        #region Model

        public string DetectorTypeIdText { get => detectorTypeIdText; set { detectorTypeIdText = value; OnPropertyChanged(); } }
        private string detectorTypeIdText = string.Empty;

        public string DetectorTypeIdNum { get => detectorTypeIdNum; set { detectorTypeIdNum = value; OnPropertyChanged(); } }
        private string detectorTypeIdNum = string.Empty;

        public string DetectorTypeIdName { get => detectorTypeIdName; set { detectorTypeIdName = value; OnPropertyChanged(); } }
        private string detectorTypeIdName = string.Empty;

        public string TableUpdateLogText { get => tableUpdateLogText; set { tableUpdateLogText = value; OnPropertyChanged(); } }
        private string tableUpdateLogText = string.Empty;

        public string ResultTextBlockText { get => resultTextBlockText; set { resultTextBlockText = value; OnPropertyChanged(); } }
        private string resultTextBlockText = string.Empty;

        public Brush ResultTextBlockColor { get => resultTextBlockColor; set { resultTextBlockColor = value; OnPropertyChanged(); } }
        private Brush resultTextBlockColor = Brushes.Gray;

        public object DetectorTypesListViewSelectedItem { get => detectorTypesListViewSelectedItem; set { detectorTypesListViewSelectedItem = value; OnPropertyChanged(); } }
        private object detectorTypesListViewSelectedItem;

        public string HardwareDetectorIdText { get => hardwareDetectorIdText; set { hardwareDetectorIdText = value; OnPropertyChanged(); } }
        private string hardwareDetectorIdText = string.Empty;

        public string HardwareDetectorNameText { get => hardwareDetectorNameText; set { hardwareDetectorNameText = value; OnPropertyChanged(); } }
        private string hardwareDetectorNameText = string.Empty;

        public string HardwareDetectorTlsFilePathText { get => hardwareDetectorTlsFilePathText; set { hardwareDetectorTlsFilePathText = value; OnPropertyChanged(); } }
        private string hardwareDetectorTlsFilePathText = string.Empty;

        public string HardwareDetectorPreProcessingTlsKeyText { get => hardwareDetectorPreProcessingTlsKeyText; set { hardwareDetectorPreProcessingTlsKeyText = value; OnPropertyChanged(); } }
        private string hardwareDetectorPreProcessingTlsKeyText = string.Empty;

        public bool HardwareDetectorIsUseText { get => hardwareDetectorIsUseText; set { hardwareDetectorIsUseText = value; OnPropertyChanged(); } }
        private bool hardwareDetectorIsUseText = false;

        public string HardwareDetectorDetectorTypeText { get => hardwareDetectorDetectorTypeText; set { hardwareDetectorDetectorTypeText = value; OnPropertyChanged(); } }
        private string hardwareDetectorDetectorTypeText = string.Empty;

        public string HardwareDetectorUniqueNameText { get => hardwareDetectorUniqueNameText; set { hardwareDetectorUniqueNameText = value; OnPropertyChanged(); } }
        private string hardwareDetectorUniqueNameText = string.Empty;

        public string HardwareDetectorImagePixelSpacingText { get => hardwareDetectorImagePixelSpacingText; set { hardwareDetectorImagePixelSpacingText = value; OnPropertyChanged(); } }
        private string hardwareDetectorImagePixelSpacingText = string.Empty;

        public string HardwareDetectorCalibratedImageSizeText { get => hardwareDetectorCalibratedImageSizeText; set { hardwareDetectorCalibratedImageSizeText = value; OnPropertyChanged(); } }
        private string hardwareDetectorCalibratedImageSizeText = string.Empty;

        public string HardwareDetectorAprVersion { get => hardwareDetectorAprVersion; set { hardwareDetectorAprVersion = value; OnPropertyChanged(); } }
        private string hardwareDetectorAprVersion = string.Empty;

        public object HardwareDetectorListViewSelectedItem { get => hardwareDetectorListViewSelectedItem; set { hardwareDetectorListViewSelectedItem = value; OnPropertyChanged(); } }
        private object hardwareDetectorListViewSelectedItem;  

        public object DetectorWorkstationsListViewSelectedItem { get => detectorWorkstationsListViewSelectedItem; set { detectorWorkstationsListViewSelectedItem = value; OnPropertyChanged(); } }
        private object detectorWorkstationsListViewSelectedItem;

        public string DetectorWorkstationIdText { get => detectorWorkstationIdText; set { detectorWorkstationIdText = value; OnPropertyChanged(); } }
        private string detectorWorkstationIdText = string.Empty;

        public string DetectorWorkstationLogicalWorkstationIdText { get => detectorWorkstationLogicalWorkstationIdText; set { detectorWorkstationLogicalWorkstationIdText = value; OnPropertyChanged(); } }
        private string detectorWorkstationLogicalWorkstationIdText = string.Empty;

        public string DetectorWorkstationDetectorIdText { get => detectorWorkstationDetectorIdText; set { detectorWorkstationDetectorIdText = value; OnPropertyChanged(); } }
        private string detectorWorkstationDetectorIdText = string.Empty;

        public string LogicalWorkstationIdText { get => logicalWorkstationIdText; set { logicalWorkstationIdText = value; OnPropertyChanged(); } }
        private string logicalWorkstationIdText = string.Empty;

        public string LogicalWorkstationWorkstationIdText { get => logicalWorkstationWorkstationIdText; set { logicalWorkstationWorkstationIdText = value; OnPropertyChanged(); } }
        private string logicalWorkstationWorkstationIdText = string.Empty;

        public bool LogicalWorkstationIsTomo { get => logicalWorkstationIsTomo; set { logicalWorkstationIsTomo = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsTomo = false;

        public bool LogicalWorkstationIsScopy { get => logicalWorkstationIsScopy; set { logicalWorkstationIsScopy = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsScopy = false;

        public bool LogicalWorkstationIsSerialGraphy { get => logicalWorkstationIsSerialGraphy; set { logicalWorkstationIsSerialGraphy = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsSerialGraphy = false;

        public bool LogicalWorkstationIsFilm { get => logicalWorkstationIsFilm; set { logicalWorkstationIsFilm = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsFilm = false;

        public bool LogicalWorkstationIsAecEnabled { get => logicalWorkstationIsAecEnabled; set { logicalWorkstationIsAecEnabled = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsAecEnabled = false;

        public string LogicalWorkstationUniqueNameText { get => logicalWorkstationUniqueNameText; set { logicalWorkstationUniqueNameText = value; OnPropertyChanged(); } }
        private string logicalWorkstationUniqueNameText = string.Empty;

        public string LogicalWorkstationToolTipText { get => logicalWorkstationToolTipText; set { logicalWorkstationToolTipText = value; OnPropertyChanged(); } }
        private string logicalWorkstationToolTipText = string.Empty;

        public bool LogicalWorkstationIsVisible { get => logicalWorkstationIsVisible; set { logicalWorkstationIsVisible = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsVisible = false;

        public string LogicalWorkstationUniqueIdText { get => logicalWorkstationUniqueIdText; set { logicalWorkstationUniqueIdText = value; OnPropertyChanged(); } }
        private string logicalWorkstationUniqueIdText = string.Empty;

        public bool LogicalWorkstationIsRaster { get => logicalWorkstationIsRaster; set { logicalWorkstationIsRaster = value; OnPropertyChanged(); } }
        private bool logicalWorkstationIsRaster = false;

        public string LogicalWorkstationDosimeterIdText { get => logicalWorkstationDosimeterIdText; set { logicalWorkstationDosimeterIdText = value; OnPropertyChanged(); } }
        private string logicalWorkstationDosimeterIdText = string.Empty;

        public object LogicalWorkstationsListViewSelectedItem { get => logicalWorkstationsListViewSelectedItem; set { logicalWorkstationsListViewSelectedItem = value; OnPropertyChanged(); } }
        private object logicalWorkstationsListViewSelectedItem;

        public string GeneratorWorkstationIdText { get => generatorWorkstationIdText; set { generatorWorkstationIdText = value; OnPropertyChanged(); } }
        private string generatorWorkstationIdText = string.Empty;

        public string GeneratorWorkstationNameText { get => generatorWorkstationNameText; set { generatorWorkstationNameText = value; OnPropertyChanged(); } }
        private string generatorWorkstationNameText = string.Empty;

        public string GeneratorWorkstationGenParValText { get => generatorWorkstationGenParValText; set { generatorWorkstationGenParValText = value; OnPropertyChanged(); } }
        private string generatorWorkstationGenParValText = string.Empty;

        public bool GeneratorWorkstationIsActive { get => generatorWorkstationIsActive; set { generatorWorkstationIsActive = value; OnPropertyChanged(); } }
        private bool generatorWorkstationIsActive = false;

        public bool GeneratorWorkstationIsAecEnabled { get => generatorWorkstationIsAecEnabled; set { generatorWorkstationIsAecEnabled = value; OnPropertyChanged(); } }
        private bool generatorWorkstationIsAecEnabled = false;

        public object GeneratorWorkStationsListViewSelectedItem { get => generatorWorkStationsListViewSelectedItem; set { generatorWorkStationsListViewSelectedItem = value; OnPropertyChanged(); } }
        private object generatorWorkStationsListViewSelectedItem;

        public List<DetectorType> DetectorTypesListViewItemSource { get => detectorTypesListViewItemSource; set { detectorTypesListViewItemSource = value; OnPropertyChanged(); } }
        private List<DetectorType> detectorTypesListViewItemSource = new List<DetectorType>();

        public List<HardwareDetector> HardwareDetectorListViewItemSource { get => hardwareDetectorListViewItemSource; set { hardwareDetectorListViewItemSource = value; OnPropertyChanged(); } }
        private List<HardwareDetector> hardwareDetectorListViewItemSource = new List<HardwareDetector>();

        public List<DetectorWorkstation> DetectorWorkstationsListViewItemSource { get => detectorWorkstationsListViewItemSource; set { detectorWorkstationsListViewItemSource = value; OnPropertyChanged(); } }
        private List<DetectorWorkstation> detectorWorkstationsListViewItemSource = new List<DetectorWorkstation>();

        public List<LogicalWorkstation> LogicalWorkstationsListViewItemSource { get => logicalWorkstationsListViewItemSource; set { logicalWorkstationsListViewItemSource = value; OnPropertyChanged(); } }
        private List<LogicalWorkstation> logicalWorkstationsListViewItemSource = new List<LogicalWorkstation>();

        public List<GeneratorWorkStation> GeneratorWorkStationsListViewItemSource { get => generatorWorkStationsListViewItemSource; set { generatorWorkStationsListViewItemSource = value; OnPropertyChanged(); } }
        private List<GeneratorWorkStation> generatorWorkStationsListViewItemSource = new List<GeneratorWorkStation>();

        #endregion

        #region Инициализация

        private void InitializeDbServices()
        {
            detectorTypeDbService = new DetectorTypeDbService();
            detectorTypeDbService.ExceptionRaised += MessageBox_DBExceptionRaised;

            detectorWorkstationDbService = new DetectorWorkstationDbService();
            detectorWorkstationDbService.ExceptionRaised += MessageBox_DBExceptionRaised;

            hardwareDetectorDbService = new HardwareDetectorDbService();
            hardwareDetectorDbService.ExceptionRaised += MessageBox_DBExceptionRaised;

            logicalWorkstationDbService = new LogicalWorkstationDbService();
            logicalWorkstationDbService.ExceptionRaised += MessageBox_DBExceptionRaised;

            generatorWorkstationDbService = new GeneratorWorkstationDbService();
            generatorWorkstationDbService.ExceptionRaised += MessageBox_DBExceptionRaised;
        }

        private async void InitializeCollectionsAsync()
        {
            detectorTypes.Clear();
            DetectorType[] dts = await detectorTypeDbService.GetAsArrayAsync();
            foreach (var dt in dts) detectorTypes.Add(dt);
            detectorTypesListViewItemSource = detectorTypes;
            DetectorTypesListViewItemSource = detectorTypesListViewItemSource;

            detectorWorkstations.Clear();
            DetectorWorkstation[] dws = await detectorWorkstationDbService.GetAsArrayAsync();
            foreach (var dw in dws) detectorWorkstations.Add(dw);
            detectorWorkstationsListViewItemSource = detectorWorkstations;
            DetectorWorkstationsListViewItemSource = detectorWorkstationsListViewItemSource;

            hardwareDetectors.Clear();
            HardwareDetector[] hds = await hardwareDetectorDbService.GetAsArrayAsync();
            foreach (var hd in hds) hardwareDetectors.Add(hd);
            hardwareDetectorListViewItemSource = hardwareDetectors;
            HardwareDetectorListViewItemSource = hardwareDetectorListViewItemSource;

            logicalWorkstations.Clear();
            LogicalWorkstation[] lws = await logicalWorkstationDbService.GetAsArrayAsync();
            foreach (var lw in lws) logicalWorkstations.Add(lw);
            logicalWorkstationsListViewItemSource = logicalWorkstations;
            LogicalWorkstationsListViewItemSource = logicalWorkstationsListViewItemSource;

            generatorWorkstations.Clear();
            GeneratorWorkStation[] gws = await generatorWorkstationDbService.GetAsArrayAsync();
            foreach (var gw in gws) generatorWorkstations.Add(gw);
            generatorWorkStationsListViewItemSource = generatorWorkstations;
            GeneratorWorkStationsListViewItemSource = generatorWorkStationsListViewItemSource;
        }

        #endregion

        #region Обработчики CRUD для DetectorType

        public async void AddDetectorTypeAsync()
        {
            var detectorType = BuildDetectorType();
            bool success = await detectorTypeDbService.AddAsync(detectorType);
            if (success)
            {
                detectorTypes.Add(detectorType);

                DetectorTypesListViewItemSource = new List<DetectorType>();
                detectorTypes.Clear();
                DetectorType[] dts = await detectorTypeDbService.GetAsArrayAsync();
                foreach (var dtt in dts) detectorTypes.Add(dtt);
                DetectorTypesListViewItemSource = detectorTypes;

                TableUpdateLogText = "Операция добавления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
        }

        public async void RemoveDetectorTypeAsync()
        {
            var detectorType = BuildDetectorType();

            // Проверяем кроссреференс с HardwareDetector
            if (hardwareDetectors.Any(x => x.DetectorType == detectorType.Id))
            {
                TableUpdateLogText = $"\nОшибка операции. \nНевозможно удалить DetectorType с ID={detectorType.Id}, поскольку это нарушит неявную связь с таблицей HardwareDetector";
                ResultTextBlockText = "ошибка, нарушение неявной связи";
                ResultTextBlockColor = Brushes.Red;
                return;
            }

            bool success = await detectorTypeDbService.RemoveAsync(detectorType);
            if (success)
            {
                detectorTypes.Remove((DetectorType)detectorTypesListViewSelectedItem);

                DetectorTypesListViewItemSource = new List<DetectorType>();
                detectorTypes.Clear();
                DetectorType[] dts = await detectorTypeDbService.GetAsArrayAsync();
                foreach (var dtt in dts) detectorTypes.Add(dtt);
                DetectorTypesListViewItemSource = detectorTypes;

                TableUpdateLogText = "Операция удаления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
        }

        public async void UpdateDetectorTypeAsync()
        {
            var detectorType = BuildDetectorType();
            bool success = await detectorTypeDbService.UpdateAsync(detectorType);
            if (success)
            {
                var dt = detectorTypes.FirstOrDefault(x => x.Id == detectorType.Id);
                var index = detectorTypes.IndexOf(dt);
                detectorTypes[index] = detectorType;

                DetectorTypesListViewItemSource = new List<DetectorType>();
                detectorTypes.Clear();
                DetectorType[] dts = await detectorTypeDbService.GetAsArrayAsync();
                foreach (var dtt in dts) detectorTypes.Add(dtt);
                DetectorTypesListViewItemSource = detectorTypes;

                TableUpdateLogText = "Операция редактирования успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
        }

        #endregion

        #region Обработчики CRUD для HardwareDetector

        public async void AddHardwareDetectorAsync()
        {
            var hardwareDetector = BuildHardwareDetector();
            bool success = await hardwareDetectorDbService.AddAsync(hardwareDetector);
            if (success)
            {
                hardwareDetectors.Add(hardwareDetector);

                hardwareDetectors.Clear();
                HardwareDetectorListViewItemSource = new List<HardwareDetector>();
                HardwareDetector[] hds = await hardwareDetectorDbService.GetAsArrayAsync();
                foreach (var hd in hds) hardwareDetectors.Add(hd);
                HardwareDetectorListViewItemSource = hardwareDetectors;

                TableUpdateLogText = "Операция добавления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция добавления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void RemoveHardwareDetectorAsync()
        {
            var hardwareDetector = BuildHardwareDetector();

            // Проверяем кроссреференс с DetectorWorkstations
            if (detectorWorkstations.Any(x => x.DetectorId == hardwareDetector.Id))
            {
                TableUpdateLogText = $"\nОшибка операции. \nНевозможно удалить HardwareDetector с ID={hardwareDetector.Id}, поскольку это нарушит неявную связь с таблицей [APR].[dbo].[DetectorType]";
                ResultTextBlockText = "ошибка, нарушение неявной связи";
                ResultTextBlockColor = Brushes.Red;
                return;
            }

            bool success = await hardwareDetectorDbService.RemoveAsync(hardwareDetector);
            if (success)
            {
                hardwareDetectors.Remove((HardwareDetector)hardwareDetectorListViewSelectedItem);

                hardwareDetectors.Clear();
                HardwareDetectorListViewItemSource = new List<HardwareDetector>();
                HardwareDetector[] hds = await hardwareDetectorDbService.GetAsArrayAsync();
                foreach (var hd in hds) hardwareDetectors.Add(hd);
                HardwareDetectorListViewItemSource = hardwareDetectors;

                TableUpdateLogText = "Операция удаления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция удаления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void UpdateHardwareDetectorAsync()
        {
            var hardwareDetector = BuildHardwareDetector();

            // Проверяем кроссреференс с HardwareDetector
            if (!detectorTypes.Any(x => x.Id == hardwareDetector.DetectorType))
            {
                TableUpdateLogText = $"\nОшибка операции. \nНевозможно обновить HardwareDetector с ID={hardwareDetector.Id}, поскольку это нарушит неявную связь с таблицей [APR].[dbo].[DetectorType]";
                ResultTextBlockText = "ошибка, нарушение неявной связи";
                ResultTextBlockColor = Brushes.Red;
                return;
            }

            bool success = await hardwareDetectorDbService.UpdateAsync(hardwareDetector);
            if (success)
            {
                var dt = hardwareDetectors.FirstOrDefault(x => x.Id == hardwareDetector.Id);
                var index = hardwareDetectors.IndexOf(dt);
                hardwareDetectors[index] = hardwareDetector;

                HardwareDetectorListViewItemSource = new List<HardwareDetector>();
                hardwareDetectors.Clear();
                HardwareDetector[] hds = await hardwareDetectorDbService.GetAsArrayAsync();
                foreach (var hd in hds) hardwareDetectors.Add(hd);
                HardwareDetectorListViewItemSource = hardwareDetectors;

                TableUpdateLogText = "Операция редактирования успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция редактирования не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        #endregion

        #region Обработчики CRUD для DetectorWorkstation

        public async void AddDetectorWorkstationAsync()
        {
            var detectorWorkstation = BuildDetectorWorkstation();
            bool success = await detectorWorkstationDbService.AddAsync(detectorWorkstation);
            if (success)
            {
                detectorWorkstations.Add(detectorWorkstation);

                detectorWorkstations.Clear();
                DetectorWorkstationsListViewItemSource = new List<DetectorWorkstation>();
                DetectorWorkstation[] dws = await detectorWorkstationDbService.GetAsArrayAsync();
                foreach (var dw in dws) detectorWorkstations.Add(dw);
                DetectorWorkstationsListViewItemSource = detectorWorkstations;

                TableUpdateLogText = "Операция добавления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция добавления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void RemoveDetectorWorkstationAsync()
        {
            var detectorWorkstation = BuildDetectorWorkstation();
            bool success = await detectorWorkstationDbService.RemoveAsync(detectorWorkstation);
            if (success)
            {
                detectorWorkstations.Remove((DetectorWorkstation)detectorWorkstationsListViewSelectedItem);

                detectorWorkstations.Clear();
                DetectorWorkstationsListViewItemSource = new List<DetectorWorkstation>();
                var dws = await detectorWorkstationDbService.GetAsArrayAsync();
                foreach (var dw in dws) detectorWorkstations.Add(dw);
                DetectorWorkstationsListViewItemSource = detectorWorkstations;

                TableUpdateLogText = "Операция удаления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция удаления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void UpdateDetectorWorkstationAsync()
        {
            var detectorWorkstation = BuildDetectorWorkstation();

            // Проверяем кроссреференс с HardwareDetector
            if (!hardwareDetectors.Any(x => x.Id == detectorWorkstation.DetectorId))
            {
                TableUpdateLogText = $"\nОшибка операции\n Невозможно обновить DetectorWorkstation с ID={detectorWorkstation.Id}, поскольку это нарушит неявную связь с таблицей [EPO_hardware].[dbo].[HardwareDetector]";
                ResultTextBlockText = "ошибка, нарушение неявной связи";
                ResultTextBlockColor = Brushes.Red;
                return;
            }

            bool success = await detectorWorkstationDbService.UpdateAsync(detectorWorkstation);
            if (success)
            {
                var dt = detectorWorkstations.FirstOrDefault(x => x.Id == detectorWorkstation.Id);
                var index = detectorWorkstations.IndexOf(dt);
                detectorWorkstations[index] = detectorWorkstation;

                // Заново обновляем ListView
                detectorWorkstations.Clear();
                DetectorWorkstationsListViewItemSource = new List<DetectorWorkstation>();
                DetectorWorkstation[] dws = await detectorWorkstationDbService.GetAsArrayAsync();
                foreach (var dw in dws) detectorWorkstations.Add(dw);
                DetectorWorkstationsListViewItemSource = detectorWorkstations;

                TableUpdateLogText = "Операция редактирования успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция редактирования не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        #endregion

        #region Обработчики CRUD для LogicalWorkstation

        public async void AddLogicalWorkstationAsync()
        {
            var logicalWorkstation = BuildLogicalWorkstation();
            bool success = await logicalWorkstationDbService.AddAsync(logicalWorkstation);
            if (success)
            {
                logicalWorkstations.Add(logicalWorkstation);

                logicalWorkstations.Clear();
                LogicalWorkstationsListViewItemSource = new List<LogicalWorkstation>();
                LogicalWorkstation[] lws = await logicalWorkstationDbService.GetAsArrayAsync();
                foreach (var lw in lws) logicalWorkstations.Add(lw);
                LogicalWorkstationsListViewItemSource = logicalWorkstations;

                TableUpdateLogText = "Операция добавления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция добавления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void RemoveLogicalWorkstationAsync()
        {
            var logicalWorkstation = BuildLogicalWorkstation();
            bool success = await logicalWorkstationDbService.RemoveAsync(logicalWorkstation);
            if (success)
            {
                logicalWorkstations.Remove((LogicalWorkstation)logicalWorkstationsListViewSelectedItem);

                logicalWorkstations.Clear();
                LogicalWorkstationsListViewItemSource = new List<LogicalWorkstation>();
                LogicalWorkstation[] lws = await logicalWorkstationDbService.GetAsArrayAsync();
                foreach (var lw in lws) logicalWorkstations.Add(lw);
                LogicalWorkstationsListViewItemSource = logicalWorkstations;

                TableUpdateLogText = "Операция удаления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция удаления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void UpdateLogicalWorkstationAsync()
        {
            var logicalWorkstation = BuildLogicalWorkstation();
            bool success = await logicalWorkstationDbService.UpdateAsync(logicalWorkstation);
            if (success)
            {
                var dt = logicalWorkstations.FirstOrDefault(x => x.Id == logicalWorkstation.Id);
                var index = logicalWorkstations.IndexOf(dt);
                logicalWorkstations[index] = logicalWorkstation;

                logicalWorkstations.Clear();
                LogicalWorkstationsListViewItemSource = new List<LogicalWorkstation>();
                LogicalWorkstation[] lws = await logicalWorkstationDbService.GetAsArrayAsync();
                foreach (var lw in lws) logicalWorkstations.Add(lw);
                LogicalWorkstationsListViewItemSource = logicalWorkstations;

                TableUpdateLogText = "Операция редактирования успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция редактирования не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        #endregion

        #region Обработчики CRUD для GeneratorWorkStation

        public async void AddGeneratorWorkstationAsync()
        {
            var generatorWorkstation = BuildGeneratorWorkstation();
            bool success = await generatorWorkstationDbService.AddAsync(generatorWorkstation);
            if (success)
            {
                generatorWorkstations.Add(generatorWorkstation);

                generatorWorkstations.Clear();
                GeneratorWorkStationsListViewItemSource = new List<GeneratorWorkStation>();
                GeneratorWorkStation[] gws = await generatorWorkstationDbService.GetAsArrayAsync();
                foreach (var gw in gws) generatorWorkstations.Add(gw);
                GeneratorWorkStationsListViewItemSource = generatorWorkstations;

                TableUpdateLogText = "Операция добавления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция добавления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void RemoveGeneratorWorkstationAsync()
        {
            var generatorWorkstation = BuildGeneratorWorkstation();
            bool success = await generatorWorkstationDbService.RemoveAsync(generatorWorkstation);
            if (success)
            {
                generatorWorkstations.Remove((GeneratorWorkStation)generatorWorkStationsListViewSelectedItem);

                generatorWorkstations.Clear();
                GeneratorWorkStationsListViewItemSource = new List<GeneratorWorkStation>();
                GeneratorWorkStation[] gws = await generatorWorkstationDbService.GetAsArrayAsync();
                foreach (var gw in gws) generatorWorkstations.Add(gw);
                GeneratorWorkStationsListViewItemSource = generatorWorkstations;

                TableUpdateLogText = "Операция удаления успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция удаления не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        public async void UpdateGeneratorWorkstationAsync()
        {
            var generatorWorkstation = BuildGeneratorWorkstation();
            bool success = await generatorWorkstationDbService.UpdateAsync(generatorWorkstation);
            if (success)
            {
                var dt = generatorWorkstations.FirstOrDefault(x => x.Id == generatorWorkstation.Id);
                var index = generatorWorkstations.IndexOf(dt);
                generatorWorkstations[index] = generatorWorkstation;

                generatorWorkstations.Clear();
                GeneratorWorkStationsListViewItemSource = new List<GeneratorWorkStation>();
                GeneratorWorkStation[] gws = await generatorWorkstationDbService.GetAsArrayAsync();
                foreach (var gw in gws) generatorWorkstations.Add(gw);
                GeneratorWorkStationsListViewItemSource = generatorWorkstations;

                TableUpdateLogText = "Операция редактирования успешно завершена";
                ResultTextBlockText = "успешно";
                ResultTextBlockColor = Brushes.Green;
            }
            else
            {
                TableUpdateLogText = "Операция редактирования не выполнена";
                ResultTextBlockText = "не удалось";
                ResultTextBlockColor = Brushes.Red;
            }
        }

        #endregion

        #region Обработчики остальных событий

        /// <summary>
        /// Обработка эксепшенов CRUD операций над таблицами
        /// </summary>
        /// <param name="sender">объект сервиса, в котором вылетел эксепшн</param>
        /// <param name="ex">эксепшн CRUD операции</param>
        private void MessageBox_DBExceptionRaised(object sender, Exception ex)
        {
            if (sender is GeneratorWorkstationDbService)
            {
                var sb = new StringBuilder();
                sb.Append("\nОшибка операции\n");
                sb.Append("Не удалось провести операцию по [APR].[dbo].[GeneratorWorkstation].\n\n");
                sb.Append("- (При удалении) Проверьте, что таблица [APR].[dbo].[LogicalWorkstation] не ссылается на Id данной таблицы;\n");
                sb.Append("- Проверьте заполненность всех полей.");

                tableUpdateLogText = sb.ToString();
            }

            if (sender is LogicalWorkstationDbService)
            {
                var sb = new StringBuilder();
                sb.Append("\nОшибка операции\n");
                sb.Append("Не удалось провести операцию по [APR].[dbo].[LogicalWorkstation].\n\n");
                sb.Append("- (При удалении) Проверьте, что поле таблицы [APR].[dbo].[DetectorWorkstation].[LogicalWorkstationId] не ссылается на Id данной таблицы;\n");
                sb.Append("- (При редактировании / добавлении) Проверьте, что 'Id рабочей станции' соответствует одному из значений [APR].[dbo].[GeneratorWorkStation].[Id];\n");
                sb.Append("- Проверьте заполненность всех полей.\n");

                tableUpdateLogText = sb.ToString();
            }

            if (sender is DetectorWorkstationDbService)
            {
                var sb = new StringBuilder();
                sb.Append("\nОшибка операции\n");
                sb.Append("Не удалось провести операцию по [APR].[dbo].[DetectorWorkstation].\n\n");
                sb.Append("- (При редактировании / добавлении) Проверьте, что 'Logical Workst. Id' соответствует одному из значений [APR].[dbo].[LogicalWorkstation].[Id];\n");
                sb.Append("- Проверьте заполненность всех полей.\n");

                tableUpdateLogText = sb.ToString();
            }

            if (sender is HardwareDetectorDbService)
            {
                var sb = new StringBuilder();
                sb.Append("\nОшибка операции\n");
                sb.Append("Не удалось провести операцию по [EPO_hardware].[dbo].[HardwareDetector].\n\n");
                sb.Append("- (При редактировании / добавлении) Проверьте, что 'Тип детектора' соответствует одному из значений [APR].[dbo].[DetectorType].[Id];\n");
                sb.Append("- Проверьте заполненность всех полей.\n");
                // Удаление перехвачено в CRUD!

                tableUpdateLogText = sb.ToString();
            }

            if (sender is DetectorTypeDbService)
            {
                var sb = new StringBuilder();
                sb.Append("\nОшибка операции\n");
                sb.Append("Не удалось провести операцию по [APR].[dbo].[DetectorType].\n\n");
                sb.Append("- (При удалении) Проверьте, что поле таблицы [APR].[dbo].[HardwareDetector].[DetectorType] ('Тип детектора') не ссылается на Id данной таблицы;\n");
                sb.Append("- Проверьте заполненность всех полей.\n");

                tableUpdateLogText = sb.ToString();
            }

            resultTextBlockText = "ошибка";
            resultTextBlockColor = Brushes.Red;
        }

        public void DetectorTypesListViewSelectionChanged()
        {
            if (detectorTypesListViewSelectedItem is DetectorType)
            {
                var selectedDetectorType = (DetectorType)detectorTypesListViewSelectedItem;
                DetectorTypeIdText = selectedDetectorType.Id.ToString();
                DetectorTypeIdName = selectedDetectorType.Name;
                DetectorTypeIdNum = selectedDetectorType.Type.ToString();
            }
        }

        public void HardwareDetectorListViewSelectionChanged()
        {
            if (hardwareDetectorListViewSelectedItem is HardwareDetector)
            {
                var selectedHardwareDetector = (HardwareDetector)hardwareDetectorListViewSelectedItem;
                HardwareDetectorIdText = selectedHardwareDetector.Id.ToString();
                HardwareDetectorNameText = selectedHardwareDetector.Name;
                HardwareDetectorTlsFilePathText = selectedHardwareDetector.TlsFilePath;
                HardwareDetectorPreProcessingTlsKeyText = selectedHardwareDetector.PreProcessingTlsKey;
                HardwareDetectorIsUseText = selectedHardwareDetector.IsUse;
                HardwareDetectorDetectorTypeText = selectedHardwareDetector.DetectorType.ToString();
                HardwareDetectorUniqueNameText = selectedHardwareDetector.UniqueName;
                HardwareDetectorImagePixelSpacingText = selectedHardwareDetector.ImagePixelSpacing;
                HardwareDetectorCalibratedImageSizeText = selectedHardwareDetector.CalibratedImageSize;
                HardwareDetectorAprVersion = selectedHardwareDetector.AprVersion;
            }
        }

        public void DetectorWorkstationsListViewSelectionChanged()
        {
            if (detectorWorkstationsListViewSelectedItem is DetectorWorkstation)
            {
                var selectedDetectorWorkstation = (DetectorWorkstation)detectorWorkstationsListViewSelectedItem;
                DetectorWorkstationIdText = selectedDetectorWorkstation.Id.ToString();
                DetectorWorkstationLogicalWorkstationIdText = selectedDetectorWorkstation.LogicalWorkstationId.ToString();
                DetectorWorkstationDetectorIdText = selectedDetectorWorkstation.DetectorId.ToString();
            }
        }

        public void LogicalWorkstationsListViewSelectionChanged()
        {
            if (logicalWorkstationsListViewSelectedItem is LogicalWorkstation)
            {
                var selectedLogicalWorkstation = (LogicalWorkstation)logicalWorkstationsListViewSelectedItem;
                LogicalWorkstationIdText = selectedLogicalWorkstation.Id.ToString();
                LogicalWorkstationWorkstationIdText = selectedLogicalWorkstation.WorkstationId.ToString();
                LogicalWorkstationIsTomo = selectedLogicalWorkstation.IsTomo;
                LogicalWorkstationIsScopy = selectedLogicalWorkstation.IsScopy;
                LogicalWorkstationIsSerialGraphy = selectedLogicalWorkstation.IsSerialGraphy;
                LogicalWorkstationIsFilm = selectedLogicalWorkstation.IsFilm;
                LogicalWorkstationIsAecEnabled = selectedLogicalWorkstation.IsAecEnabled;
                LogicalWorkstationUniqueNameText = selectedLogicalWorkstation.UniqueName;
                LogicalWorkstationToolTipText = selectedLogicalWorkstation.ToolTip;
                LogicalWorkstationIsVisible = (bool)selectedLogicalWorkstation.IsVisible;
                LogicalWorkstationUniqueIdText = selectedLogicalWorkstation.UniqueId.ToString();
                LogicalWorkstationIsRaster = selectedLogicalWorkstation.IsRaster;
                LogicalWorkstationDosimeterIdText = selectedLogicalWorkstation.DosimeterId.ToString();
            }
        }

        public void GeneratorWorkStationsListViewSelectionChanged()
        {
            if (generatorWorkStationsListViewSelectedItem is GeneratorWorkStation)
            {
                var selectedGeneratorWorkStation = (GeneratorWorkStation)generatorWorkStationsListViewSelectedItem;
                GeneratorWorkstationIdText = selectedGeneratorWorkStation.Id.ToString();
                GeneratorWorkstationNameText = selectedGeneratorWorkStation.Name;
                GeneratorWorkstationGenParValText = selectedGeneratorWorkStation.GeneratorParameterValue.ToString();
                GeneratorWorkstationIsActive = selectedGeneratorWorkStation.IsActive;
                GeneratorWorkstationIsAecEnabled = selectedGeneratorWorkStation.IsAecEnabled;
            }
        }
        
        public void ClearLog()
        {
            TableUpdateLogText = string.Empty;
        }

        public void InitializeCollections()
        {
            InitializeCollectionsAsync();
        }

        #endregion

        #region Билдеры объектов из UI

        private DetectorType BuildDetectorType()
        {
            var detectorType = new DetectorType();
            int.TryParse(DetectorTypeIdText, out int id);
            int.TryParse(DetectorTypeIdNum, out int num);

            detectorType.Id = id;
            detectorType.Name = DetectorTypeIdName;
            detectorType.Type = num;

            return detectorType;        
        }

        private HardwareDetector BuildHardwareDetector()
        {
            var hardwareDetector = new HardwareDetector();
            int.TryParse(hardwareDetectorIdText, out int id);
            int.TryParse(hardwareDetectorDetectorTypeText, out int detectorType);

            hardwareDetector.Id = id;
            hardwareDetector.Name = hardwareDetectorNameText;
            hardwareDetector.TlsFilePath = hardwareDetectorTlsFilePathText;
            hardwareDetector.PreProcessingTlsKey = hardwareDetectorPreProcessingTlsKeyText;
            hardwareDetector.IsUse = HardwareDetectorIsUseText;
            hardwareDetector.DetectorType = detectorType;
            hardwareDetector.UniqueName = hardwareDetectorUniqueNameText;
            hardwareDetector.ImagePixelSpacing = hardwareDetectorImagePixelSpacingText;
            hardwareDetector.CalibratedImageSize = hardwareDetectorCalibratedImageSizeText;
            hardwareDetector.AprVersion = hardwareDetectorAprVersion != "NULL" ? hardwareDetectorAprVersion : null;

            return hardwareDetector;
        }

        private DetectorWorkstation BuildDetectorWorkstation()
        {
            var detectorWorkstation = new DetectorWorkstation();
            int.TryParse(detectorWorkstationIdText, out int id);
            int.TryParse(detectorWorkstationLogicalWorkstationIdText, out int logicalWorkstationId);
            int.TryParse(detectorWorkstationDetectorIdText, out int detectorId);

            detectorWorkstation.Id = id;
            detectorWorkstation.LogicalWorkstationId = logicalWorkstationId;
            detectorWorkstation.DetectorId = detectorId;

            return detectorWorkstation;
        }

        private LogicalWorkstation BuildLogicalWorkstation()
        {
            var logicalWorkstation = new LogicalWorkstation();
            int.TryParse(logicalWorkstationIdText, out int id);
            int.TryParse(logicalWorkstationWorkstationIdText, out int workstationId);
            int.TryParse(logicalWorkstationUniqueIdText, out int uniqueId);
            int.TryParse(logicalWorkstationDosimeterIdText, out int dosimeterId);

            logicalWorkstation.Id = id;
            logicalWorkstation.WorkstationId = workstationId;
            logicalWorkstation.IsTomo = logicalWorkstationIsTomo;
            logicalWorkstation.IsScopy = logicalWorkstationIsScopy;
            logicalWorkstation.IsSerialGraphy = logicalWorkstationIsSerialGraphy;
            logicalWorkstation.IsFilm = logicalWorkstationIsFilm;
            logicalWorkstation.IsAecEnabled = logicalWorkstationIsAecEnabled;
            logicalWorkstation.UniqueName = logicalWorkstationUniqueNameText;
            logicalWorkstation.ToolTip = logicalWorkstationToolTipText;
            logicalWorkstation.IsVisible = logicalWorkstationIsVisible;
            logicalWorkstation.UniqueId = uniqueId;
            logicalWorkstation.IsRaster = logicalWorkstationIsRaster;
            logicalWorkstation.DosimeterId = dosimeterId;

            return logicalWorkstation;
        }

        private GeneratorWorkStation BuildGeneratorWorkstation()
        {
            var generatorWorkstation = new GeneratorWorkStation();
            int.TryParse(generatorWorkstationIdText, out int id);
            int.TryParse(generatorWorkstationGenParValText, out int genParVal);

            generatorWorkstation.Id = id;
            generatorWorkstation.Name = generatorWorkstationNameText;
            generatorWorkstation.GeneratorParameterValue = genParVal;
            generatorWorkstation.IsActive = generatorWorkstationIsActive;
            generatorWorkstation.IsAecEnabled = generatorWorkstationIsAecEnabled;

            return generatorWorkstation;
        }

        #endregion
    }
}
