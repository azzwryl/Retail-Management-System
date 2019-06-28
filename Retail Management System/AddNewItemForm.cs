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
    public partial class AddNewItemForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;

        public AddNewItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            ItemModel model = new ItemModel(
                NewItemIdTextbox.Text,
                NewItemNameTextBox.Text,
                NewItemDescriptionTextBox.Text,
                NewItemPriceTextBox.Text,
                NewItemDiscountTextBox.Text);

            //NOTE: ItemDisabled is set as 0 by default in dbo.spItem_CreateNew store procedure.

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                var p = new DynamicParameters();

                p.Add(@"ItemId", model.ItemId);
                p.Add(@"ItemName", model.ItemName);
                p.Add(@"ItemDescription", model.ItemDescription);
                p.Add(@"ItemPrice", model.ItemPrice);
                p.Add(@"ItemDiscount", model.ItemDiscount);

                connection.Execute("dbo.spItem_CreateNew", p, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Item " + NewItemNameTextBox.Text + "has successfully been added.");

            NewItemIdTextbox.Text = "";
            NewItemNameTextBox.Text = "";
            NewItemDescriptionTextBox.Text = "";
            NewItemPriceTextBox.Text = "";
            NewItemDiscountTextBox.Text = "";

            RePopulateInventoryFromItems();
        }

        private void RePopulateInventoryFromItems()
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("spInv_GetFromItem", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
