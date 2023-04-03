using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C969_Performance_Assessment.Database.DBConnection;

namespace C969_Performance_Assessment
{
    public partial class SchedulingForm : Form
    {
        public static SchedulingForm Instance { get; } = new SchedulingForm();

        public SchedulingForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Logged In As: " + CurrentUser.instance.Name;
        }

        private void SchedulingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void setColumnVisibility(DataGridView dgv)
        {
            dgv.Columns["Appointment ID"].Visible = false;
            dgv.Columns["Customer ID"].Visible = false;
            dgv.Columns["Create Date"].Visible = false;
            dgv.Columns["Last Update"].Visible = false;
            dgv.Columns["Last Update By"].Visible = false;
        }

        public void loadAppointments()
        {
            string getAppointmentData = "SELECT app.start AS 'Start', " +
                                        "app.end AS 'End', " +
                                        "app.appointmentId AS 'Appointment ID', " +
                                        "app.customerId AS 'Customer ID', " +
                                        "cust.customerName AS 'Customer Name', " +
                                        "app.title AS 'Title', " +
                                        "app.description AS 'Description', " +
                                        "app.location AS 'Location', " +
                                        "app.contact AS 'Contact', " +
                                        "app.type AS 'Type', " +
                                        "app.url AS 'URL', " +
                                        "app.createDate AS 'Create Date', " +
                                        "app.createdBy AS 'Created By', " +
                                        "app.lastUpdate AS 'Last Update', " +
                                        "app.lastUpdateBy AS 'Last Update By' " +
                                        "FROM appointment app " +
                                        "JOIN customer cust ON app.customerId = cust.customerId " +
                                        "ORDER BY app.start;";

            MySqlCommand cmd = new MySqlCommand(getAppointmentData, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable apptDataTable = new DataTable();
            adapter.Fill(apptDataTable);

            // Convert datetime values to the appropriate time zone for the user
            TimeZoneInfo userTimeZone = TimeZoneInfo.Local;
            foreach (DataRow row in apptDataTable.Rows)
            {
                row["Start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["Start"], userTimeZone);
                row["End"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["End"], userTimeZone);
                row["Create Date"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["Create Date"], userTimeZone);
                row["Last Update"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["Last Update"], userTimeZone);
            }

            appointmentDGV.DataSource = apptDataTable;
            appointmentDGV.ClearSelection();

            setColumnVisibility(appointmentDGV);
        }

        private void checkForUpcomingAppointments()
        {

            DateTime now = DateTime.Now;
            DateTime next15Minutes = now.AddMinutes(15);

            // Query the database to check for upcoming appointments within 15 minutes
            string query = "SELECT COUNT(*) FROM appointment WHERE start BETWEEN @Now AND @Next15Minutes AND createdBy = @user";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Now", now.ToUniversalTime());
                cmd.Parameters.AddWithValue("@Next15Minutes", next15Minutes.ToUniversalTime());
                cmd.Parameters.AddWithValue("@user", CurrentUser.instance.Name);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    // Display the alert
                    MessageBox.Show("You have an appointment coming up in 15 minutes!", "Appointment Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    // Display the alert
                    MessageBox.Show($"You have {count} appointments coming up in 15 minutes!", "Appointment Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void SchedulingForm_Load(object sender, EventArgs e)
        {
            loadAppointments();
            checkForUpcomingAppointments();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddApptForm addApptForm = new AddApptForm();
            addApptForm.ShowDialog();
            loadAppointments();
        }

        private void customerEditorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!appointmentDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select the customer you wish to delete", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataGridViewRow selectedRow = appointmentDGV.SelectedRows[0];

                string startDate = selectedRow.Cells["Start"].Value.ToString();
                string customerName = selectedRow.Cells["Customer Name"].Value.ToString();


                DialogResult answer = MessageBox.Show($"Are you sure you wish to delete your meeting with \"{customerName}\" on \"{startDate}\" from the list?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    int appointmentId = (int)selectedRow.Cells["Appointment ID"].Value;
                    string deleteAppointment = "DELETE FROM appointment WHERE appointmentId = @AppointmentId;";
                    using (MySqlCommand cmd = new MySqlCommand(deleteAppointment, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    this.loadAppointments();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!appointmentDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select the customer you wish to update", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UpdateApptForm updateApptForm = new UpdateApptForm(appointmentDGV.CurrentRow);
                updateApptForm.ShowDialog();
                loadAppointments();
            }
        }

       

        private void filterDataGridView(DateTime startDate, DateTime endDate)
        {
            // Added this to remove selected row
            // Prevents error: 'Row associated with the currency manager's position cannot be made invisible.'
            appointmentDGV.CurrentCell = null;

            // Filter the DataGridView by the start date column
            foreach (DataGridViewRow row in appointmentDGV.Rows)
            {
                DateTime date = (DateTime)row.Cells["Start"].Value;
                if (date < startDate || date > endDate)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }

            }

        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rb.PerformClick();
                    break;
                }
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rb.PerformClick();
                    break;
                }
            }
        }

        private void currentMonthButton_Click(object sender, EventArgs e)
        {
            // Filter by current month
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            filterDataGridView(startDate, endDate);
        }

        private void selectedMonthButton_Click(object sender, EventArgs e)
        {
            // Filter by selected month
            DateTime selectedDate = calendar.SelectionStart;
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            filterDataGridView(startDate, endDate);
        }

        private void currentWeekButton_Click(object sender, EventArgs e)
        {
            // Filter by selected week
            int difference = DayOfWeek.Monday - DateTime.Now.DayOfWeek;
            DateTime startDate = DateTime.Now.AddDays(difference);
            DateTime endDate = startDate.AddDays(6);
            filterDataGridView(startDate, endDate);
        }

        private void selectedWeekButton_Click(object sender, EventArgs e)
        {
            // Filter by current week
            DateTime selectedDate = calendar.SelectionStart;
            int difference = DayOfWeek.Monday - selectedDate.DayOfWeek;
            DateTime startDate = selectedDate.AddDays(difference);
            DateTime endDate = startDate.AddDays(6);
            filterDataGridView(startDate, endDate);
        }

        private void noFilterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in appointmentDGV.Rows)
            {
                row.Visible = true;
            }
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkForUpcomingAppointments();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportingForm reportingForm = new ReportingForm();
            reportingForm.Show();
        }
    }
}
