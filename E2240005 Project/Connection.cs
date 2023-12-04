using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace E2240005_Project
{
    public class Connection
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = BITlmsDB; Integrated Security = True");
        public SqlConnection ActiveCon()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }

}
