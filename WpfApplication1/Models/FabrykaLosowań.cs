using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public class FabrykaLosowań : IFabrykaLosowań
    {

        public FabrykaLosowań(ISuroweDane daArg){
            da = daArg; 
        }

        private ISuroweDane da;

        public Losowanie PobierzLosowanie(uint idArg,DateTime dataArg,TypLosowania typArg )
        {
            switch (typArg){
                case TypLosowania.Lotto:
                    return new LosowanieLotto() { id = idArg, data = dataArg, wynik = da.PobierzWynik(idArg, dataArg, typArg) };
                    break;
                default:
                    throw new NotImplementedException("inne typy niezaimplementowane do tej pory");
                    break;
            }
        }
    }
}
