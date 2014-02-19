using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

using WaveCalculator.Lib;



namespace calculator_wht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     public class Person : INotifyPropertyChanged
    {
        private string name;
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                //Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Name");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public partial class MainWindow : Window
    {
        Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void box_L_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            var h = double.Parse(box_h.Text);
            var H = double.Parse(box_H.Text);
            var L = double.Parse(box_L.Text);

            var result = calculator.Calculate(L, H, h);

            Result.Content = result.state;

        }
    }

   


}
