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
    public partial class UpdateApptForm : Form
    {

        private readonly int appointmentId;
        private string originalTitle;
        private string originalCustomer;
        private string originalContact;
        private string originalType;
        private string originalDescription;
        private string originalLocation;
        private string originalURL;
        private DateTime originalStartDateTime;
        private DateTime originalEndDateTime;


        public UpdateApptForm(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            // Save the ID of the selected customer to use in UPDATE query
            appointmentId = (int)selectedRow.Cells["Appointment ID"].Value;

            // Save the original values for each field
            originalTitle = (string)selectedRow.Cells["Title"].Value;
            originalCustomer = (string)selectedRow.Cells["Customer Name"].Value;
            originalContact = (string)selectedRow.Cells["Contact"].Value;
            originalType = (string)selectedRow.Cells["Type"].Value;
            originalDescription = (string)selectedRow.Cells["Description"].Value;
            originalLocation = (string)selectedRow.Cells["Location"].Value;
            originalURL = (string)selectedRow.Cells["URL"].Value;
            originalStartDateTime = (DateTime)selectedRow.Cells["Start"].Value;
            originalEndDateTime = (DateTime)selectedRow.Cells["End"].Value;
            

            // Set the values of the textboxes and radiobuttons
            titleTextBox.Text = originalTitle;
            customerComboBox.Text = originalCustomer;
            contactTxtBox.Text = originalContact;
            typeComboBox.Text = originalType;
            descriptionTextBox.Text = originalDescription;
            locationTextBox.Text = originalLocation;
            urlTextBox.Text = originalURL;
            startDateTimePicker.Value = originalStartDateTime;
            endDateTimePicker.Value = originalEndDateTime;
        }

        public void loadCustomerNames()
        {
            string getCustomerNames = "SELECT customerID, customerName FROM customer;";

            MySqlCommand cmd = new MySqlCommand(getCustomerNames, conn);

            Dictionary<int, string> customers = new Dictionary<int, string>();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int customerID = reader.GetInt32("customerID");
                    string customerName = reader.GetString("customerName");
                    customers.Add(customerID, customerName);
                }

                customerComboBox.DisplayMember = "Value";
                customerComboBox.ValueMember = "Key";
                customerComboBox.DataSource = new BindingSource(customers, null);
            }

        }

        private void UpdateApptForm_Load(object sender, EventArgs e)
        {
            loadCustomerNames();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                contactTxtBox.Enabled = false;
                contactTxtBox.Text = customerComboBox.Text;
            }
            else
            {
                contactTxtBox.Enabled = true;
                contactTxtBox.Clear();
            }
        }
    }
}
