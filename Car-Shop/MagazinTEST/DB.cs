using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinTEST
{
    class DB
    {
       private MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=magazintest_users_db;Convert Zero Datetime=True");

        //functie deschide conexiune
        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //functie inchide conexiune
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //functie return conexiune 
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
