using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    public class Connection
    {
        public MySqlConnection connection;
        public string Host;
        public string Database;
        public string Password;
        public string Username;
        public string ConnectionString;
        public Connection()
        {
            Host = "localhost";
            Password = "";
            Database = "cars";
            Username = "root";

            this.ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + Username + ";PASSWORD=" + Password + ";SslMode=None";
            
            connection = new MySqlConnection(this.ConnectionString);
        }


    }
}
