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
    public partial class AddNewVendorForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;

        public AddNewVendorForm()
        {
            InitializeComponent();
            NewVendorProvinceOrStateComboBox.Enabled = false;
            NewVendorCityOrTownComboBox.Enabled = false;
            NewVendorExactLocationTextBox.Enabled = false;
            NewVendorCountryComboBox.SelectedValueChanged += new EventHandler(NewVendorCountryComboBox_SelectedValueChanged);
            NewVendorProvinceOrStateComboBox.SelectedValueChanged += new EventHandler(NewVendorProvinceOrStateComboBox_SelectedValueChanged);
            NewVendorCityOrTownComboBox.SelectedValueChanged += new EventHandler(NewVendorCityOrTown_SelectedValueChanged);
        }

        private void NewVendorCountryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            NewVendorProvinceOrStateComboBox.Enabled = true;
        }

        private void NewVendorProvinceOrStateComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            NewVendorCityOrTownComboBox.Enabled = true;
        }

        private void NewVendorCityOrTown_SelectedValueChanged(object sender, EventArgs e)
        {
            NewVendorExactLocationTextBox.Enabled = true;
        }

        private void VendorNewCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendorNewSaveButton_Click(object sender, EventArgs e)
        {
            string lastVendorId = "";
            string resultString = "";
            string vendorId = "";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.spVendor_GetLastRecordId", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastVendorId = dr["VendorId"].ToString();
                }

                resultString = Regex.Match(lastVendorId, @"\d+").Value;

                if (resultString != "")
                {
                    i = Convert.ToInt32(resultString);
                }

                i += 1;
                vendorId = "V-" + i.ToString("D5");

                connection.Close();
            }

            VendorModel model = new VendorModel(
                vendorId,
                NewVendorNameTextBox.Text,
                NewVendorCountryComboBox.SelectedItem.ToString(),
                NewVendorProvinceOrStateComboBox.SelectedItem.ToString(),
                NewVendorCityOrTownComboBox.SelectedItem.ToString(),
                NewVendorExactLocationTextBox.Text,
                NewVendorEmailTextBox.Text,
                NewVendorContactNumberTextBox.Text,
                NewVendorContactPersonTextBox.Text);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();

                p.Add("@VendorId", model.VendorId);
                p.Add("@VendorName", model.VendorName);
                p.Add("@VendorAddressCountry", model.VendorAddressCountry);
                p.Add("@VendorAddressProvinceOrState", model.VendorAddressProvinceOrState);
                p.Add("@VendorAddressCityOrTown", model.VendorAddressCityOrTown);
                p.Add("@VendorAddressExactLocation", model.VendorAddressExactLocation);
                p.Add("@VendorEmailAddress", model.VendorEmailAddress);
                p.Add("@VendorContactnumber", model.VendorContactNumber);
                p.Add("@VendorContactPerson", model.VendorContactPerson);

                connection.Execute("dbo.spVendor_CreateNew", p, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Vendor " + NewVendorNameTextBox.Text + " has successfully been added.");

            this.Close();
        }
    }
}
