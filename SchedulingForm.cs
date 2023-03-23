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
            DataTable custDataTable = new DataTable();
            adapter.Fill(custDataTable);

            appointmentDGV.DataSource = custDataTable;
            appointmentDGV.ClearSelection();

            // Set the visibility of the appointment ID, customer ID, create date, last update, and last update by columns to false
            appointmentDGV.Columns["Appointment ID"].Visible = false;
            appointmentDGV.Columns["Customer ID"].Visible = false;
            appointmentDGV.Columns["Create Date"].Visible = false;
            appointmentDGV.Columns["Last Update"].Visible = false;
            appointmentDGV.Columns["Last Update By"].Visible = false;
        }

        private void SchedulingForm_Load(object sender, EventArgs e)
        {
            loadAppointments();
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
            }
        }
    }
}
