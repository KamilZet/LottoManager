using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public interface ISuroweDane
    {
        List<byte> PobierzWynik(uint id, DateTime data, TypLosowania typ);

    }
}
