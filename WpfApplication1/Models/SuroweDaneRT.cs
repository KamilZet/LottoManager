using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace WpfApplication1.Models
{
    public class SuroweDaneRT : ISuroweDane
    {

        public List<byte> PobierzWynik(uint idArg, DateTime dataArg, TypLosowania typArg)
        {

            List<byte> ret = new List<byte>(); 

            foreach (DaneLosowania dl in Wyniki())
            {
                if (dl.id == idArg && dl.data == dataArg && dl.typ == typArg)
                    ret = dl.wynik;
            }

            return ret; 
        }
        
        private class DaneLosowania
        {
            public int id;
            public DateTime data;
            public TypLosowania typ;
            public List<byte> wynik;
        }



        private static List<DaneLosowania> Wyniki(){
            return new List<DaneLosowania>(){
                new DaneLosowania{id = 1,data = new DateTime(2015,1,1),wynik = new List<byte>(){1,2,3,4,5,6}}
                ,new DaneLosowania{id = 2,data = new DateTime(2015,1,1),wynik = new List<byte>(){1,2,3,4,5,49}}};
        }
        
    }
}
