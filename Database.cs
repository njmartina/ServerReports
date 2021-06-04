using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ServerReports
{
    class Database
    {
        public static SQLiteConnection AccessDatabase()
        {
            using var con = new SQLiteConnection("Data Source=sqliteDB.db");
            con.Open();

            using var cmd = new SQLiteCommand("SELECT SQLITE_VERSION()", con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"version: {version}");

            return con;
        }
    }
}
