using JenoptikWPF.Models;
using JenoptikWPF.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace JenoptikWPF.ViewModels
{
    internal class ParamsManagementModelView : NotifyPropertyChangedBase
    {
        private LaserParamsModel? _params;
        private List<Material>? _materialList;
        private IEnumerable<string>? _materialNamesList;

        public ParamsManagementModelView()
        {
            LaserParamsModel = new LaserParamsModel()
            {
                AssistGas = "CO2",
                BeamShape = "Gaussian",
                DutyCycle = 60,
                FocusDepth = 0,
                FocusDistance = 240,
                LaserBeamDiameter = 40,
                LaserPower = 0,
                LaserSpeed = 0,
                PulseFrequency = 60,
                ScanSpeed = 1000,
                SpotDiameter = 250
            };

            MaterialList = new List<Material>()
            {
                new Material()
                {
                    Name = "Stainless Steal",
                    Density = 7700
                },
                new Material()
                {
                    Name = "Plastic",
                    Density = 1700
                }
            };

            MaterialNamesList = MaterialList.Select(material => material.Name).ToList();

            OpenAdvancedSettingsCommand = new RelayCommand(ExecuteOpenAdvancedSettings, CanExecuteOpenAdvancedSettings);
            OpenScanSettingsCommand = new RelayCommand(ExecuteOpenScanSettings, CanExecuteOpenScanSettings);
            OpenMaterialSettingsCommand = new RelayCommand(ExecuteOpenLoadMaterialSettings, CanExecuteOpenLoadMaterialSettings);
        }

        public LaserParamsModel? LaserParamsModel
        {
            get { return _params; }
            set
            {
                _params = value;
                OnPropertyChanged(nameof(LaserParamsModel));
            }
        }

        public List<Material> MaterialList { 
            get { return _materialList; } 
            set 
            {
                _materialList = value;
                OnPropertyChanged(nameof(LaserParamsModel));
            } 
        }

        public IEnumerable<string> MaterialNamesList
        {
            get { return _materialNamesList; }
            set
            {
                _materialNamesList = value;
                OnPropertyChanged(nameof(MaterialNamesList));
            }
        }

        public RelayCommand OpenAdvancedSettingsCommand { get; private set; }
        private AdvancedSettingsDialogs? _advancedSettingsDialogs;

        public RelayCommand OpenScanSettingsCommand { get; private set; }
        private ScanParamsDialog? _scanParamsDialogs;

        public RelayCommand OpenMaterialSettingsCommand { get; private set; }
        private LoadMaterialParamsDialog? _loadMaterialSettingsDialogs;
        

        //---------------------------------------------------------
        //---------------------------------------------------------
        private bool CanExecuteOpenAdvancedSettings(object? parameter)
        {
            return _advancedSettingsDialogs is null;
        }
        private void ExecuteOpenAdvancedSettings(object? parameter)
        {
            _advancedSettingsDialogs = new AdvancedSettingsDialogs();
            _advancedSettingsDialogs.DataContext = this;
            _advancedSettingsDialogs.Closed += _advancedSettingsDialogs_Closed;
            OpenAdvancedSettingsCommand.InvokeCanExecuteChanged();
            _advancedSettingsDialogs.Show();
        }

        private void _advancedSettingsDialogs_Closed(object? sender, EventArgs e)
        {
            _advancedSettingsDialogs = null;
            OpenAdvancedSettingsCommand.InvokeCanExecuteChanged();
        }

        //-----------------------------------------------------------
        //-----------------------------------------------------------

        private bool CanExecuteOpenScanSettings(object? parameter)
        {
            return _scanParamsDialogs is null;
        }
        private void ExecuteOpenScanSettings(object? parameter)
        {
            _scanParamsDialogs = new ScanParamsDialog();
            _scanParamsDialogs.DataContext = this;
            _scanParamsDialogs.Closed += _scanSettingsDialogs_Closed;
            OpenAdvancedSettingsCommand.InvokeCanExecuteChanged();
            _scanParamsDialogs.Show();
        }

        private void _scanSettingsDialogs_Closed(object? sender, EventArgs e)
        {
            _scanParamsDialogs = null;
            OpenScanSettingsCommand.InvokeCanExecuteChanged();
        }

        //-----------------------------------------------------------
        //-----------------------------------------------------------

        private bool CanExecuteOpenLoadMaterialSettings(object? parameter)
        {
            return _loadMaterialSettingsDialogs is null;
        }
        private void ExecuteOpenLoadMaterialSettings(object? parameter)
        {
            _loadMaterialSettingsDialogs = new LoadMaterialParamsDialog();
            _loadMaterialSettingsDialogs.DataContext = this;
            _loadMaterialSettingsDialogs.Closed += _loadMaterialSettingsDialogs_Closed;
            OpenMaterialSettingsCommand.InvokeCanExecuteChanged();
            _loadMaterialSettingsDialogs.Show();
        }

        private void _loadMaterialSettingsDialogs_Closed(object? sender, EventArgs e)
        {
            _loadMaterialSettingsDialogs = null;
            OpenMaterialSettingsCommand.InvokeCanExecuteChanged();
        }

    }
}
