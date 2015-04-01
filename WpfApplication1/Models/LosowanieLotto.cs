using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    class LosowanieLotto : Losowanie
    {
        public override TypLosowania Typ()
        {
            return TypLosowania.Lotto;
        }
    }
}
