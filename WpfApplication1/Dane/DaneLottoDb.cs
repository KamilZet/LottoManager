using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace WpfApplication1.Dane
{
    public class DaneLottoDb : SuroweDane
    {

        public override List<byte> PobierzWynik(uint id, DateTime data)
        {
            throw new NotImplementedException();
        }
        protected override void ŁadujLosowania()
        {
            if (svrConn == null) 
            {
                svrConn = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;integrated security = true;database = BazaLosowańTS");
                svrConn.Open();
            }
            else if (svrConn.State == System.Data.ConnectionState.Closed)
            {
                svrConn.Open();
            }
        }

        public SqlConnection svrConn;
    }
}
