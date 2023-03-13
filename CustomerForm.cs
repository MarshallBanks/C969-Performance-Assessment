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
                                        "cust.createDate AS 'Created Date', " +
                                        "cust.createdBy AS 'Created By', " +
                                        "cust.lastUpdate AS 'Last Updated', " +
                                        "cust.lastUpdateBy AS 'Last Updated By' " +
                                        "FROM customer cust " +
                                        "JOIN address addr on cust.addressId = addr.addressId " +
                                        "JOIN city on city.cityId = addr.cityId;";

            MySqlCommand cmd = new MySqlCommand(getCustomerData, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable custDataTable = new DataTable();
            adapter.Fill(custDataTable);

            customerDGV.DataSource = custDataTable;
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustForm addCustForm = new AddCustForm(this);
            addCustForm.Show();
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Instance.Show();
        }
    }
}
