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
    public partial class UpdateVendorForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private string vendorId;

        public UpdateVendorForm(ListViewItem selected)
        {
            InitializeComponent();

            vendorId = selected.SubItems[0].Text.ToString();
            UpdateVendorNameTextBox.Text = selected.SubItems[1].Text.ToString();
            UpdateVendorExactLocationTextBox.Text = selected.SubItems[2].Text.ToString();
            UpdateVendorCityOrTownComboBox.SelectedValue = selected.SubItems[3].Text.ToString();
            UpdateVendorProvinceOrStateComboBox.SelectedValue = selected.SubItems[4].Text.ToString();
            UpdateVendorCountryComboBox.SelectedValue = selected.SubItems[5].Text.ToString();
            UpdateVendorEmailTextBox.Text = selected.SubItems[6].Text.ToString();
            UpdateVendorContactNumberTextBox.Text = selected.SubItems[7].Text.ToString();
            UpdateVendorContactPersonTextBox.Text = selected.SubItems[8].Text.ToString();
        }

        private void UpdateVendorCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateVendorSaveButton_Click(object sender, EventArgs e)
        {
            VendorModel model = new VendorModel(
                vendorId,
                UpdateVendorNameTextBox.Text,
                UpdateVendorCountryComboBox.Text,
                UpdateVendorProvinceOrStateComboBox.Text,
                UpdateVendorCityOrTownComboBox.Text,
                UpdateVendorExactLocationTextBox.Text,
                UpdateVendorEmailTextBox.Text,
                UpdateVendorContactNumberTextBox.Text,
                UpdateVendorContactPersonTextBox.Text);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                var p = new DynamicParameters();

                p.Add("@VendorId", model.VendorId);
                p.Add("@VendorName", model.VendorName);
                p.Add("@VendorExactLocation", model.VendorAddressExactLocation);
                p.Add("@VendorCityOrTown", model.VendorAddressCityOrTown);
                p.Add("@VendorProvinceOrState", model.VendorAddressProvinceOrState);
                p.Add("@VendorCountry", model.VendorAddressCountry);
                p.Add("@VendorEmail", model.VendorEmailAddress);
                p.Add("@VendorContactNumber", model.VendorContactNumber);
                p.Add("@VendorContactPerson", model.VendorContactPerson);

                MessageBox.Show("Vendor " + model.VendorName + " has been updated.");

                connection.Execute("dbo.spVendor_Update", p, commandType: CommandType.StoredProcedure);

            }
            this.Close();
        }
    }
}
