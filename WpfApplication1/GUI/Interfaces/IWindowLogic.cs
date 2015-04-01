using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.GUI.Interfaces
{
    public interface IWindowLogic
    {
        void winActivate(object o, EventArgs e);
        void winDeactivate(object o, EventArgs e);
    }
}
