using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WpfApplication1.Models;
using WpfApplication1.Dane;
using System.Data.SqlClient;

namespace UnitTesty
{
    [TestClass]
    public class FabrykaLosowańTEST
    {
        [TestMethod]
        public void PołączDb()
        {
            DaneLottoDb db = new DaneLottoDb();
            Assert.IsTrue(db.svrConn.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void ZnajdźPoprawnyWynik()
        {
            FabrykaLosowań fl = new FabrykaLosowań(new DaneLottoRT());
            Losowanie l = fl.PobierzLosowanie(1, new DateTime(2015, 1, 1));
            Assert.IsNotNull(l.wynik);



        }
    }
}
