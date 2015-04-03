using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using WpfApplication1.Models;

namespace WpfApplication1.Dane
{
    public class DaneLottoRT : SuroweDane
    {

        public override List<byte> PobierzWynik(uint idArg, DateTime dataArg)
        {

            List<byte> ret = new List<byte>(); 

            foreach (LosowanieLotto dl in Wyniki())
            {
                if (dl.id == idArg && dl.data == dataArg)
                    ret = dl.wynik;
            }

            return ret; 
        }

        protected override void ŁadujLosowania()
        {   
            // Konwersja covariant. Klasa abstrakcyjna wymaga typu bazowego
            // , a nie specjalizowanego.
            WszystkieLosowania = Wyniki().Cast<Losowanie>().ToList();
        }

        protected override void Inicjalizacja()
        {
           // pusta metoda wynikająca z zastosowania metody szablonowej
           // w konstruktorze klasy bazowej
        }

        private static List<LosowanieLotto> Wyniki(){
            return new List<LosowanieLotto>(){
                new LosowanieLotto{id = 1,data = new DateTime(2015,1,1),wynik = new List<byte>(){1,2,3,4,5,6}}
                ,new LosowanieLotto{id = 2,data = new DateTime(2015,1,1),wynik = new List<byte>(){1,2,3,4,5,49}}};
        }
        
    }
}
