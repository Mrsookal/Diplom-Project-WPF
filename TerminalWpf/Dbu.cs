using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TerminalWpf
{
    class Dbu
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "188.93.210.124";
            int port = 3306;
            string database = "vladiplom";
            string user = "test123";
            string pass = "test1234";


            return Dbconn.GetDBConnection(host, port, database, user, pass);
        }
    }
}
