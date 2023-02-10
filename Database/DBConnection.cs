using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Performance_Assessment.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {
            
            try
            {
                // Gets connection string and assigns to string variable
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                // Creates new MySqlConnection obj conn by passing connection string
                conn = new MySqlConnection(constr);

                // Creates the connection
                conn.Open();

            }
            catch (MySqlException exception)
            { 
                MessageBox.Show(exception.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
