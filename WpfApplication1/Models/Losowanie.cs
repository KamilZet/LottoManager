using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public abstract class Losowanie
    {
        public virtual List<byte> Wynik()
        {
            if (wynik == null)
                throw new NullReferenceException("Wynik nie posiada wartości!");
            return wynik;
        }

        public abstract TypLosowania Typ();

        public override string ToString()
        {
            return Typ().ToString();
        }

        public uint id;
        public DateTime data;
        public List<byte> wynik;

    }
    
}
