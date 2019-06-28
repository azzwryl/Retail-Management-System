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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System
{
    public partial class UpdateItemForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private string selectedItem;

        public UpdateItemForm(string s)
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spItem_GetSelectedItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SelectedItem", s);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UpdateItemIdTextbox.Text = dr["ItemId"].ToString();
                UpdateItemNameTextBox.Text = dr["ItemName"].ToString();
                UpdateItemDescriptionTextBox.Text = dr["ItemDescription"].ToString();
                UpdateItemPriceTextBox.Text = dr["ItemPrice"].ToString();
                UpdateItemDiscountTextBox.Text = dr["ItemDiscount"].ToString();

                if(dr["ItemDisabled"].ToString() == "True")
                {
                    UpdateItemCheckBox.Checked = true;
                }
                
            }

            dr.Close();
            conn.Close();
            selectedItem = s;
        }

        private void UpdateItemCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Updates the selected item after clicking on the update button.
        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            ItemModel model = new ItemModel(
                UpdateItemIdTextbox.Text,
                UpdateItemNameTextBox.Text,
                UpdateItemDescriptionTextBox.Text,
                UpdateItemPriceTextBox.Text,
                UpdateItemDiscountTextBox.Text);

            if (UpdateItemCheckBox.Checked)
            {
                model.ItemDisabled = "1";
            } else
            {
                model.ItemDisabled = "0";
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                var p = new DynamicParameters();

                p.Add("@ItemId", model.ItemId);
                p.Add("@ItemName", model.ItemName);
                p.Add("@ItemDescription", model.ItemDescription);
                p.Add("@ItemPrice", model.ItemPrice);
                p.Add("@ItemDiscount", model.ItemDiscount);
                p.Add("@ItemDisabled", model.ItemDisabled);
                p.Add("@SelectedItem", dbType: DbType.String, value: selectedItem, direction: ParameterDirection.Input);

                MessageBox.Show("Item "+model.ItemDisabled+" has been updated.");

                connection.Execute("dbo.spItem_Update", p, commandType: CommandType.StoredProcedure);

            }
            this.Close();            
        }
    }
}
