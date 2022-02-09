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

using System.Collections.ObjectModel;

namespace ch03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<clsDevice> DEV = new ObservableCollection<clsDevice>();
        clsEQP EQP = new clsEQP(); 

        public MainWindow()
        {
            InitializeComponent();
            //lstBox.ItemsSource = this.DEV; //바인딩
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //clsPLC device = new clsPLC();
            //device.Write();
            //device.Read();

            //this.DEV.Add(device);
            this.EQP.ADD("PLC");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //    clsMOUSE device = new clsMOUSE();
            //    device.Write();
            //    device.Read();

            //    this.DEV.Add(device);
            this.EQP.ADD("MOUSE");
        }
    }
}
