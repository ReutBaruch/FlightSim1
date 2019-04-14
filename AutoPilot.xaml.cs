using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//using FlightSimulator.ViewModels;
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
    /// Interaction logic for TextScript.xaml
    /// </summary>
    public partial class TextScript : UserControl
    {
        public TextScript()
        {
            InitializeComponent();
            TextScriptViewModel tscm = new TextScriptViewModel();
            DataContext = tscm;
        }
    }
}
