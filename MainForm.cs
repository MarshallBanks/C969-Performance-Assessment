using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Performance_Assessment
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; } = new MainForm();

        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Logged In As: " + CurrentUser.instance.Name;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void apptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchedulingForm schedulingForm = new SchedulingForm();
            schedulingForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

    }
}
