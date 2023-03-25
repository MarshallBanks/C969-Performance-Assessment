using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            // Set the values of the status labels
            toolStripStatusLabel1.Text = "Created By User: " + (string)selectedRow.Cells["Created By"].Value;
            toolStripStatusLabel2.Text = "Create Date: " + ((DateTime)selectedRow.Cells["Create Date"].Value).ToString("g");
            toolStripStatusLabel3.Text = "Last Update By User: " + (string)selectedRow.Cells["Last Update By"].Value;
            toolStripStatusLabel4.Text = "Last Update: " + ((DateTime)selectedRow.Cells["Last Update"].Value).ToString("g");
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

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                contactTxtBox.Text = customerComboBox.Text;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(typeComboBox.Text) ||
                string.IsNullOrWhiteSpace(customerComboBox.Text) ||
                string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                MessageBox.Show("Check required fields. Fields marked with an asterisk (*) are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (titleTextBox.Text.Length < 4)
            {
                // Display an error message to the user
                MessageBox.Show("Invalid Title. Title must have at least 5 characters.");
            }
            // Check the contact for only letters and spaces
            else if (!(new Regex("^[a-zA-Z\\s]+$")).IsMatch(contactTxtBox.Text))
            {
                // Display an error message to the user
                MessageBox.Show("Contact can only contain spaces and letters.");
            }
            // Check the URL for matching pattern including HTTPS/HTTP/WWW
            else if (!(new Regex(@"^(?:(?:https?|ftp)://)?(?:www\.)?[a-z0-9]+(?:\.[a-z]{2,}){1,3}(?:/?|\#[\w\-\%\=\?]+)?$")).IsMatch(urlTextBox.Text) && !string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                // Display an error message to the user
                MessageBox.Show("Invalid URL. Please enter a valid url e.g. www.example.com.");
            }
            // Check the location for invalid characters
            else if (!(new Regex("^^[a-zA-Z0-9 #&.,'-]*$")).IsMatch(locationTextBox.Text))
            {
                // Display an error message to the user
                MessageBox.Show("Invalid location. Please enter a valid location with only letters, numbers, and basic punctuation marks.");
            }
            else if (endDateTimePicker.Value < startDateTimePicker.Value)
            {
                MessageBox.Show("End date/time must be after start date/time.");
                return;
            }
            else if (endDateTimePicker.Value == startDateTimePicker.Value)
            {
                MessageBox.Show("End date/time must be after start date/time.");
                return;
            }
            else
            {
                updateAppointment();
            }
        }


        private void updateAppointment()
        {
            string updateAppQuery = "UPDATE appointment SET ";

            string customer = customerComboBox.Text;
            int customerId = (int)customerComboBox.SelectedValue;
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            string location = locationTextBox.Text;
            string contact = checkBox1.Checked ? customerComboBox.Text : contactTxtBox.Text;
            string type = typeComboBox.Text;
            string url = urlTextBox.Text;
            DateTime start = startDateTimePicker.Value;
            DateTime end = endDateTimePicker.Value;

            if (customer != originalCustomer)
            {
                updateAppQuery += "customerId = @CustomerId, ";
            }
            if (title != originalTitle)
            {
                updateAppQuery += "title = @Title, ";
            }
            if (description != originalDescription)
            {
                updateAppQuery += "description = @Description, ";
            }
            if (location != originalLocation)
            {
                updateAppQuery += "location = @Location, ";
            }
            if (contact != originalContact)
            {
                updateAppQuery += "contact = @Contact, ";
            }
            if (type != originalType)
            {
                updateAppQuery += "type = @Type, ";
            }
            if (url != originalURL)
            {
                updateAppQuery += "url = @URL, ";
            }
            if (start != originalStartDateTime)
            {
                updateAppQuery += "start = @Start, ";
            }
            if (end != originalEndDateTime)
            {
                updateAppQuery += "end = @End, ";
            }

            // Add lastUpdateBy and WHERE clause to the query
            updateAppQuery += "lastUpdate = UTC_TIMESTAMP(), lastUpdateBy = @LastUpdateBy WHERE appointmentId = @AppointmentId;";

            // Convert start and end times to UTC
            TimeZoneInfo userTimeZone = TimeZoneInfo.Local;
            start = TimeZoneInfo.ConvertTimeToUtc(start, userTimeZone);
            end = TimeZoneInfo.ConvertTimeToUtc(end, userTimeZone);

            using (MySqlCommand cmd = new MySqlCommand(updateAppQuery, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@UserId", CurrentUser.instance.Id);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@URL", url);
                cmd.Parameters.AddWithValue("@Start", start);
                cmd.Parameters.AddWithValue("@End", end);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
