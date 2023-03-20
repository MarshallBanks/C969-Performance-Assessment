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
                                        "app.appointmentId AS 'Appointment ID', " +
                                        "app.customerId AS 'Customer ID', " +
                                        "app.title AS 'Title', " +
                                        "app.description AS 'Description', " +
                                        "app.location AS 'Location', " +
                                        "app.contact AS 'Contact', " +
                                        "app.type AS 'Type', " +
                                        "app.url AS 'URL', " +
                                        "app.end AS 'End', " +
                                        "app.createDate AS 'Create Date', " +
                                        "app.createdBy AS 'Created By', " +
                                        "app.lastUpdate AS 'Last Update', " +
                                        "app.lastUpdateBy AS 'Last Update By' " +
                                        "FROM appointment app " +
                                        "ORDER BY app.start;";

            MySqlCommand cmd = new MySqlCommand(getAppointmentData, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable custDataTable = new DataTable();
            adapter.Fill(custDataTable);

            appointmentDGV.DataSource = custDataTable;
            appointmentDGV.ClearSelection();
        }

        private void SchedulingForm_Load(object sender, EventArgs e)
        {
            loadAppointments();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddApptForm addApptForm = new AddApptForm();
            addApptForm.ShowDialog();
        }

        private void customerEditorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }


    }
}
