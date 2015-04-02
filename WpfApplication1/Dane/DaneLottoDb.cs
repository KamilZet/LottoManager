using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using WpfApplication1.Models;

namespace WpfApplication1.Dane
{
    public class DaneLottoDb : SuroweDane
    {
        public DaneLottoDb(){
            połączenieSerwera.StateChange += PołączenieZłamane;
        }

        public override List<byte> PobierzWynik(uint id, DateTime data)
        {
            throw new NotImplementedException();
        }

        protected override void Inicjalizacja()
        {
            if (połączenieSerwera == null)
            {
                połączenieSerwera = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;integrated security = true;database = BazaLosowańTS");
                połączenieSerwera.Open();
            }
            else if (połączenieSerwera.State == System.Data.ConnectionState.Closed)
            {
                połączenieSerwera.Open();
            }            
        }

        protected override void ŁadujLosowania()
        {
            //todo
            //zapis wyników z bazy do listy w obiekcie
            string zapytanie = "select * from dbo.losowanielotto";
            SqlCommand polecenieSql = new SqlCommand(zapytanie, połączenieSerwera);
            SqlDataReader reader = polecenieSql.ExecuteReader();
            // trzeba to uprościć
            WszystkieLosowania = reader.Cast<IDataRecord>()
                                    .Select(rd => new LosowanieLotto
                                    {
                                        id = (uint)rd.GetInt32(0)
                                     ,
                                        data = reader.GetDateTime(1)
                                     ,
                                        wynik = new List<byte>() { rd.GetByte(2) }
                                    }).Cast<Losowanie>().ToList();
        }

        private SqlConnection połączenieSerwera;

        public SqlConnection PołączenieSerwera
        {
            get { return połączenieSerwera; }
        }

        private void PołączenieZłamane(object o, StateChangeEventArgs a)
        {

        }
    }
}
