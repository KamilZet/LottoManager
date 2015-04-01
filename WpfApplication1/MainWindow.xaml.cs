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

using WpfApplication1.GUI.WinWrappers;
using WpfApplication1.GUI.Interfaces;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    
    
    public partial class MainWindow : Window
    {
        private IWindowLogic winCtrl = new WinManagOne();

        public MainWindow()
        {
            InitializeComponent();
            base.Activated += new EventHandler(winCtrl.winActivate);
            base.Deactivated += new EventHandler (winCtrl.winDeactivate);
            ((WinManagOne)winCtrl).Call += appExit;
        }



        private void appExit()
        {
        }
        private void appActivate(object o, EventArgs e)
        {
            
        }
    }
}
