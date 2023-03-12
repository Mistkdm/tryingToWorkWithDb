using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prakt
{
    class db
    {
        MySqlConnection connect = new MySqlConnection("server=localhost; username=root; database=orderbd; sslmode=None");

        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed) connect.Open();
        }
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open) connect.Close();
        }
        public MySqlConnection GetConnect()
        {
            return connect;
        }
    }
}
