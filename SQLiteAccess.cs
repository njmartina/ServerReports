using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;
using Dapper;

namespace ServerReports
{
    class SQLiteAccess
    {
        public static void SaveServer(Server server)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("insert into servers (FirstName, LastName, DateOfBirth) values (@FirstName, @LastName, @DateOfBirth)", server);
            }
        }

        public static List<Server> LoadServers()
        {
            string sql = "select FirstName, LastName, DateOfBirth from servers";

            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Server>(sql).ToList();

                return output;
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
