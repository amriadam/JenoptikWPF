using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenoptikWPF.Models
{
    public class Material : NotifyPropertyChangedBase
    {
        private String _name;
        private double _density;

        public string Name { 
            get => _name; 
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public double Density { 
            get => _density; 
            set
            {  
                _density = value;
                OnPropertyChanged(nameof(Density));
            }
        }
    }
}
