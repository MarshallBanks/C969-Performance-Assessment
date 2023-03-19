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
            //    // Check for empty fields
            //    if (string.IsNullOrWhiteSpace(fullNameBox.Text) ||
            //        string.IsNullOrWhiteSpace(addressBox.Text) ||
            //        string.IsNullOrWhiteSpace(postalCodeBox.Text) ||
            //        string.IsNullOrWhiteSpace(phoneNumberBox.Text) ||
            //        string.IsNullOrWhiteSpace(cityComboBox.Text))
            //    {
            //        MessageBox.Show("Check required fields. Fields marked with an asterisk (*) are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    // Check the phone number for at least 10 digits
            //    else if (phoneNumberBox.Text.Where(char.IsDigit).Count() != 10)
            //    {
            //        // Display an error message to the user
            //        MessageBox.Show("Invalid phone number. Please enter a 10-digit phone number.");
            //    }
            //    // Check the full name for only letters and spaces
            //    else if (!(new Regex("^[a-zA-Z\\s]+$")).IsMatch(fullNameBox.Text))
            //    {
            //        // Display an error message to the user
            //        MessageBox.Show("Full Name can only contain spaces and letters.");
            //    }
            //    // Check the zip code for 5 digits
            //    else if (!(new Regex("^\\d{5}$")).IsMatch(postalCodeBox.Text))
            //    {
            //        // Display an error message to the user
            //        MessageBox.Show("Invalid postal code. Please enter a 5-digit postal code.");
            //    }
            //    // Check the address for invalid characters
            //    else if (!(new Regex("^^[a-zA-Z0-9 #&.,'-]*$")).IsMatch(addressBox.Text))
            //    {
            //        // Display an error message to the user
            //        MessageBox.Show("Invalid address. Please enter a valid address with only letters, numbers, and basic punctuation marks.");
            //    }
        }

        private void AddApptForm_Load(object sender, EventArgs e)
        {
            loadCustomerNames();
        }

        public void loadCustomerNames()
        {
            string getCustomerNames = "SELECT customerID, customerName FROM customer;";

            MySqlCommand cmd = new MySqlCommand(getCustomerNames, conn);

            Dictionary<int, string> customers = new Dictionary<int, string>();

            MySqlDataReader reader = cmd.ExecuteReader();

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
}
