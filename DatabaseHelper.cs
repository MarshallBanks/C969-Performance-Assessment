using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static C969_Performance_Assessment.Database.DBConnection;
using MySqlConnector;

namespace C969_Performance_Assessment
{
    class DatabaseHelper
    {
        public static class DBHandler
        {
            public static DataTable GetDataTableFromQuery(string query)
            {
                DataTable dt = new DataTable();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }
    }
}
