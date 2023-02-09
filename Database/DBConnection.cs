using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Performance_Assessment.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }
    }
}
