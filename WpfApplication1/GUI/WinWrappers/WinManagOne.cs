using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

using WpfApplication1.GUI.Interfaces;

namespace WpfApplication1.GUI.WinWrappers
{

    public delegate void DoNoth();

    public class WinManagOne : IWindowLogic
    {

       public DoNoth Call;

        public void winActivate(object e,EventArgs ea)
        {
            MessageBox.Show("aktywne");
            Call();
        }
        public void winDeactivate(object e,EventArgs ea)
        {
            MessageBox.Show("NIEaktywne");
        }
    }
}
