﻿using Dapper;
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

        public UpdateItemForm(ListViewItem selectedItemlistView)
        {
            InitializeComponent();

            UpdateItemIdTextbox.Text = selectedItemlistView.SubItems[0].Text.ToString();
            UpdateItemNameTextBox.Text = selectedItemlistView.SubItems[1].Text.ToString();
            UpdateItemDescriptionTextBox.Text = selectedItemlistView.SubItems[2].Text.ToString();
            UpdateItemPriceTextBox.Text = selectedItemlistView.SubItems[3].Text.ToString();
            UpdateItemDiscountTextBox.Text = selectedItemlistView.SubItems[4].Text.ToString();
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

                MessageBox.Show("Item "+model.ItemName+" has been updated.");

                connection.Execute("dbo.spItem_Update", p, commandType: CommandType.StoredProcedure);

            }
            this.Close();            
        }
    }
}
