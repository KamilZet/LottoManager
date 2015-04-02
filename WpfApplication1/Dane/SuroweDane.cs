using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApplication1.Models;

namespace WpfApplication1.Dane
{
    public abstract class SuroweDane
    {
#region Konstruktor ---------------------------------------------------------------
        public SuroweDane()
        {
            // włącz połączenie z danymi
            Inicjalizacja();
            // jeżeli wyniki losowań nie zostały dotychczas pobrane, zrób to!            
            if (WszystkieLosowania == null)
                ŁadujLosowania();
        }
#endregion

#region Interfejs -----------------------------------------------------------------
        public abstract List<byte> PobierzWynik(uint id, DateTime data);



#endregion

        protected List<Losowanie> WszystkieLosowania = null;
        public List<Losowanie> ZobaczWszystkieLosowania
        {
            get { return WszystkieLosowania; }
        }
        protected abstract void ŁadujLosowania();
        protected abstract void Inicjalizacja(); 


    }
}
