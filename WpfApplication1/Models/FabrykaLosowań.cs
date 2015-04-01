using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApplication1.Dane;

namespace WpfApplication1.Models
{
    public class FabrykaLosowań : IFabrykaLosowań
    {

        public FabrykaLosowań(SuroweDane daArg){
            da = daArg; 
        }

        private SuroweDane da;


        // przeładować funckję, aby można było wyszukiwać losowania stosując szerszy zakres kryteriów:
        // --- po numerze losowania, jego dacie, po typie losowania
        // lub węższy zakres kryteriów:
        // --- tylko po numerze losowania 
        // (wtedy produkowana jest potencjalnie kolekcja wyników, 
        // bo np. zarówno lotto, jak i lottoPlus mają taki sam nr losowania)

        public Losowanie PobierzLosowanie(uint idArg,DateTime dataArg)
        {
            return new LosowanieLotto() { id = idArg, data = dataArg, wynik = da.PobierzWynik(idArg, dataArg) };
        }
    }
}

