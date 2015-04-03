using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Dane
{
    public class DaneLottoPlusDb : DaneLottoDb
    {
        protected override void ŁadujLosowania()
        {
            
        }
        public override List<byte> PobierzWynik(uint id, DateTime data)
        {
            throw new NotImplementedException();
        }
        protected override void Inicjalizacja()
        {
            throw new NotImplementedException();
        }
    }
}
