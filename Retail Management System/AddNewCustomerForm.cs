using Dapper;
using Retail_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System
{
    public partial class AddNewCustomerForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;

        public AddNewCustomerForm()
        {
            InitializeComponent();

            //Country has to have a value first before Province/State is to be enabled, then City/Town, then Exact Location.
            NewCustomerProvinceOrStateComboBox.Enabled = false;
            NewCustomerCityOrTownComboBox.Enabled = false;
            NewCustomerExactLocationTextBox.Enabled = false;

            NewCustomerCountryComboBox.SelectedValueChanged += new EventHandler(NewCustomerCountryComboBox_SelectedValueChanged);
            NewCustomerProvinceOrStateComboBox.SelectedValueChanged += new EventHandler(NewCustomerProvinceOrStateComboBox_SelectedValueChanged);
            NewCustomerCityOrTownComboBox.SelectedValueChanged += new EventHandler(NewCustomerCityOrTown_SelectedValueChanged);
        }

        private void NewCustomerCountryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            NewCustomerProvinceOrStateComboBox.Enabled = true;
        }

        private void NewCustomerProvinceOrStateComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            NewCustomerCityOrTownComboBox.Enabled = true;
        }

        private void NewCustomerCityOrTown_SelectedValueChanged(object sender, EventArgs e)
        {
            NewCustomerExactLocationTextBox.Enabled = true;
        }

        private void CustomerNewCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerNewSaveButton_Click(object sender, EventArgs e)
        {
            string customerId = "";
            string lastCustomerId = "";
            string resultString = "";
            int i = 0;

            //Get the last CustomerId generated and then increment by 1 for the new CustomerId.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.spCustomer_GetLastRecordId", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastCustomerId = dr["CustomerId"].ToString();
                }

                resultString = Regex.Match(lastCustomerId, @"\d+").Value;

                if (resultString != "")
                {
                    i = Convert.ToInt32(resultString);
                }

                i += 1;
                customerId = "C-" + i.ToString("D5");

                connection.Close();
            }

            CustomerModel model = new CustomerModel(
                customerId,
                NewCustomerNameTextBox.Text,
                NewCustomerCountryComboBox.SelectedItem.ToString(),
                NewCustomerProvinceOrStateComboBox.SelectedItem.ToString(),
                NewCustomerCityOrTownComboBox.SelectedItem.ToString(),
                NewCustomerExactLocationTextBox.Text,
                NewCustomerEmailTextBox.Text,
                NewCustomerContactNumberTextBox.Text,
                NewCustomerContactPersonTextBox.Text);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();

                p.Add("@CustomerId", model.CustomerId);
                p.Add("@CustomerName", model.CustomerName);
                p.Add("@CustomerAddressCountry", model.CustomerAddressCountry);
                p.Add("@CustomerAddressProvinceOrState", model.CustomerAddressProvinceOrState);
                p.Add("@CustomerAddressCityOrTown", model.CustomerAddressCityOrTown);
                p.Add("@CustomerAddressExactLocation", model.CustomerAddressExactLocation);
                p.Add("@CustomerEmailAddress", model.CustomerEmailAddress);
                p.Add("@CustomerContactNumber", model.CustomerContactNumber);
                p.Add("@CustomerContactPerson", model.CustomerContactPerson);

                connection.Execute("dbo.spCustomer_CreateNew", p, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Customer " + NewCustomerNameTextBox.Text + " has successfully been added.");

            this.Close();
        }
    }
}
