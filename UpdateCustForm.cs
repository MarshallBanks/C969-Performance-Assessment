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
using MySqlConnector;
using static C969_Performance_Assessment.Database.DBConnection;

namespace C969_Performance_Assessment
{
    public partial class UpdateCustForm : Form
    {
        private readonly int customerId;

        private string originalFullName;
        private string originalAddress;
        private string originalPostalCode;
        private string originalCity;
        private string originalPhoneNumber;
        private bool originalIsActive;

        

        public UpdateCustForm(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            

            // Save the ID of the selected customer to use in UPDATE query
            customerId = (int)selectedRow.Cells["Customer ID"].Value;

            // Save the original values for each field
            originalFullName = (string)selectedRow.Cells["Customer Name"].Value;
            originalAddress = (string)selectedRow.Cells["Address"].Value;
            originalPostalCode = (string)selectedRow.Cells["Postal Code"].Value;
            originalPhoneNumber = (string)selectedRow.Cells["Phone"].Value;
            originalCity = (string)selectedRow.Cells["City"].Value;
            originalIsActive = (bool)selectedRow.Cells["Active"].Value;


            // Set the values of the textboxes and radiobuttons
            fullNameBox.Text = originalFullName;
            addressBox.Text = originalAddress;
            postalCodeBox.Text = originalPostalCode;
            phoneNumberBox.Text = originalPhoneNumber;
            cityComboBox.SelectedItem = originalCity;
            activeButton.Checked = originalIsActive;
            inactiveButton.Checked = !originalIsActive;
        }

        private void UpdateCustForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(fullNameBox.Text) ||
                string.IsNullOrWhiteSpace(addressBox.Text) ||
                string.IsNullOrWhiteSpace(postalCodeBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberBox.Text) ||
                string.IsNullOrWhiteSpace(cityComboBox.Text))
            {
                MessageBox.Show("Check required fields. Fields marked with an asterisk (*) are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check the phone number for at least 10 digits
            else if (phoneNumberBox.Text.Where(char.IsDigit).Count() != 10)
            {
                MessageBox.Show("Invalid phone number. Please enter a 10-digit phone number.");
            }
            // Check the full name for only letters and spaces
            else if (!(new Regex("^[a-zA-Z\\s]+$")).IsMatch(fullNameBox.Text))
            {
                MessageBox.Show("Full Name can only contain spaces and letters.");
            }
            // Check the zip code for 5 digits
            else if (!(new Regex("^\\d{5}$")).IsMatch(postalCodeBox.Text))
            {
                MessageBox.Show("Invalid postal code. Please enter a 5-digit postal code.");
            }
            // Check the address for invalid characters
            else if (!(new Regex("^^[a-zA-Z0-9 #&.,'-]*$")).IsMatch(addressBox.Text))
            {
                MessageBox.Show("Invalid address. Please enter a valid address with only letters, numbers, and basic punctuation marks.");
            }
            else
            {
                UpdateCustomer();
            }
        }

        private void UpdateCustomer()
        {
            string updateQuery = "UPDATE customer c INNER JOIN address a ON c.addressId = a.addressId SET ";
            string fullName = fullNameBox.Text;
            string address = addressBox.Text;
            string postalCode = postalCodeBox.Text;
            string phone = phoneNumberBox.Text;
            string city = cityComboBox.Text;
            int cityId = 0;
            bool isActive = activeButton.Checked;

            if (fullName != originalFullName)
            {
                updateQuery += "c.customerName = @FullName, ";
            }

            if (address != originalAddress)
            {
                updateQuery += "a.address = @Address, ";
            }

            if (postalCode != originalPostalCode)
            {
                updateQuery += "a.postalCode = @PostalCode, ";
            }

            if (phone != originalPhoneNumber)
            {
                updateQuery += "a.phone = @Phone, ";
            }

            if (city != originalCity)
            {
                updateQuery += "a.cityId = @CityId, ";

                // Get cityId from the database
                string getCityIDQuery = "SELECT cityID FROM city WHERE city = @City;";
                using (MySqlCommand cmd = new MySqlCommand(getCityIDQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@City", city);
                    cityId = (int)cmd.ExecuteScalar();
                }
            }

            if (isActive != originalIsActive)
            {
                updateQuery += "c.active = @Active, ";
            }

            // Add lastUpdateBy and WHERE clause to the end of the query
            updateQuery += "c.lastUpdate = UTC_TIMESTAMP(), c.lastUpdateBy = @LastUpdateBy WHERE c.customerId = @CustomerId;";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@CityId", cityId);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@Active", Convert.ToInt32(isActive));
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.ExecuteNonQuery();
            }



            this.Close();
        }


        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            // Remove any non digits
            string digitsOnly = new string(phoneNumberBox.Text.Where(char.IsDigit).ToArray());

            //Limit the input to 14 digits
            if (digitsOnly.Length > 10)
            {
                digitsOnly = digitsOnly.Substring(0, 10);
            }

            // Format the phone number with parentheses and hyphens
            if (digitsOnly.Length >= 3 && digitsOnly.Length <= 6)
            {
                phoneNumberBox.Text = string.Format("({0}) {1}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3));
                phoneNumberBox.SelectionStart = phoneNumberBox.Text.Length;
            }
            else if (digitsOnly.Length > 6)
            {
                phoneNumberBox.Text = string.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3, 3), digitsOnly.Substring(6));
                phoneNumberBox.SelectionStart = phoneNumberBox.Text.Length;
            }
        }


    }
}
