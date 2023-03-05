using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string name = fullNameBox.Text;
            string address = addressBox.Text;
            string postalCode = postalCodeBox.Text;
            string phone = phoneNumberBox.Text;
            string cityName = cityComboBox.SelectedItem.ToString();
            
            

            int cityId;
            string getCityIDQuery = "SELECT cityID FROM city WHERE city = @CityName;";
            using (MySqlCommand cmd = new MySqlCommand(getCityIDQuery, conn))
            {
                cmd.Parameters.AddWithValue("@CityName", cityName);
                cityId = (int)cmd.ExecuteScalar();
            }

            string addressInsert = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) VALUES (@Address, '', @CityId, @PostalCode, @Phone, NOW(), @CreatedBy, @LastUpdateBy);";
            using (MySqlCommand cmd = new MySqlCommand(addressInsert, conn))
            {
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@CityId", cityId);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@CreatedBy", CurrentUser.instance.Name);
                cmd.Parameters.AddWithValue("@LastUpdateBy", CurrentUser.instance.Name);
                MessageBox.Show(CurrentUser.instance.Name);
                cmd.ExecuteNonQuery();
            }

            int addressId;
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
            {
                addressId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string customerInsert = "INSERT INTO customer (customerName, addressId) VALUES (@Name, @AddressID);";
            using (MySqlCommand cmd = new MySqlCommand(customerInsert, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@AddressID", addressId);
                cmd.ExecuteNonQuery();
            }


        }
    }
}
