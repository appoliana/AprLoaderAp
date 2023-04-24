using AprLoaderNew.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace AprLoaderNew
{
    public class MainViewModel : OnPropertyChangedClass
    {
        private Model _model;
        private ObservableCollection<string> _logger;
        private List<string> _loadedList;
        private List<string> _workstationList;
        private List<string> _detectorList;
        private List<string> _sortwareList;
        private int _listSelectedIndex = 0;
        private int _workstationListSelectedIndex = 0;
        private int _detectorListSelectedIndex = 0;
        private int _softwareListSelectedIndex = 0;
        private bool _stateOfUI = true;
        private bool _isNeededClearDb = false;
        private string _loadFilePath = string.Empty;
        private string _workStationText = string.Empty;
        private string _softwareText = string.Empty;
        private string _detectorText = string.Empty;
        private string _workStationListSelectedItem = string.Empty;
        private string _softwareListSelectedItem = string.Empty;
        private string _detectorListSelectedItem = string.Empty;
        private SolidColorBrush _borderColor = Brushes.Gray;
        private Brush _scopyBackground = Brushes.Gray;
        private Brush _tomoBackground = Brushes.Gray;
        private Brush _serialGraphyBackground = Brushes.Gray;
        private Brush _aecBackground = Brushes.Gray;

        public MainViewModel()
        {
            _model = new Model();
            _model.PropertyChanged += Model_PropertyChanged;
            _loadedList = new List<string>();
            _model.InitializeComboCollections();
        }

        public string WorkStationListSelectedItem
        {
            get => _model == null ? _workStationListSelectedItem : _model.WorkStationListSelectedItem;
            set { _model.WorkStationListSelectedItem = value ; OnPropertyChanged(); }
        }

        public string DetectorListSelectedItem
        {
            get => _model == null ? _detectorListSelectedItem : _model.DetectorListSelectedItem;
            set { _model.DetectorListSelectedItem = value; OnPropertyChanged(); }
        }

        public string SoftwareListSelectedItem
        {
            get => _model == null ? _softwareListSelectedItem : _model.SoftwareListSelectedItem;
            set { _model.SoftwareListSelectedItem = value; OnPropertyChanged(); }
        }

        public List<string> WorkstationList
        {
            get => _model == null ? _workstationList : _model.WorkstationList;
            set { _model.WorkstationList = value; OnPropertyChanged(); }
        }

        public int WorkstationListSelectedIndex
        {
            get => _model == null ? _workstationListSelectedIndex : _model.WorkstationListSelectedIndex;
            set { _model.WorkstationListSelectedIndex = value; OnPropertyChanged(); }
        }

        public List<string> DetectorList
        {
            get => _model == null ? _detectorList : _model.DetectorList;
            set { _model.DetectorList = value; OnPropertyChanged(); }
        }

        public int DetectorListSelectedIndex
        {
            get => _model == null ? _detectorListSelectedIndex : _model.DetectorListSelectedIndex;
            set { _model.DetectorListSelectedIndex = value; OnPropertyChanged(); }
        }

        public List<string> SoftwareList
        {
            get => _model == null ? _sortwareList : _model.SoftwareList;
            set { _model.SoftwareList = value; OnPropertyChanged(); }
        }

        public int SoftwareListSelectedIndex
        {
            get => _model == null ? _softwareListSelectedIndex : _model.SoftwareListSelectedIndex;
            set { _model.SoftwareListSelectedIndex = value; OnPropertyChanged(); }
        }

        public string AprTextUpdate
        {
            get => _model == null ? _loadFilePath : _model.AprTextUpdate;
            set { _model.AprTextUpdate = value; OnPropertyChanged(); }
        }

        public bool ChangeStateOfUI
        {
            get => _model == null ? _stateOfUI : _model.ChangeStateOfUI;
            set { _model.ChangeStateOfUI = value; OnPropertyChanged(); }
        }

        public List<string> LoadedList
        {
            get => _model == null ? _loadedList : _model.LoadedList;
            set { _model.LoadedList = value; OnPropertyChanged(); }
        }

        public int ListSelectedIndex
        {
            get => _model == null ? _listSelectedIndex : _model.ListSelectedIndex;
            set { _model.ListSelectedIndex = value; OnPropertyChanged(); }
        }

        public bool IsNeededClearDb
        {
            get => _model == null ? _isNeededClearDb : _model.IsNeededClearDb;
            set { _model.IsNeededClearDb = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> Logger
        {
            get => _model == null ? _logger : _model.Logger;
            set { _model.Logger = value; OnPropertyChanged(); }
        }

        public SolidColorBrush AprPathTextBoxBorderColor
        {
            get => _model == null ? _borderColor : _model.AprPathTextBoxBorderColor;
            set { _model.AprPathTextBoxBorderColor = value; OnPropertyChanged(); }
        }

        public Brush ScopyBackground
        {
            get => _model == null ? _scopyBackground : _model.ScopyBackground;
            set { _model.ScopyBackground = value; OnPropertyChanged(); }
        }

        public Brush TomoBackground
        {
            get => _model == null ? _tomoBackground : _model.TomoBackground;
            set { _model.TomoBackground = value; OnPropertyChanged(); }
        }

        public Brush SerialGraphyBackground
        {
            get => _model == null ? _serialGraphyBackground : _model.SerialGraphyBackground;
            set { _model.SerialGraphyBackground = value; OnPropertyChanged(); }
        }

        public Brush AecBackground
        {
            get => _model == null ? _aecBackground : _model.AecBackground;
            set { _model.AecBackground = value; OnPropertyChanged(); }
        }

        public bool IsTomoChecked
        {
            get => _model == null ? false : _model.IsTomoChecked;
            set { _model.IsTomoChecked = value; OnPropertyChanged(); }
        }

        public bool IsGraphyShootingChecked
        {
            get => _model == null ? true : _model.IsGraphyShootingChecked;
            set { _model.IsGraphyShootingChecked = value; OnPropertyChanged(); }
        }

        public bool IsSerialGraphyChecked
        {
            get => _model == null ? false : _model.IsSerialGraphyChecked;
            set { _model.IsSerialGraphyChecked = value; OnPropertyChanged(); }
        }

        public bool IsScopyShootingChecked
        {
            get => _model == null ? false : _model.IsScopyShootingChecked;
            set { _model.IsScopyShootingChecked = value; OnPropertyChanged(); }
        }

        public bool IsScopyHdShootingChecked
        {
            get => _model == null ? false : _model.IsScopyHdShootingChecked;
            set { _model.IsScopyHdShootingChecked = value; OnPropertyChanged(); }
        }

        public bool IsTomoSyntChecked
        {
            get => _model == null ? false : _model.IsTomoSyntChecked;
            set { _model.IsTomoSyntChecked = value; OnPropertyChanged(); }
        }

        private ICommand? _findFile;
        private ICommand? _cleanUpWorkSpace;
        private ICommand? _removeTechnique;
        private ICommand? _cleanUpWgd;
        private ICommand? _setApr;

        public ICommand FindFile
        {
            get
            {
                if (_findFile == null)
                {
                    _findFile = new RelayCommand(
                        param =>
                        {
                            FindFileModel();
                        });
                }
                return _findFile;
            }
        }

        public ICommand CleanUpWorkspace
        {
            get
            {
                if (_cleanUpWorkSpace == null)
                {
                    _cleanUpWorkSpace = new RelayCommand(
                        param =>
                        {
                            CleanUpWorkspaceModel();
                        });
                }
                return _cleanUpWorkSpace;
            }
        }

        public ICommand RemoveTechnique
        {
            get
            {
                if (_removeTechnique == null)
                {
                    _removeTechnique = new RelayCommand(
                        param =>
                        {
                            RemoveTechniqueModel();
                        });
                }
                return _removeTechnique;
            }
        }

        public ICommand CleanUpWgd
        {
            get
            {
                if (_cleanUpWgd == null)
                {
                    _cleanUpWgd = new RelayCommand(
                        param =>
                        {
                            CleanUpWgdModel();
                        });
                }
                return _cleanUpWgd;
            }
        }

        public ICommand SetApr
        {
            get
            {
                if (_setApr == null)
                {
                    _setApr = new RelayCommand(
                        param =>
                        {
                            SetAprModel();
                        });
                }
                return _setApr;
            }
        }

        private void FindFileModel()         => _model.FindFile();
        private void CleanUpWorkspaceModel() => _model.CleanUpWorkspace();
        private void RemoveTechniqueModel()  => _model.RemoveTechnique();
        private void CleanUpWgdModel()       => _model.CleanUpWgd();
        private void SetAprModel()           => _model.LoadApr();

        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                OnPropertyChanged(e.PropertyName);
            }), null);
        }
    }
}
