using Dapper;
using Retail_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System
{
    public partial class UpdateCustomerForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private string customerId;

        public UpdateCustomerForm(ListViewItem selected)
        {
            InitializeComponent();

            customerId = selected.SubItems[0].Text.ToString();
            UpdateCustomerNameTextBox.Text = selected.SubItems[1].Text.ToString();
            UpdateCustomerExactLocationTextBox.Text = selected.SubItems[2].Text.ToString();
            UpdateCustomerCityOrTownComboBox.SelectedValue = selected.SubItems[3].Text.ToString();
            UpdateCustomerProvinceOrStateComboBox.SelectedValue = selected.SubItems[4].Text.ToString();
            UpdateCustomerCountryComboBox.SelectedValue = selected.SubItems[5].Text.ToString();
            UpdateCustomerEmailTextBox.Text = selected.SubItems[6].Text.ToString();
            UpdateCustomerContactNumberTextBox.Text = selected.SubItems[7].Text.ToString();
            UpdateCustomerContactPersonTextBox.Text = selected.SubItems[8].Text.ToString();
        }

        private void UpdateCustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomerSaveButton_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel(
                customerId,
                UpdateCustomerNameTextBox.Text,
                UpdateCustomerCountryComboBox.Text,
                UpdateCustomerProvinceOrStateComboBox.Text,
                UpdateCustomerCityOrTownComboBox.Text,
                UpdateCustomerExactLocationTextBox.Text,
                UpdateCustomerEmailTextBox.Text,
                UpdateCustomerContactNumberTextBox.Text,
                UpdateCustomerContactPersonTextBox.Text);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                var p = new DynamicParameters();

                p.Add("@CustomerId", model.CustomerId);
                p.Add("@CustomerName", model.CustomerName);
                p.Add("@CustomerExactLocation", model.CustomerAddressExactLocation);
                p.Add("@CustomerCityOrTown", model.CustomerAddressCityOrTown);
                p.Add("@CustomerProvinceOrState", model.CustomerAddressProvinceOrState);
                p.Add("@CustomerCountry", model.CustomerAddressCountry);
                p.Add("@CustomerEmail", model.CustomerEmailAddress);
                p.Add("@CustomerContactNumber", model.CustomerContactNumber);
                p.Add("@CustomerContactPerson", model.CustomerContactPerson);

                MessageBox.Show("Customer " + model.CustomerName + " has been updated.");

                connection.Execute("dbo.spCustomer_Update", p, commandType: CommandType.StoredProcedure);

            }
            this.Close();
        }
    }
}
