using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WpfApplication1.Models;

namespace UnitTesty
{
    [TestClass]
    public class FabrykaLosowańTEST
    {
        [TestMethod]
        public void TestMethod1()
        {
            FabrykaLosowań fl = new FabrykaLosowań(new SuroweDaneRT());
            Losowanie l = fl.PobierzLosowanie(1, new DateTime(2015, 1, 1), TypLosowania.Lotto);
            Assert.IsNotNull(l.wynik);



        }
    }
}
