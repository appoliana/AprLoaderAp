using AprLoaderNew.APR;
using AprLoaderNew.EPO_Hardware;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace AprLoaderNew.ViewModel
{
    public class DetectorViewModel : OnPropertyChangedClass
    {
        public DetectorViewModel()
        {
            _model = new DetectorModel();
            _model.PropertyChanged += Model_PropertyChanged;
        }

        private DetectorModel _model;
        private string _detectorTypeIdText = string.Empty;
        private string _detectorTypeIdNum = string.Empty;
        private string _detectorTypeIdName = string.Empty;
        private string _resultTextBlockText = string.Empty;
        private Brush _resultTextBlockColor = Brushes.Gray;
        private object _detectorTypesListViewSelectedItem;
        private List<DetectorType> _detectorTypesListViewItemSource = new();

        private string _hardwareDetectorIdText = string.Empty;
        private string _hardwareDetectorNameText = string.Empty;
        private string _hardwareDetectorTlsFilePathText = string.Empty;
        private string _hardwareDetectorPreProcessingTlsKeyText = string.Empty;
        private bool _hardwareDetectorIsUseText = false;
        private string _hardwareDetectorDetectorTypeText = string.Empty;
        private string _tableUpdateLogText = "Здесь расположена детализация и результаты операций";
        private string _hardwareDetectorUniqueNameText = string.Empty;
        private string _hardwareDetectorImagePixelSpacingText = string.Empty;
        private string _hardwareDetectorCalibratedImageSizeText = string.Empty;
        private string _hardwareDetectorAprVersion = string.Empty;
        private object _hardwareDetectorListViewSelectedItem;
        private List<HardwareDetector> _hardwareDetectorListViewItemSource = new();

        private string _detectorWorkstationIdText = string.Empty;
        private string _detectorWorkstationLogicalWorkstationIdText = string.Empty;
        private string _detectorWorkstationDetectorIdText = string.Empty;
        private object _detectorWorkstationsListViewSelectedItem;
        private List<DetectorWorkstation> _detectorWorkstationsListViewItemSource = new();

        private string _logicalWorkstationIdText = string.Empty;
        private string _logicalWorkstationWorkstationIdText = string.Empty;
        private bool _logicalWorkstationIsTomo = false;
        private bool _logicalWorkstationIsScopy = false;
        private bool _logicalWorkstationIsSerialGraphy = false;
        private bool _logicalWorkstationIsFilm = false;
        private bool _logicalWorkstationIsAecEnabled = false;
        private string _logicalWorkstationUniqueNameText = string.Empty;
        private string _logicalWorkstationToolTipText = string.Empty;
        private bool _logicalWorkstationIsVisible = false;
        private string _logicalWorkstationUniqueIdText = string.Empty;
        private bool _logicalWorkstationIsRaster = false;
        private string _logicalWorkstationDosimeterIdText = string.Empty;
        private object _logicalWorkstationsListViewSelectedItem;
        private List<LogicalWorkstation> _logicalWorkstationsListViewItemSource = new();

        private string _generatorWorkstationIdText = string.Empty;
        private string _generatorWorkstationNameText = string.Empty;
        private string _generatorWorkstationGenParValText = string.Empty;
        private bool _generatorWorkstationIsActive = false;
        private bool _generatorWorkstationIsAecEnabled = false;
        private object _generatorWorkStationsListViewSelectedItem;
        private List<GeneratorWorkStation> _generatorWorkStationsListViewItemSource = new();

        public string DetectorTypeIdText
        {
            get => _model == null ? _detectorTypeIdText : _model.DetectorTypeIdText;
            set { _model.DetectorTypeIdText = value; OnPropertyChanged(); }
        }

        public string DetectorTypeIdNum
        {
            get => _model == null ? _detectorTypeIdNum : _model.DetectorTypeIdNum;
            set { _model.DetectorTypeIdNum = value; OnPropertyChanged(); }
        }

        public string DetectorTypeIdName
        {
            get => _model == null ? _detectorTypeIdName : _model.DetectorTypeIdName;
            set { _model.DetectorTypeIdName = value; OnPropertyChanged(); }
        }

        public string TableUpdateLogText
        {
            get => _model == null ? _tableUpdateLogText : _model.TableUpdateLogText;
            set { _model.TableUpdateLogText = value; OnPropertyChanged(); }
        }

        public string ResultTextBlockText
        {
            get => _model == null ? _resultTextBlockText : _model.ResultTextBlockText;
            set { _model.ResultTextBlockText = value; OnPropertyChanged(); }
        }

        public Brush ResultTextBlockColor
        {
            get => _model == null ? _resultTextBlockColor : _model.ResultTextBlockColor;
            set { _model.ResultTextBlockColor = value; OnPropertyChanged(); }
        }

        public object DetectorTypesListViewSelectedItem
        {
            get => _model == null ? _detectorTypesListViewSelectedItem : _model.DetectorTypesListViewSelectedItem;
            set { _model.DetectorTypesListViewSelectedItem = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorIdText
        {
            get => _model == null ? _hardwareDetectorIdText : _model.HardwareDetectorIdText;
            set { _model.HardwareDetectorIdText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorNameText
        {
            get => _model == null ? _hardwareDetectorNameText : _model.HardwareDetectorNameText;
            set { _model.HardwareDetectorNameText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorTlsFilePathText
        {
            get => _model == null ? _hardwareDetectorTlsFilePathText : _model.HardwareDetectorTlsFilePathText;
            set { _model.HardwareDetectorTlsFilePathText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorPreProcessingTlsKeyText
        {
            get => _model == null ? _hardwareDetectorPreProcessingTlsKeyText : _model.HardwareDetectorPreProcessingTlsKeyText;
            set { _model.HardwareDetectorPreProcessingTlsKeyText = value; OnPropertyChanged(); }
        }

        public bool HardwareDetectorIsUseText
        {
            get => _model == null ? _hardwareDetectorIsUseText : _model.HardwareDetectorIsUseText;
            set { _model.HardwareDetectorIsUseText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorDetectorTypeText
        {
            get => _model == null ? _hardwareDetectorDetectorTypeText : _model.HardwareDetectorDetectorTypeText;
            set { _model.HardwareDetectorDetectorTypeText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorUniqueNameText
        {
            get => _model == null ? _hardwareDetectorUniqueNameText : _model.HardwareDetectorUniqueNameText;
            set { _model.HardwareDetectorUniqueNameText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorImagePixelSpacingText
        {
            get => _model == null ? _hardwareDetectorImagePixelSpacingText : _model.HardwareDetectorImagePixelSpacingText;
            set { _model.HardwareDetectorImagePixelSpacingText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorCalibratedImageSizeText
        {
            get => _model == null ? _hardwareDetectorCalibratedImageSizeText : _model.HardwareDetectorCalibratedImageSizeText;
            set { _model.HardwareDetectorCalibratedImageSizeText = value; OnPropertyChanged(); }
        }

        public string HardwareDetectorAprVersion
        {
            get => _model == null ? _hardwareDetectorAprVersion : _model.HardwareDetectorAprVersion;
            set { _model.HardwareDetectorAprVersion = value; OnPropertyChanged(); }
        }

        public object HardwareDetectorListViewSelectedItem
        {
            get => _model == null ? _hardwareDetectorListViewSelectedItem : _model.HardwareDetectorListViewSelectedItem;
            set { _model.HardwareDetectorListViewSelectedItem = value; OnPropertyChanged(); }
        }

        public object DetectorWorkstationsListViewSelectedItem
        {
            get => _model == null ? _detectorWorkstationsListViewSelectedItem : _model.DetectorWorkstationsListViewSelectedItem;
            set { _model.DetectorWorkstationsListViewSelectedItem = value; OnPropertyChanged(); }
        }

        public string DetectorWorkstationIdText
        {
            get => _model == null ? _detectorWorkstationIdText : _model.DetectorWorkstationIdText;
            set { _model.DetectorWorkstationIdText = value; OnPropertyChanged(); }
        }

        public string DetectorWorkstationLogicalWorkstationIdText
        {
            get => _model == null ? _detectorWorkstationLogicalWorkstationIdText : _model.DetectorWorkstationLogicalWorkstationIdText;
            set { _model.DetectorWorkstationLogicalWorkstationIdText = value; OnPropertyChanged(); }
        }

        public string DetectorWorkstationDetectorIdText
        {
            get => _model == null ? _detectorWorkstationDetectorIdText : _model.DetectorWorkstationDetectorIdText;
            set { _model.DetectorWorkstationDetectorIdText = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationIdText
        {
            get => _model == null ? _logicalWorkstationIdText : _model.LogicalWorkstationIdText;
            set { _model.LogicalWorkstationIdText = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationWorkstationIdText
        {
            get => _model == null ? _logicalWorkstationWorkstationIdText : _model.LogicalWorkstationWorkstationIdText;
            set { _model.LogicalWorkstationWorkstationIdText = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsTomo
        {
            get => _model == null ? _logicalWorkstationIsTomo : _model.LogicalWorkstationIsTomo;
            set { _model.LogicalWorkstationIsTomo = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsScopy
        {
            get => _model == null ? _logicalWorkstationIsScopy : _model.LogicalWorkstationIsScopy;
            set { _model.LogicalWorkstationIsScopy = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsSerialGraphy
        {
            get => _model == null ? _logicalWorkstationIsSerialGraphy : _model.LogicalWorkstationIsSerialGraphy;
            set { _model.LogicalWorkstationIsSerialGraphy = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsFilm
        {
            get => _model == null ? _logicalWorkstationIsFilm : _model.LogicalWorkstationIsFilm;
            set { _model.LogicalWorkstationIsFilm = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsAecEnabled
        {
            get => _model == null ? _logicalWorkstationIsAecEnabled : _model.LogicalWorkstationIsAecEnabled;
            set { _model.LogicalWorkstationIsAecEnabled = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationUniqueNameText
        {
            get => _model == null ? _logicalWorkstationUniqueNameText : _model.LogicalWorkstationUniqueNameText;
            set { _model.LogicalWorkstationUniqueNameText = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationToolTipText
        {
            get => _model == null ? _logicalWorkstationToolTipText : _model.LogicalWorkstationToolTipText;
            set { _model.LogicalWorkstationToolTipText = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsVisible
        {
            get => _model == null ? _logicalWorkstationIsVisible : _model.LogicalWorkstationIsVisible;
            set { _model.LogicalWorkstationIsVisible = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationUniqueIdText
        {
            get => _model == null ? _logicalWorkstationUniqueIdText : _model.LogicalWorkstationUniqueIdText;
            set { _model.LogicalWorkstationUniqueIdText = value; OnPropertyChanged(); }
        }

        public bool LogicalWorkstationIsRaster
        {
            get => _model == null ? _logicalWorkstationIsRaster : _model.LogicalWorkstationIsRaster;
            set { _model.LogicalWorkstationIsRaster = value; OnPropertyChanged(); }
        }

        public string LogicalWorkstationDosimeterIdText
        {
            get => _model == null ? _logicalWorkstationDosimeterIdText : _model.LogicalWorkstationDosimeterIdText;
            set { _model.LogicalWorkstationDosimeterIdText = value; OnPropertyChanged(); }
        }

        public object LogicalWorkstationsListViewSelectedItem
        {
            get => _model == null ? _logicalWorkstationsListViewSelectedItem : _model.LogicalWorkstationsListViewSelectedItem;
            set { _model.LogicalWorkstationsListViewSelectedItem = value; OnPropertyChanged(); }
        }

        public string GeneratorWorkstationIdText
        {
            get => _model == null ? _generatorWorkstationIdText : _model.GeneratorWorkstationIdText;
            set { _model.GeneratorWorkstationIdText = value; OnPropertyChanged(); }
        }

        public string GeneratorWorkstationNameText
        {
            get => _model == null ? _generatorWorkstationNameText : _model.GeneratorWorkstationNameText;
            set { _model.GeneratorWorkstationNameText = value; OnPropertyChanged(); }
        }

        public string GeneratorWorkstationGenParValText
        {
            get => _model == null ? _generatorWorkstationGenParValText : _model.GeneratorWorkstationGenParValText;
            set { _model.GeneratorWorkstationGenParValText = value; OnPropertyChanged(); }
        }

        public bool GeneratorWorkstationIsActive
        {
            get => _model == null ? _generatorWorkstationIsActive : _model.GeneratorWorkstationIsActive;
            set { _model.GeneratorWorkstationIsActive = value; OnPropertyChanged(); }
        }

        public bool GeneratorWorkstationIsAecEnabled
        {
            get => _model == null ? _generatorWorkstationIsAecEnabled : _model.GeneratorWorkstationIsAecEnabled;
            set { _model.GeneratorWorkstationIsAecEnabled = value; OnPropertyChanged(); }
        }

        public object GeneratorWorkStationsListViewSelectedItem
        {
            get => _model == null ? _generatorWorkStationsListViewSelectedItem : _model.GeneratorWorkStationsListViewSelectedItem;
            set { _model.GeneratorWorkStationsListViewSelectedItem = value; OnPropertyChanged(); }
        }

        public List<DetectorType> DetectorTypesListViewItemSource
        {
            get => _model == null ? _detectorTypesListViewItemSource : _model.DetectorTypesListViewItemSource;
            set { _model.DetectorTypesListViewItemSource = value; OnPropertyChanged(); }
        }

        public List<HardwareDetector> HardwareDetectorListViewItemSource
        {
            get => _model == null ? _hardwareDetectorListViewItemSource : _model.HardwareDetectorListViewItemSource;
            set { _model.HardwareDetectorListViewItemSource = value; OnPropertyChanged(); }
        }

        public List<DetectorWorkstation> DetectorWorkstationsListViewItemSource
        {
            get => _model == null ? _detectorWorkstationsListViewItemSource : _model.DetectorWorkstationsListViewItemSource;
            set { _model.DetectorWorkstationsListViewItemSource = value; OnPropertyChanged(); }
        }

        public List<LogicalWorkstation> LogicalWorkstationsListViewItemSource
        {
            get => _model == null ? _logicalWorkstationsListViewItemSource : _model.LogicalWorkstationsListViewItemSource;
            set { _model.LogicalWorkstationsListViewItemSource = value; OnPropertyChanged(); }
        }

        public List<GeneratorWorkStation> GeneratorWorkStationsListViewItemSource
        {
            get => _model == null ? _generatorWorkStationsListViewItemSource : _model.GeneratorWorkStationsListViewItemSource;
            set { _model.GeneratorWorkStationsListViewItemSource = value; OnPropertyChanged(); }
        }

        public void DetectorTypesListViewSelectionChanged() => _model.DetectorTypesListViewSelectionChanged();

        public void HardwareDetectorListViewSelectionChanged() => _model.HardwareDetectorListViewSelectionChanged();

        public void DetectorWorkstationsListViewSelectionChanged() => _model.DetectorWorkstationsListViewSelectionChanged();

        public void LogicalWorkstationsListViewSelectionChanged() => _model.LogicalWorkstationsListViewSelectionChanged();

        public void GeneratorWorkStationsListViewSelectionChanged() => _model.GeneratorWorkStationsListViewSelectionChanged();

        #region Command

        private ICommand? _addDetectorType;
        private ICommand? _removeDetectorType;
        private ICommand? _updateDetectorType;

        private ICommand? _addHardwareDetector;
        private ICommand? _removeHardwareDetector;
        private ICommand? _updateHardwareDetector;

        private ICommand? _addDetectorWorkstation;
        private ICommand? _removeDetectorWorkstation;
        private ICommand? _updateDetectorWorkstation;

        private ICommand? _addLogicalWorkstation;
        private ICommand? _removeLogicalWorkstation;
        private ICommand? _updateLogicalWorkstation;

        private ICommand? _addGeneratorWorkstation;
        private ICommand? _removeGeneratorWorkstation;
        private ICommand? _updateGeneratorWorkstation;

        private ICommand? _clearLog;
        private ICommand? _initializeCollections;

        public ICommand AddDetectorType
        {
            get
            {
                if (_addDetectorType == null)
                {
                    _addDetectorType = new RelayCommand(
                        param =>
                        {
                            _model.AddDetectorTypeAsync();
                        });
                }
                return _addDetectorType;
            }
        }

        public ICommand RemoveDetectorType
        {
            get
            {
                if (_removeDetectorType == null)
                {
                    _removeDetectorType = new RelayCommand(
                        param =>
                        {
                            _model.RemoveDetectorTypeAsync();
                        });
                }
                return _removeDetectorType;
            }
        }

        public ICommand UpdateDetectorType
        {
            get
            {
                if (_updateDetectorType == null)
                {
                    _updateDetectorType = new RelayCommand(
                        param =>
                        {
                            _model.UpdateDetectorTypeAsync();
                        });
                }
                return _updateDetectorType;
            }
        }

        public ICommand AddHardwareDetector
        {
            get
            {
                if (_addHardwareDetector == null)
                {
                    _addHardwareDetector = new RelayCommand(
                        param =>
                        {
                            _model.AddHardwareDetectorAsync();
                        });
                }
                return _addHardwareDetector;
            }
        }

        public ICommand RemoveHardwareDetector
        {
            get
            {
                if (_removeHardwareDetector == null)
                {
                    _removeHardwareDetector = new RelayCommand(
                        param =>
                        {
                            _model.RemoveHardwareDetectorAsync();
                        });
                }
                return _removeHardwareDetector;
            }
        }

        public ICommand UpdateHardwareDetector
        {
            get
            {
                if (_updateHardwareDetector == null)
                {
                    _updateHardwareDetector = new RelayCommand(
                        param =>
                        {
                            _model.UpdateHardwareDetectorAsync();
                        });
                }
                return _updateHardwareDetector;
            }
        }

        public ICommand AddDetectorWorkstation
        {
            get
            {
                if (_addDetectorWorkstation == null)
                {
                    _addDetectorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.AddDetectorWorkstationAsync();
                        });
                }
                return _addDetectorWorkstation;
            }
        }

        public ICommand RemoveDetectorWorkstation
        {
            get
            {
                if (_removeDetectorWorkstation == null)
                {
                    _removeDetectorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.RemoveDetectorWorkstationAsync();
                        });
                }
                return _removeDetectorWorkstation;
            }
        }

        public ICommand UpdateDetectorWorkstation
        {
            get
            {
                if (_updateDetectorWorkstation == null)
                {
                    _updateDetectorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.UpdateDetectorWorkstationAsync();
                        });
                }
                return _updateDetectorWorkstation;
            }
        }

        public ICommand AddLogicalWorkstation
        {
            get
            {
                if (_addLogicalWorkstation == null)
                {
                    _addLogicalWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.AddLogicalWorkstationAsync();
                        });
                }
                return _addLogicalWorkstation;
            }
        }

        public ICommand RemoveLogicalWorkstation
        {
            get
            {
                if (_removeLogicalWorkstation == null)
                {
                    _removeLogicalWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.RemoveLogicalWorkstationAsync();
                        });
                }
                return _removeLogicalWorkstation;
            }
        }

        public ICommand UpdateLogicalWorkstation
        {
            get
            {
                if (_updateLogicalWorkstation == null)
                {
                    _updateLogicalWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.UpdateLogicalWorkstationAsync();
                        });
                }
                return _updateLogicalWorkstation;
            }
        }

        public ICommand AddGeneratorWorkstation
        {
            get
            {
                if (_addGeneratorWorkstation == null)
                {
                    _addGeneratorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.AddGeneratorWorkstationAsync();
                        });
                }
                return _addGeneratorWorkstation;
            }
        }

        public ICommand RemoveGeneratorWorkstation
        {
            get
            {
                if (_removeGeneratorWorkstation == null)
                {
                    _removeGeneratorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.RemoveGeneratorWorkstationAsync();
                        });
                }
                return _removeGeneratorWorkstation;
            }
        }

        public ICommand UpdateGeneratorWorkstation
        {
            get
            {
                if (_updateGeneratorWorkstation == null)
                {
                    _updateGeneratorWorkstation = new RelayCommand(
                        param =>
                        {
                            _model.UpdateGeneratorWorkstationAsync();
                        });
                }
                return _updateGeneratorWorkstation;
            }
        }

        public ICommand ClearLog
        {
            get
            {
                if (_clearLog == null)
                {
                    _clearLog = new RelayCommand(
                        param =>
                        {
                            _model.ClearLog();
                        });
                }
                return _clearLog;
            }
        }

        public ICommand InitializeCollections
        {
            get
            {
                if (_initializeCollections == null)
                {
                    _initializeCollections = new RelayCommand(
                        param =>
                        {
                            _model.InitializeCollections();
                        });
                }
                return _initializeCollections;
            }
        }

        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                OnPropertyChanged(e.PropertyName);
            }), null);
        }

        #endregion
    }
}
