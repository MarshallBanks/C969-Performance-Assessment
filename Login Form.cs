using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySqlConnector;

namespace C969_Performance_Assessment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            //make connection
            MySqlConnection conn = null;

            try
            {
                //test connection
                conn = new MySqlConnection(constr);

                //open the connection
                conn.Open();

                MessageBox.Show("Connection is open");
            }
            catch(MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        
        }
    }
}
