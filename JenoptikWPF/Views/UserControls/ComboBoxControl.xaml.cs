using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JenoptikWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ComboBoxControl.xaml
    /// </summary>
    public partial class ComboBoxControl : UserControl
    {
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public IEnumerable<string> Items
        {
            get { return (IEnumerable<string>) GetValue(ItemsProperty);}
            set { SetValue(ItemsProperty, value); }
        }

        public string Value
        {
            get { return (string) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register(nameof(Header), typeof(string), typeof(ComboBoxControl), new PropertyMetadata(null));


        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(nameof(Items), typeof(IEnumerable<string>), typeof(ComboBoxControl), new PropertyMetadata(null));


        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(string), typeof(ComboBoxControl), new PropertyMetadata(null));


        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            
            if (e.Property == HeaderProperty)
            {
                mHeaderLabel.Content = Header;
            }

            if(e.Property == ItemsProperty)
            {
                mComboBox.ItemsSource = Items;
                mComboBox.SelectedItem = Items.FirstOrDefault();//Defult for a class means null; // Ican add a condition to specify the first(x=>x[0]=='a') for example
            }

            if (e.Property == ValueProperty)
            {
                mComboBox.SelectedItem = Value;
            }

            base.OnPropertyChanged(e);
        }

        public ComboBoxControl()
        {
            InitializeComponent();
        }
    }
}
