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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var viewModel = new ViewModel();
            viewModel.FirstName = "Reut";

            DataContext = viewModel;
            InitializeComponent();

            viewModel.FirstName = "Renana";

            //string str = "set controls/flight/rudder 1";
            //Console.Write(str + "\r");
            //ServerSide c = new ServerSide();
            //c.ServerConnect();

            // ClientSide cl = new ClientSide();
            //cl.ClientConnect();
            //Joystick j = new Joystick();
            //j.InitializeComponent();
        }
    }
}
