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
        private string User { get; set; }
        private string Pass { get; set; }

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
            User = userBox.Text;
            Pass = passBox.Text;

            string checkUsernamePassword = "SELECT userName, password FROM client_schedule.user WHERE userName=@User AND password=@Pass";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = checkUsernamePassword;
            cmd.Parameters.AddWithValue("@User", User);
            cmd.Parameters.AddWithValue("@Pass", Pass);

            //using (mysqldatareader reader = cmd.executereader()) ;

        }
    }
}
