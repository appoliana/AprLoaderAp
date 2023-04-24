using AprLoader;
using AprLoader.Core;
using AprLoader.Models;
using AprLoaderNew.APR;
using AprLoaderNew.EPO_Hardware;
using AprLoaderNew.Models;
using AprLoaderNew.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;

namespace AprLoaderNew.ViewModel
{
    public class AutoLoadingViewModel : ViewModelBase
    {
        public AutoLoadingViewModel()
        {
            InitializeCrud();
            DbUpdateFeedbackEvent += ChangedProgressBar;
            DbUpdateRowEndEvent   += ActionAfterLoadingApr;
            DbUpdateFalseEvent    += ActionAfterFalseLoadingApr;
        }

        /// <summary>
        /// Событие по завершению загрузки одного сопоставления через UpdateDB.
        /// </summary>
        public event Action<int> DbUpdateFeedbackEvent;

        /// <summary>
        /// Событие по окончанию загрузки всего АПР-файла.
        /// </summary>
        public event Action DbUpdateRowEndEvent;

        /// <summary>
        /// Событие сбоя загрузки всего АПР-файла.
        /// </summary>
        public event Action DbUpdateFalseEvent;

        public ExcelLoader? excelLoader;
        private AprDbCrud aprDbCrud;
        private XmlElement AprSettings;
        private XmlNode SupplyOption;
        private XmlDocument doc;
        private ShootingParamSet shootingParamSet = new ShootingParamSet();

        private ICommand? findFile;
        private ICommand? addNewWorkStation;
        private ICommand? editWorkSpace;
        private ICommand? saveConfiguration;
        private ICommand? deleteConfiguration;
        private ICommand? loadApr;
        private ICommand? saveAllConfiguration;
        private ICommand? сreateNewConfiguration;

        private string loadFilePath             = string.Empty;
        private string supplyOptionSelectedItem = string.Empty;
        private string configurationName        = string.Empty;
        private string suplOptionName           = string.Empty;
        private string workSpaceSelectedItem    = string.Empty;
        private string messageAfterLoading      = string.Empty;
        private string detectorSelectedItem     = string.Empty;
        private string softwareSelectedItem     = string.Empty;

        private bool progressVisibility         = false;
        private bool configurationNameIsEnabled = false;
        private bool isWorkSpaceItemsEnabled    = false;
        private bool isDetectorItemsEnabled     = false;
        private bool isDeleteEnabled            = false;
        private bool isEditEnabled              = false;
        private bool workSpaceEnabled           = false;
        private bool isLoadEnabled              = false;
        private bool isCreateNewEnabled         = false;
        private bool isWeWantCreateANewConfig   = false;
        private bool isSaveEnabled              = false;
        private bool isSaveAllEnabled           = false;
        private bool isSoftwareVisible          = false;

        private int currentProgress        = 0;
        private int workSpaceSelectedIndex = 0;
        private int softwareSelectedIndex  = 0;
        private int detectorSelectedIndex  = 0;

        private Brush workSpaceBorderBrush = Brushes.Gray;
        private Brush saveBackground       = Brushes.White;

        private List<TechniqueEnum> listWorkStationsItemSource      = new List<TechniqueEnum>();
        private ObservableCollection<string> supplyOptionItemSource = new ObservableCollection<string>();
        private ObservableCollection<string> softwareItemSource     = new ObservableCollection<string>();
        private ObservableCollection<string> loadedList             = new ObservableCollection<string>();
        private ObservableCollection<string> workSpaceItemSource    = new ObservableCollection<string>();
        private ObservableCollection<string> detectorItemSource     = new ObservableCollection<string>();

        private ObservableCollection<WorkStationsViewModel> workStationsVM = new ObservableCollection<WorkStationsViewModel>();

        public List<TechniqueEnum> ListWorkStationsItemSource { get => listWorkStationsItemSource; set { listWorkStationsItemSource = value; OnPropertyChanged(); } }
        public ObservableCollection<string> DetectorItemSource { get => detectorItemSource; set { detectorItemSource = value; OnPropertyChanged(); } }
        public ObservableCollection<string> SoftwareItemSource { get => softwareItemSource; set { softwareItemSource = value; OnPropertyChanged(); } }
        public ObservableCollection<string> WorkSpaceItemSource { get => workSpaceItemSource; set { workSpaceItemSource = value; OnPropertyChanged(); } }
        public ObservableCollection<string> SupplyOptionItemSource { get => supplyOptionItemSource; set { supplyOptionItemSource = value; OnPropertyChanged(); } }
        public ObservableCollection<WorkStationsViewModel> WorkStationsVM { get => workStationsVM; set { SetProperty(ref workStationsVM, value, () => WorkStationsVM); } }

        public int CurrentProgress { get => currentProgress; set { currentProgress = value; OnPropertyChanged(); } }
        public int DetectorSelectedIndex  { get => detectorSelectedIndex; set { detectorSelectedIndex = value; OnPropertyChanged(); } }
        public int SoftwareSelectedIndex  { get => softwareSelectedIndex; set { softwareSelectedIndex = value; OnPropertyChanged(); } }
        public int WorkSpaceSelectedIndex { get => workSpaceSelectedIndex; set { workSpaceSelectedIndex = value; OnPropertyChanged(); } }

        public Brush WorkSpaceBorderBrush { get => workSpaceBorderBrush; set { workSpaceBorderBrush = value; OnPropertyChanged(); } }
        public Brush SaveBackground { get => saveBackground; set { saveBackground = value; OnPropertyChanged(); } }

        public bool ProgressVisibility { get => progressVisibility; set { progressVisibility = value; OnPropertyChanged(); } }
        public bool IsSoftwareVisible { get => isSoftwareVisible; set { isSoftwareVisible = value; OnPropertyChanged(); } }
        public bool IsDetectorItemsEnabled { get => isDetectorItemsEnabled; set { isDetectorItemsEnabled = value; OnPropertyChanged(); } }
        public bool IsSaveAllEnabled { get => isSaveAllEnabled; set { isSaveAllEnabled = value; OnPropertyChanged(); } }
        public bool IsSaveEnabled { get => isSaveEnabled; set { isSaveEnabled = value; OnPropertyChanged(); } }
        public bool WorkSpaceEnabled { get => workSpaceEnabled; set { workSpaceEnabled = value; OnPropertyChanged(); } }
        public bool IsDeleteEnabled { get => isDeleteEnabled; set { isDeleteEnabled = value; OnPropertyChanged(); } }
        public bool IsEditEnabled { get => isEditEnabled; set { isEditEnabled = value; OnPropertyChanged(); } }
        public bool IsCreateNewEnabled { get => isCreateNewEnabled; set { isCreateNewEnabled = value; OnPropertyChanged(); } }
        public bool IsLoadEnabled { get => isLoadEnabled; set { isLoadEnabled = value; OnPropertyChanged(); } }
        public bool IsWorkSpaceItemsEnabled { get => isWorkSpaceItemsEnabled; set { isWorkSpaceItemsEnabled = value; OnPropertyChanged(); } }
        public bool ConfigurationNameIsEnabled { get => configurationNameIsEnabled; set { configurationNameIsEnabled = value; OnPropertyChanged(); } }

        public string DetectorSelectedItem { get => detectorSelectedItem; set { detectorSelectedItem = value; OnPropertyChanged(); } }
        public string SoftwareSelectedItem { get => softwareSelectedItem; set { softwareSelectedItem = value; OnPropertyChanged(); } }
        public string AprTextUpdate { get => loadFilePath; set { loadFilePath = value; OnPropertyChanged(); } }
        public string ConfigurationName { get => configurationName; set { configurationName = value; OnPropertyChanged(); } }
        public string SuplOptionName { get => suplOptionName; set { suplOptionName = value; OnPropertyChanged(); } }
        public string MessageAfterLoading { get => messageAfterLoading; set { messageAfterLoading = value; OnPropertyChanged(); } }
        public string WorkSpaceSelectedItem 
        { 
            get => workSpaceSelectedItem; 
            set 
            { 
                workSpaceSelectedItem = value;
                IsDeleteEnabled       = true;
                IsEditEnabled         = true;
                 
                ShowLists();
                OnPropertyChanged();
                ShowDetectorsItems();
            } 
        }
        public string SupplyOptionSelectedItem 
        { 
            get => supplyOptionSelectedItem; 
            set 
            { 
                supplyOptionSelectedItem = value;
                IsSaveEnabled            = false;
                IsSaveAllEnabled         = false;
                IsWorkSpaceItemsEnabled  = true;
                IsLoadEnabled            = true;

                WorkSpaceBorderBrush = Brushes.Gray;
                ShowConfigSettings(); 
                OnPropertyChanged(); 
            } 
        }

        /// <summary>
        /// Событие изменения значения Progressbara.
        /// </summary>
        private void ChangedProgressBar(int t)
        {
            CurrentProgress = t;
        }

        /// <summary>
        /// Событие после завершения загрузки АПР.
        /// </summary>
        private void ActionAfterLoadingApr()
        {
            if (!isWeUseConsole)
            {
                MessageBox.Show("Загрузка АПР успешно завершена.");
            }
            CurrentProgress = 0;
        }

        /// <summary>
        /// Событие сбоя загрузки АПР.
        /// </summary>
        private void ActionAfterFalseLoadingApr()
        {
            if (!isWeUseConsole)
            {
                MessageBox.Show("Загрузка АПР не произошла.");
                CurrentProgress = 0;
            }
            else
            {
                CurrentProgress = -1;
            }
        }

        /// <summary>
        /// Инициализация объекта, инкапсулирующего CRUD запросы.
        /// </summary>
        private void InitializeCrud()
        {
            aprDbCrud = new AprDbCrud();
        }

        /// <summary>
        /// Удалить сопоставления рабочего места технике.
        /// </summary>
        /// <param name="id">Номер сопоставления в списке всех сопоставлений.</param>
        public void DeleteWorkStation(int id)
        {
            try
            {
                SaveBackground = Brushes.LightSalmon;
                WorkStationsVM.RemoveAt(id);
                if (WorkStationsVM.Count == 0) Id = 0;
                else
                {
                    int newId = 0;
                    foreach (var i in WorkStationsVM)
                    {
                        i.Id = newId;
                        newId++;
                    }
                    Id = newId;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка при удалении сопоставления. {exc.Message}");
            }
        }

        /// <summary>
        /// Изменить цвет кнопки сохранения при изменении элемента.
        /// </summary>
        public void ChangedElement()
        {
            SaveBackground = Brushes.LightSalmon;
        }

        /// <summary>
        /// Переменная, которая хранит айдишник следующего юзер контрола, который будет добавлен.
        /// </summary>
        private int Id = 0;

        /// <summary>
        /// Загрузить АПР-файл в базу данных.
        /// </summary>
        public ICommand LoadApr
        {
            get
            {
                if (loadApr == null)
                {
                    loadApr = new RelayCommand(
                        param =>
                        {
                            try
                            {
                                //Запуск апдейта таблиц
                                Thread threadForLoading = new Thread(new ThreadStart(() => { LoadingApr(); }));
                                threadForLoading.Priority = ThreadPriority.Highest;
                                threadForLoading.Start();                            
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show($"Не удалось загрузить файлы. {exc.Message}");
                            }
                        }
                    );
                }
                return loadApr;
            }
        }

        /// <summary>
        /// Загрузить выбранную конфигурацию в базу данных.
        /// </summary>
        public void LoadingApr()
        {
            try
            {
                int iteration = 0;
                CurrentProgress = 5;
                DbUpdateFeedbackEvent?.Invoke(CurrentProgress);

                var dbhw = new EPO_hardwareContext();
                foreach (XmlNode supplyOptions in AprSettings.ChildNodes)
                {
                    XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                    if (supplyOptionsName.Value == SupplyOptionSelectedItem)
                    {
                        foreach (XmlNode workSpace in supplyOptions.ChildNodes)
                        {

                            int DetectorIndex;
                            int WorkstationIndex;
                            int SoftwareIndex;

                            using (var db = new APRContext())
                            {
                                DetectorIndex = dbhw.HardwareDetectors.First(a => a.UniqueName == workSpace.Attributes.GetNamedItem("detector").Value).DetectorType;
                                WorkstationIndex = db.LogicalWorkstations.First(a => a.ToolTip == workSpace.Attributes.GetNamedItem("name").Value).Id;
                                string softInnerTypeName = supplyOptions.Attributes.GetNamedItem("name").Value;
                                string[] softName = softInnerTypeName.Split(':');
                                SoftwareIndex = db.SoftwareInnerTypes.First(a => a.Comment == softName[0]).Id;
                            }

                            foreach (XmlNode list in workSpace.ChildNodes)
                            {
                                iteration++;
                                UpdateShootingParamSet(list.Attributes.GetNamedItem("technique").Value);

                                aprDbCrud.UpdateDB(DetectorIndex, WorkstationIndex, GetListIndex(list.Attributes.GetNamedItem("name").Value), SoftwareIndex, excelLoader, shootingParamSet);

                                CurrentProgress = iteration == supplyOptions.ChildNodes.Count * workSpace.ChildNodes.Count ? 100 : (100 / (supplyOptions.ChildNodes.Count * workSpace.ChildNodes.Count) + CurrentProgress);
                                DbUpdateFeedbackEvent?.Invoke(CurrentProgress);
                            }
                        }
                    }
                }
                Thread.Sleep(1000);
                IsCreateNewEnabled = true;
                DbUpdateRowEndEvent?.Invoke();
            }
            catch (Exception exc)
            {
                DbUpdateFalseEvent?.Invoke();
            }
        }

        public bool isWeUseConsole = false;

        /// <summary>
        /// Получить индекс листа в соответствии с порядком в таблице excel.
        /// </summary>
        private int GetListIndex(string name)
        {
            for (int i = 0; i < TechniqueData.WorkStations.Count; i++)
            {
                if (name == TechniqueData.WorkStations[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Обновить значения в зависимости от выбранной техники.
        /// </summary>
        private void UpdateShootingParamSet(string technique)
        {
            bool isGraphyShootingChecked  = technique == "Графия"          ? true : false;
            bool isSerialGraphyChecked    = technique == "СерийнаяГрафия" ? true : false;
            bool isScopyShootingChecked   = technique == "Скопия"          ? true : false;
            bool isScopyHdShootingChecked = technique == "СкопияHD"        ? true : false;
            bool isTomoSyntChecked        = technique == "Томосинтез"      ? true : false;
            bool isTomoChecked            = technique == "Томография"      ? true : false;

            if (isTomoSyntChecked)
                isTomoChecked = true;

            if (isTomoChecked)
                isGraphyShootingChecked = true;

            shootingParamSet.Update(isGraphyShootingChecked,
               isSerialGraphyChecked,
               isScopyShootingChecked,
               isScopyHdShootingChecked,
               isTomoSyntChecked,
               isTomoChecked);
        }

        /// <summary>
        /// Добавить новое сопоставление рабочих мест техникам.
        /// </summary>
        public ICommand AddNewWorkStation
        {
            get
            {
                if (addNewWorkStation == null)
                {
                    addNewWorkStation = new RelayCommand(
                        param =>
                        {
                            SaveBackground = Brushes.LightSalmon;
                            // Если рабочее место было без сопоставлений, то добавляем его в хмл файл.
                            if (WorkStationsVM.Count == 0)
                            {
                                foreach (XmlNode supplyOptions in AprSettings.ChildNodes)
                                {
                                    XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                                    if (supplyOptionsName.Value == SupplyOptionSelectedItem)
                                    {
                                        XmlAttribute nameAttr = doc.CreateAttribute("name");
                                        XmlText nameText = doc.CreateTextNode(WorkSpaceSelectedItem);
                                        nameAttr.AppendChild(nameText);
                                        XmlElement workSpace = doc.CreateElement("WorkSpace");
                                        workSpace.Attributes.Append(nameAttr);
                                        supplyOptions.AppendChild(workSpace);
                                    }
                                }
                                doc.Save("AutoLoadingSettings.xml");
                            }

                            WorkStationsVM.Add(new WorkStationsViewModel(Id));
                            WorkStationsVM[WorkStationsVM.Count - 1].changedElement = ChangedElement;
                            WorkStationsVM[WorkStationsVM.Count - 1].deleteElement  = DeleteWorkStation;
                            Id++;
                        });
                }
                return addNewWorkStation;
            }
        }

        /// <summary>
        /// Найти подходящий excel-файл.
        /// </summary>
        public ICommand FindFileEx
        {
            get
            {
                if (findFile == null)
                {
                    findFile = new RelayCommand(
                        param =>
                        {
                            WorkStationsVM.Clear();
                            FindFileExcel();
                            IsCreateNewEnabled = true;
                        });
                }
                return findFile;
            }
        }

        /// <summary>
        /// Сохранить итоговую конфигурацию.
        /// </summary>
        public ICommand SaveAllConfiguration
        {
            get
            {
                if (saveAllConfiguration == null)
                {
                    saveAllConfiguration = new RelayCommand(
                        param =>
                        {
                            if (isWeWantCreateANewConfig) //Если создается новая конфигурация.
                            {
                                IsWorkSpaceItemsEnabled = false;
                                SupplyOptionItemSource.Add($"{SoftwareSelectedItem}: {ConfigurationName}");

                                //Добавляем название новой конфигурации в хмл.
                                XmlAttribute nameAttr = doc.CreateAttribute("name");
                                XmlText nameText = doc.CreateTextNode($"{SoftwareSelectedItem}: {ConfigurationName}");
                                nameAttr.AppendChild(nameText);
                                XmlElement list = doc.CreateElement("SupplyOption");
                                list.Attributes.Append(nameAttr);

                                XmlElement aprLoaderSettings = doc.DocumentElement;
                                foreach (XmlElement aprSettings in aprLoaderSettings)
                                {
                                    XmlNode? aprSettingsName = aprSettings.Attributes.GetNamedItem("name");
                                    if (aprSettingsName.Value == fileName)
                                    {
                                        AprSettings = aprSettings;
                                        AprSettings.AppendChild(list);
                                        doc.Save("AutoLoadingSettings.xml");
                                    }
                                }
                                
                                isWeWantCreateANewConfig = false;
                                IsSaveAllEnabled = false;
                                IsSaveEnabled = false;
                                IsSoftwareVisible = false;
                                IsEditEnabled = true;
                                SoftwareItemSource.Clear();
                                ConfigurationName = String.Empty;
                            }
                            else //Если сохраняется отредактированная старая конфигурация.
                            {
                                IsSaveEnabled = false;
                                isWeEditing = false;
                                IsLoadEnabled = true;
                                WorkSpaceEnabled = false;
                                IsDetectorItemsEnabled = false;
                                WorkSpaceBorderBrush = Brushes.Green;
                                IsSaveAllEnabled = false;
                            }
                        });
                }
                return saveAllConfiguration;
            }
        }

        /// <summary>
        /// Редактировать конфигурацию.
        /// </summary>
        public ICommand EditWorkSpace
        {
            get
            {
                if (editWorkSpace == null)
                {
                    editWorkSpace = new RelayCommand(
                        param =>
                        {
                            isWeEditing            = true;
                            IsSaveEnabled          = true;
                            IsSaveAllEnabled       = true;
                            IsLoadEnabled          = false;
                            WorkSpaceEnabled       = true;
                            IsDetectorItemsEnabled = true;

                            WorkSpaceBorderBrush = Brushes.Salmon;
                            workSpaceItemSource = GetWorkSpaceExcelItemSource();
                            WorkSpaceItemSource = workSpaceItemSource;
                            WorkSpaceSelectedIndex = 0;
                        });
                }
                return editWorkSpace;
            }
        }

        /// <summary>
        /// Сохранить конфигурацию.
        /// </summary>
        public ICommand SaveConfiguration
        {
            get
            {
                if (saveConfiguration == null)
                {
                    saveConfiguration = new RelayCommand(
                        param =>
                        {
                            //Сохраняем сопоставления для выбранного рабочего места.
                            foreach (XmlNode supplyOptions in AprSettings.ChildNodes)
                            {
                                XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                                if (supplyOptionsName.Value == SupplyOptionSelectedItem)
                                {
                                    foreach (XmlNode workSpace in supplyOptions.ChildNodes)
                                    {
                                        XmlNode? workSpaceName = workSpace.Attributes.GetNamedItem("name");
                                        if (workSpaceName.Value == WorkSpaceSelectedItem)
                                        {
                                            //Если у рабочего места нету сопоставлений, то необходимо удалить это рабочее место из хмл.
                                            if (WorkStationsVM.Count == 0)
                                            {
                                                supplyOptions.RemoveChild(workSpace);
                                            }
                                            else
                                            {
                                                workSpace.RemoveAll();

                                                //Добавление рабочего места и соответсвующего детектора.
                                                XmlAttribute nameAttr = doc.CreateAttribute("name");
                                                XmlAttribute detectorAttr = doc.CreateAttribute("detector");
                                                XmlText nameText = doc.CreateTextNode(WorkSpaceSelectedItem);
                                                XmlText detectorText = doc.CreateTextNode(DetectorSelectedItem);
                                                nameAttr.AppendChild(nameText);
                                                detectorAttr.AppendChild(detectorText);
                                                workSpace.Attributes.Append(nameAttr);
                                                workSpace.Attributes.Append(detectorAttr);

                                                doc.Save("AutoLoadingSettings.xml");

                                                //Добавление сопоставленния рабочей техники и листа.
                                                foreach (var i in WorkStationsVM)
                                                {
                                                    nameAttr = doc.CreateAttribute("name");
                                                    XmlAttribute techniqueAttr = doc.CreateAttribute("technique");
                                                    nameText = doc.CreateTextNode(i.WorkStationSelectedItem);
                                                    XmlText techniqueText = doc.CreateTextNode(i.TechniqueSelectedItem.ToString());
                                                    nameAttr.AppendChild(nameText);
                                                    techniqueAttr.AppendChild(techniqueText);
                                                    XmlElement list = doc.CreateElement("List");
                                                    list.Attributes.Append(nameAttr);
                                                    list.Attributes.Append(techniqueAttr);
                                                    workSpace.AppendChild(list);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            SaveBackground = Brushes.White;
                            doc.Save("AutoLoadingSettings.xml");                     
                        });
                }
                return saveConfiguration;
            }
        }

        /// <summary>
        /// Удалить выбранную конфигурацию.
        /// </summary>
        public ICommand DeleteConfiguration
        {
            get
            {
                if (deleteConfiguration == null)
                {
                    deleteConfiguration = new RelayCommand(
                        param =>
                        {
                            var result = MessageBox.Show( "Вы уверены, что хотите удалить выбранную конфигурацию?", "Подтверждение",MessageBoxButton.YesNo);
                            if (result == MessageBoxResult.Yes)
                            {
                                foreach (XmlNode supplyOptions in AprSettings.ChildNodes)
                                {
                                    XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                                    if (supplyOptionsName.Value == SupplyOptionSelectedItem)
                                    {
                                        AprSettings.RemoveChild(supplyOptions);
                                        doc.Save("AutoLoadingSettings.xml");
                                        SupplyOptionItemSource.Remove(SupplyOptionSelectedItem);
                                        continue;
                                    }
                                }                              
                            }
                        });
                }
                return deleteConfiguration;
            }
        }

        /// <summary>
        /// Создать новую конфигурацию.
        /// </summary>
        public ICommand CreateNewConfiguration
        {
            get
            {
                if (сreateNewConfiguration == null)
                {
                    сreateNewConfiguration = new RelayCommand(
                        param =>
                        {
                            if (!isConfigFound)
                            {
                                XmlAttribute nameAttr = doc.CreateAttribute("name");
                                XmlText nameText = doc.CreateTextNode(fileName);
                                nameAttr.AppendChild(nameText);

                                XmlNode root = doc.DocumentElement;

                                XmlElement list = doc.CreateElement("AprSettings");
                                list.Attributes.Append(nameAttr);
                                root.AppendChild(list);
                                doc.Save("AutoLoadingSettings.xml");
                                isConfigFound = true;
                            }

                            IsSaveAllEnabled           = true;
                            IsSoftwareVisible          = true;
                            WorkSpaceEnabled           = false;
                            ConfigurationNameIsEnabled = true;
                            isWeWantCreateANewConfig   = true;

                            WorkSpaceBorderBrush = Brushes.Salmon;
                            ConfigurationName    = "Введите описание новой конфигурации...";

                            workStationsVM.Clear();
                            WorkStationsVM = workStationsVM;
                            WorkSpaceItemSource = new ObservableCollection<string>();
                            SupplyOption = null;

                            using (var db = new APRContext())
                            {
                                var softwareTypes = db.SoftwareInnerTypes.Select(a => a.Comment);
                                foreach (var i in softwareTypes)
                                {
                                    softwareItemSource.Add(i);
                                }
                                SoftwareItemSource    = softwareItemSource;
                                SoftwareSelectedIndex = 0;
                            }
                        });
                }
                return сreateNewConfiguration;
            }
        }

        private string fileName;

        /// <summary>
        /// Загрузить файл excel.
        /// </summary>
        public void FindFileExcel()
        {
            try
            {
                fileName = String.Empty;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel 2017 (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                dialog.DefaultExt = "xlsx";
                if (dialog.ShowDialog() == true)
                {
                    excelLoader = new ExcelLoader(dialog.FileName);
                    loadFilePath = dialog.FileName;
                    AprTextUpdate = loadFilePath;
                    var splitFileName = dialog.FileName.Split('\\');
                    fileName = splitFileName[splitFileName.Length - 1].Split('.')[0];
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать файл с АПРами");
                    return;
                }

                loadedList.Clear();
                for (int i = 0; i < excelLoader.DataSet.Tables.Count; i++)
                {
                    loadedList.Add(excelLoader.DataSet.Tables[i].TableName);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                }
                TechniqueData.WorkStations = loadedList;

                MessageAfterLoading = FindConfiguration(fileName) ? $"Найдены конфигурации для детектора {fileName}" : "Для данного детектора конфигурации не найдены";
            }
            catch (Exception exс)
            {
                MessageBox.Show($"При загрузке файла возникла ошибка. {exс.Message}");
            }
        }

        private bool isConfigFound;

        /// <summary>
        /// Получить рабочие места из базы данных.
        /// </summary>
        public ObservableCollection<string> GetWorkSpaceExcelItemSource()
        {
            ObservableCollection<string> workstationList = new ObservableCollection<string>();
            var logicalWorkstations = aprDbCrud.GetLogicalWorkstations();
            foreach (var w in logicalWorkstations)
                workstationList.Add(w.ToolTip);
            return workstationList;
        }

        /// <summary>
        /// Поиск конфигураций по названию файла Excel.
        /// </summary>
        public bool FindConfiguration(string fileName)
        {
            isConfigFound = false;
            SupplyOptionItemSource.Clear();
            supplyOptionItemSource.Clear();
            doc = new XmlDocument();
            doc.Load("AutoLoadingSettings.xml");

            XmlElement aprLoaderSettings = doc.DocumentElement;
            foreach (XmlElement aprSettings in aprLoaderSettings)
            {
                XmlNode? aprSettingsName = aprSettings.Attributes.GetNamedItem("name");
                if (aprSettingsName != null && aprSettingsName.Value == fileName)
                {
                    AprSettings = aprSettings;
                    isConfigFound = true;
                    foreach (XmlNode supplyOptions in aprSettings.ChildNodes)
                    {
                        XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                        supplyOptionItemSource.Add(supplyOptionsName.Value);
                    }
                }
                SupplyOptionItemSource = supplyOptionItemSource;                
            }
            return isConfigFound ? true : false;
        }

        /// <summary>
        /// Отображение возможных рабочих мест и детектора для выбранной конфигурации.
        /// </summary>
        public void ShowConfigSettings()
        {
            try
            {
                ConfigurationName = SupplyOptionSelectedItem;
                workSpaceItemSource.Clear();
                detectorItemSource.Clear();
                foreach (XmlNode supplyOptions in AprSettings.ChildNodes)
                {
                    XmlNode? supplyOptionsName = supplyOptions.Attributes.GetNamedItem("name");
                    if (supplyOptionsName.Value == SupplyOptionSelectedItem)
                    {
                        SupplyOption = supplyOptions;
                        foreach (XmlNode workSpace in supplyOptions.ChildNodes)
                        {
                            XmlNode? workSpaceName = workSpace.Attributes.GetNamedItem("name");
                            workSpaceItemSource.Add(workSpaceName.Value);
                        }
                        WorkSpaceItemSource = workSpaceItemSource;
                        WorkSpaceSelectedIndex = 0;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"При загрузке настроек конфигурации возникла ошибка. {exc.Message}");
            }
        }

        /// <summary>
        /// Отображение сопоставлений рабочих мест техникам.
        /// </summary>
        public void ShowLists()
        {
            Id = 0;
            if (WorkStationsVM.Count != 0)
            {
                WorkStationsVM.Clear();
            }
            if (SupplyOption != null)
            {
                foreach (XmlNode workSpace in SupplyOption.ChildNodes)
                {
                    XmlNode? workSpaceName = workSpace.Attributes.GetNamedItem("name");
                    if (workSpaceName.Value == WorkSpaceSelectedItem)
                    {
                        foreach (XmlNode list in workSpace.ChildNodes)
                        {
                            WorkStationsVM.Add(new WorkStationsViewModel(Id));
                            WorkStationsVM[WorkStationsVM.Count - 1].changedElement = ChangedElement;
                            string listName = list.Attributes.GetNamedItem("name").Value;
                            string listTechnique = list.Attributes.GetNamedItem("technique").Value;
                            WorkStationsVM[WorkStationsVM.Count - 1].WorkStationSelectedItem = listName;
                            WorkStationsVM[WorkStationsVM.Count - 1].TechniqueSelectedItem = (TechniqueEnum)Enum.Parse(typeof(TechniqueEnum), listTechnique);
                            WorkStationsVM[WorkStationsVM.Count - 1].deleteElement = DeleteWorkStation;
                            Id++;
                        }
                    }
                }
            }            
        }

        /// <summary>
        /// Состаяние работы программы: находимся ли мы в режиме редактирования конфигурации?
        /// </summary>
        private bool isWeEditing = false;

        /// <summary>
        /// Получение детекторов в зависимости от выбранного рабочего места.
        /// </summary>
        public void ShowDetectorsItems()
        {
            if (isWeEditing) //Если мы находимся в режиме редактирования конфигурации.
            {
                string detectorName = String.Empty;
                detectorItemSource.Clear();
                ObservableCollection<string> detectors = new ObservableCollection<string>();
                var ws = aprDbCrud.GetLogicalWorkstationByToolTip(WorkSpaceSelectedItem);
                foreach (var r in aprDbCrud.GetDetectorWorkstationsById(ws.Id))
                    detectors.Add(aprDbCrud.GetHardwareDetectorUniqueNameById(r.DetectorId));

                DetectorItemSource = detectors;
                DetectorSelectedIndex = 0;
                foreach (XmlNode workSpace in SupplyOption.ChildNodes)
                {
                    if (workSpace.Attributes.GetNamedItem("name").Value == WorkSpaceSelectedItem)
                    {
                        detectorName = workSpace.Attributes.GetNamedItem("detector").Value;
                    }
                }

                foreach (var detector in DetectorItemSource)
                {       
                    if (detector == detectorName)
                    {
                        DetectorSelectedItem = detectorName;
                    }
                }
            }
            else
            {
                detectorItemSource.Clear();
                foreach (XmlNode workSpace in SupplyOption.ChildNodes)
                {
                    if (workSpace.Attributes.GetNamedItem("name").Value == WorkSpaceSelectedItem)
                    {
                        XmlNode? detectorName = workSpace.Attributes.GetNamedItem("detector");
                        detectorItemSource.Add(detectorName.Value);
                        DetectorItemSource = detectorItemSource;
                        DetectorSelectedIndex = 0;
                    }
                }
            }
        }
    }
}
