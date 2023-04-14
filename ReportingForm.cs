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
    public partial class ReportingForm : Form
    {
        public ReportingForm()
        {
            InitializeComponent();
        }

        private void typeCountByMonth_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT DATE_FORMAT(start, '%M') AS Month, type, COUNT(*) as Count " +
                "FROM appointment " +
                "GROUP BY Month, type " +
                "ORDER BY Month, type;";


            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);

            reportDataGridView.DataSource = dt;


        }

        private void appointmentsByConsultant_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select u.userName AS Consultant, a.start AS Start, a.end AS End FROM appointment a JOIN user u ON u.userId = a.userId ORDER BY Consultant; ";

            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);

            reportDataGridView.DataSource = dt;

            // Set the column to true. This reverses setting it to false in type count by month report
            reportDataGridView.Columns["start"].Visible = true;
        }

        private void appointmentByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select c.customerName AS Customer, a.start AS Start, a.end AS End FROM appointment a JOIN customer c ON c.customerId = a.customerId ORDER BY Customer; ";

            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);

            reportDataGridView.DataSource = dt;

            // Set the column to true. This reverses setting it to false in type count by month report
            reportDataGridView.Columns["start"].Visible = true;

        }

        private void ReportingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SchedulingForm.Instance.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SchedulingForm.Instance.Show();
        }
    }
    
    
}
