﻿using System;
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
    public partial class AddCustForm : Form
    {

        public AddCustForm()
        {
            InitializeComponent();
        }

        private void AddCustForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
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
            // Using the LAMBDA expression is easier to read and in some cases faster if the regex expression is complicated
            else if (!fullNameBox.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Full Name can only contain spaces and letters.");
            }
            // Check the zip code for 5 digits
            else if (!(new Regex("^\\d{5}$")).IsMatch(postalCodeBox.Text))
            {
                // Display an error message to the user
                MessageBox.Show("Invalid postal code. Please enter a 5-digit postal code.");
            }
            // Check the address for invalid characters
            // Using the LAMBDA is easier to read than using a regex: else if (!(new Regex("^^[a-zA-Z0-9 #&.,'-]*$")).IsMatch(addressBox.Text))
            // so, better maintainability if someone else reads it and like stated above, it can be faster if the regex patter is complex. 
            else if (!addressBox.Text.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == '#' || c == '&' || c == '.' || c == ',' || c == '-' || c == '\''))
            {
                MessageBox.Show("Invalid address. Please enter a valid address with only letters, numbers, and basic punctuation marks.");
            }
            else
            {
                createCustomer();
            }
        }

        private void createCustomer()
        {
            string cityName = cityComboBox.SelectedItem.ToString();
            int cityId;
            string getCityIDQuery = "SELECT cityID FROM city WHERE city = @CityName;";
            using (MySqlCommand cmd = new MySqlCommand(getCityIDQuery, conn))
            {
                cmd.Parameters.AddWithValue("@CityName", cityName);
                cityId = (int)cmd.ExecuteScalar();
            }


            string postalCode = postalCodeBox.Text;
            string phone = phoneNumberBox.Text;
            string address = addressBox.Text;
            string addressInsert = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) VALUES (@Address, '', @CityId, @PostalCode, @Phone, UTC_TIMESTAMP(), @CreatedBy, @LastUpdateBy);";
            using (MySqlCommand cmd = new MySqlCommand(addressInsert, conn))
            {
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@CityId", cityId);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@CreatedBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                cmd.ExecuteNonQuery();
            }

            int addressId;
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
            {
                addressId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string name = fullNameBox.Text;
            bool isActive = activeButton.Checked;
            string customerInsert = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@Name, @AddressID, @isActive, UTC_TIMESTAMP(), @CreatedBy, UTC_TIMESTAMP(), @LastUpdateBy );";
            using (MySqlCommand cmd = new MySqlCommand(customerInsert, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@AddressID", addressId);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.Parameters.AddWithValue("@CreatedBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                cmd.ExecuteNonQuery();
            }

            this.Close();
        }


        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            // Remove any non digit characters
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
