using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public abstract class SuroweDane
    {
#region Konstruktor ---------------------------------------------------------------
        public SuroweDane()
        {
            if (WszystkieLosowania == null)
                ŁadujLosowania();
        }
#endregion

#region Interfejs -----------------------------------------------------------------
        public abstract List<byte> PobierzWynik(uint id, DateTime data, TypLosowania typ);



#endregion

        private List<Losowanie> WszystkieLosowania = null;
        private abstract void ŁadujLosowania()
        {

        }

    }
}
