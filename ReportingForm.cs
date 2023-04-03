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
            string query = "SELECT start, type, COUNT(*) as Count FROM appointment GROUP BY start, type ORDER BY start, type;";

            // Call the GetDataTableFromQuery method to execute the query and retrieve a DataTable
            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);

            // Add a new column to the DataTable to hold the month name values
            DataColumn monthColumn = new DataColumn("Month", typeof(string));
            dt.Columns.Add(monthColumn);

            // Convert the UTC time values to local time values and populate the new Month column
            foreach (DataRow row in dt.Rows)
            {
                DateTime startUtc = DateTime.Parse(row["start"].ToString());
                DateTime startLocal = startUtc.ToLocalTime();
                row["Month"] = startLocal.ToString("MMMM");
            }

            reportDataGridView.DataSource = dt;

            // Set the DisplayIndex of the Month column to 0 to make it the first visible column
            reportDataGridView.Columns["Month"].DisplayIndex = 0;

            // Hide the start column
            reportDataGridView.Columns["start"].Visible = false;
        }

        private void appointmentsByConsultant_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select u.userName AS Consultant, a.start AS Start, a.end AS End FROM appointment a JOIN user u ON u.userId = a.userId ORDER BY Consultant; ";

            // Call the GetDataTableFromQuery method to execute the query and retrieve a DataTable
            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);
            
            reportDataGridView.DataSource = dt;

            // Set the column to true to reverse setting it to false in type count by month report
            reportDataGridView.Columns["start"].Visible = true;
        }

        private void appointmentByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select c.customerName AS Customer, a.start AS Start, a.end AS End FROM appointment a JOIN customer c ON c.customerId = a.customerId ORDER BY Customer; ";

            // Call the GetDataTableFromQuery method to execute the query and retrieve a DataTable
            DataTable dt = DatabaseHelper.DBHandler.GetDataTableFromQuery(query);

            reportDataGridView.DataSource = dt;

            // Set the column to true to reverse setting it to false in type count by month report
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
