using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BaiDoXeTLU
{
    class ConnectDB
    {
        public static MySqlConnection conn;
        static string host = "127.0.0.1";
        static int port = 3306;
        static string database = "baidoxe";
        static string username = "root";
        static string password = "";
        public static string connString = "Server=" + host + ";Database=" + database
        + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SSL Mode=None;";


    }
}
