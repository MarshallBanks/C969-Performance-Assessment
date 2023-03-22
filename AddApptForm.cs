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
    public partial class AddApptForm : Form
    {
        public AddApptForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
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
                createAppointment();
            }
        }

        private void createAppointment()
        {
            int customerId = (int)customerComboBox.SelectedValue;
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            string location = locationTextBox.Text;
            string contact = customerComboBox.Text;
            string type = typeComboBox.Text;
            string url = urlTextBox.Text;
            DateTime start = startDateTimePicker.Value;
            DateTime end = endDateTimePicker.Value;
            string addressInsert = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                                    "VALUES (@CustomerId, @UserId, @Title, @Description, @Type, @Location, @Contact, @URL, @Start, @End, NOW(), @CreatedBy, NOW(), @LastUpdateBy);";
            using (MySqlCommand cmd = new MySqlCommand(addressInsert, conn))
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
                cmd.Parameters.AddWithValue("@CreatedBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Start Date/Time: " + startDateTimePicker.Value.ToString() + "\n" +
            "End Date/Time: " + endDateTimePicker.Value.ToString());

            this.Close();
        }

        private void AddApptForm_Load(object sender, EventArgs e)
        {
            loadCustomerNames();
            contactTxtBox.Text = customerComboBox.Text;
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

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustForm addCustForm = new AddCustForm();
            addCustForm.ShowDialog();
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
            if(checkBox1.Checked)
            {
                contactTxtBox.Text = customerComboBox.Text;
            }
        }
    }
}
