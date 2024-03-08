using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenoptikWPF.Models
{


    public class LaserParamsModel : NotifyPropertyChangedBase
    {
        private double _laserBeamDiameter;
        private double _pulseFrequency;
        private double _scanSpeed;
        private double _spotDiameter;
        private double _focusDistance;
        private double _dutyCycle;
        private double _laserPower;
        private double _laserSpeed;
        private double _focusDepth;
        private string _beamShape;
        private string _assistGas;
        

        public double LaserBeamDiameter { 
            get => _laserBeamDiameter; 
            set
            {
                _laserBeamDiameter = value;
                OnPropertyChanged(nameof(LaserBeamDiameter));
            }
        }
        public double PulseFrequency { 
            get => _pulseFrequency;
            set
            {
                _pulseFrequency = value;
                OnPropertyChanged(nameof(PulseFrequency));
            }
        }
        public double ScanSpeed {
            get => _scanSpeed;
            set 
            {
                _scanSpeed = value;
                OnPropertyChanged(nameof(ScanSpeed));
            }
        }
        public double SpotDiameter { 
            get => _spotDiameter; 
            set
            {
                _spotDiameter = value;
                OnPropertyChanged(nameof(SpotDiameter));
            }
        }
        public double FocusDistance { 
            get => _focusDistance;
            set
            {
                _focusDistance = value;
                OnPropertyChanged(nameof(FocusDistance));
            }
        }
        public double DutyCycle { get => _dutyCycle; 
            set 
            {
                _dutyCycle = value;
                OnPropertyChanged(nameof(DutyCycle));
            }
        }
        public double LaserPower { 
            get => _laserPower; 
            set 
            {
                _laserPower = value;
                OnPropertyChanged(nameof(LaserPower));
            }
        }
        public double LaserSpeed { 
            get => _laserSpeed; 
            set
            {
                _laserSpeed = value;
                OnPropertyChanged(nameof(LaserSpeed));
            }
        }
        public double FocusDepth { 
            get => _focusDepth; 
            set
            {
                _focusDepth = value;
                OnPropertyChanged(nameof(FocusDepth));
            }
        }
        public string BeamShape { 
            get => _beamShape; 
            set
            {
                _beamShape = value;
                OnPropertyChanged(nameof(BeamShape));
            }
        }
        public string AssistGas { 
            get => _assistGas; 
            set
            {
                _assistGas = value;
                OnPropertyChanged(nameof(AssistGas));
            }
        }
        
    }
}
