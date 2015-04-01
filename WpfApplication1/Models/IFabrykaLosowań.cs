using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public interface IFabrykaLosowań
    {
        Losowanie PobierzLosowanie(uint id,DateTime data);
    }
}
