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
        public void PołączBazę()
        {
            DaneLottoDb db = new DaneLottoDb();
            Assert.IsTrue(db.PołączenieSerwera.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void ZnajdźPoprawnyWynik()
        {
            FabrykaLosowań fl = new FabrykaLosowań(new DaneLottoRT());
            Losowanie l = fl.PobierzLosowanie(1, new DateTime(2015, 1, 1));
            Assert.IsNotNull(l.wynik);
        }
        [TestMethod]
        public void PobierzWynikZBazy(){
            SuroweDane sd = new DaneLottoDb();
            Assert.IsNotNull(sd.ZobaczWszystkieLosowania);
                  
        }
        [TestMethod]
        public void PobierzWszystkieWynikiZDaty()
        {
            //pobranie listy WSZYSTKICH (bez względu na typ losowania)
            //wyników dla określonej daty


        }
        }
    }

