using MySqlConnector;
using static C969_Performance_Assessment.Database.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Performance_Assessment
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Logged In As: " + CurrentUser.instance.Name;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

        public void loadCustomers()
        {
            string getCustomerData = "SELECT cust.customerId AS 'Customer ID', " +
                                        "cust.customerName AS 'Customer Name', " +
                                        "addr.address AS 'Address', " +
                                        "city.city AS 'City', " +
                                        "addr.postalCode AS 'Postal Code', " +
                                        "addr.phone AS 'Phone', " +
                                        "cust.active AS 'Active', " +
                                        "cust.createDate AS 'Create Date', " +
                                        "cust.createdBy AS 'Created By', " +
                                        "cust.lastUpdate AS 'Last Update', " +
                                        "cust.lastUpdateBy AS 'Last Updated By' " +
                                        "FROM customer cust " +
                                        "JOIN address addr on cust.addressId = addr.addressId " +
                                        "JOIN city on city.cityId = addr.cityId " +
                                        "ORDER BY cust.customerId;";

            MySqlCommand cmd = new MySqlCommand(getCustomerData, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable custDataTable = new DataTable();
            adapter.Fill(custDataTable);

            // Convert datetime values to the appropriate time zone for the user
            TimeZoneInfo userTimeZone = TimeZoneInfo.Local;
            foreach (DataRow row in custDataTable.Rows)
            {
                row["Create Date"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["Create Date"], userTimeZone);
                row["Last Update"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row["Last Update"], userTimeZone);
            }

            customerDGV.DataSource = custDataTable;
            customerDGV.ClearSelection();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustForm addCustForm = new AddCustForm();
            addCustForm.ShowDialog();
            loadCustomers();
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SchedulingForm.Instance.Show();
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            if(!customerDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select the customer you wish to update", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UpdateCustForm updateCustForm = new UpdateCustForm(customerDGV.CurrentRow);
                updateCustForm.ShowDialog();
                loadCustomers();
            }
        }

        private void delCustButton_Click(object sender, EventArgs e)
        {
            if (!customerDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select the customer you wish to delete", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataGridViewRow selectedRow = customerDGV.SelectedRows[0];

                int customerId = (int)selectedRow.Cells["Customer ID"].Value;
                string customerName = (string)selectedRow.Cells["Customer Name"].Value;


                DialogResult answer = MessageBox.Show($"Are you sure you wish to delete \"{customerName}\" with Customer ID:{customerId} from the list?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    // Get the address ID to use in DELETE query
                    int addressId;
                    string getAddressId = "SELECT addressID FROM customer WHERE customerId = @CustomerId;";
                    using (MySqlCommand cmd = new MySqlCommand(getAddressId, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        addressId = (int)cmd.ExecuteScalar();
                    }
                    
                    try
                    {
                        string deleteCustomer = "DELETE FROM customer WHERE customerId = @CustomerId; DELETE FROM address WHERE addressId = @AddressId;";
                        using (MySqlCommand cmd = new MySqlCommand(deleteCustomer, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            cmd.Parameters.AddWithValue("@AddressId", addressId);
                            cmd.ExecuteNonQuery();
                        }

                        this.loadCustomers();
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1451)
                        {
                            MessageBox.Show($"Cannot delete customer because there are one or more appointments assigned to this customer. (Customer ID: {customerId}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred while deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }


            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SchedulingForm.Instance.Show();
        }
    }
}
