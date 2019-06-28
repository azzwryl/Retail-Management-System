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
    public partial class UpdatePOForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private List<string> itemIdList = new List<string>();
        private List<string> itemNameList = new List<string>();
        private List<decimal> itemPriceList = new List<decimal>();
        private string _poId = "";
        private string _poInvoiceNumber = "";

        public UpdatePOForm(string poId, string vendorId, string vendorName)
        {
            InitializeComponent();

            POUpdateVendorNameTextBox.Text = vendorName;
            POUpdateVendorIdTextBox.Text = vendorId;

            POUpdateItemIdComboBox.SelectedValueChanged += new EventHandler(POUpdateItemIdComboBox_SelectedValueChanged);
            POUpdateItemNameComboBox.SelectedValueChanged += new EventHandler(POUpdateItemNameComboBox_SelectedValueChanged);

            decimal totalAmount = 0;
            _poId = poId;

            POUpdateListView.FullRowSelect = true;

            //Fill out the item comboboxes.
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spPO_GetItemIdAndNameList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                POUpdateItemNameComboBox.Items.Add(dr["ItemName"]);
                POUpdateItemIdComboBox.Items.Add(dr["ItemId"]);
                itemNameList.Add(dr["ItemName"].ToString());
                itemIdList.Add(dr["ItemId"].ToString());
                itemPriceList.Add(decimal.Parse(dr["ItemPrice"].ToString()));
            }

            dr.Close();

            //Fill out the item listview.
            SqlCommand itemsCmd = new SqlCommand("dbo.spPO_GetPOItems", conn);
            itemsCmd.CommandType = CommandType.StoredProcedure;
            itemsCmd.Parameters.AddWithValue("@POId", poId);

            SqlDataReader itemDr = itemsCmd.ExecuteReader();

            while (itemDr.Read())
            {
                decimal totalUnitPriceAndQuantity = 0;

                ListViewItem item = new ListViewItem(itemDr["ItemId"].ToString());
                item.SubItems.Add(itemDr["ItemName"].ToString());
                item.SubItems.Add(itemDr[2].ToString());
                item.SubItems.Add(itemDr["ItemPrice"].ToString());
                totalUnitPriceAndQuantity = Convert.ToDecimal(itemDr[2].ToString()) * Convert.ToDecimal(itemDr["ItemPrice"].ToString());
                item.SubItems.Add(totalUnitPriceAndQuantity.ToString());
                POUpdateListView.Items.Add(item);
            }

            itemDr.Close();

            for (int i = 0; i < POUpdateListView.Items.Count; i++)
            {
                totalAmount += decimal.Parse(POUpdateListView.Items[i].SubItems[4].Text);
            }
            POUpdateTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);

        }

        private void POUpdateItemIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemIdList.IndexOf(POUpdateItemIdComboBox.SelectedItem.ToString());
            POUpdateItemNameComboBox.SelectedItem = itemNameList[i];
            POUpdateUnitPriceTextBox.Text = itemPriceList[i].ToString();
        }

        private void POUpdateItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemNameList.IndexOf(POUpdateItemNameComboBox.SelectedItem.ToString());
            POUpdateItemIdComboBox.SelectedItem = itemIdList[i];
            POUpdateUnitPriceTextBox.Text = itemPriceList[i].ToString();
        }

        private void POUpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POUpdateAddItemButton_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            decimal totalUnitPriceAndQuantity = decimal.Parse(POUpdateQuantityTextBox.Text) * decimal.Parse(POUpdateUnitPriceTextBox.Text);

            ListViewItem item = new ListViewItem(POUpdateItemIdComboBox.SelectedItem.ToString());
            item.SubItems.Add(POUpdateItemNameComboBox.SelectedItem.ToString());
            item.SubItems.Add(POUpdateQuantityTextBox.Text);
            item.SubItems.Add(POUpdateUnitPriceTextBox.Text);
            item.SubItems.Add(String.Format("{0:n}", totalUnitPriceAndQuantity));
            POUpdateListView.Items.Add(item);

            for (int i = 0; i < POUpdateListView.Items.Count; i++)
            {
                totalAmount += decimal.Parse(POUpdateListView.Items[i].SubItems[4].Text);
            }

            POUpdateTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);
        }

        private void POUpdateDeleteButton_Click(object sender, EventArgs e)
        {
            POUpdateListView.SelectedItems[0].Remove();
        }

        private void POUpdateSaveButton_Click(object sender, System.EventArgs e)
        {
            string status = "Pending";
            string invoiceNumber = "-";
            DateTime today = DateTime.Today;
            string poId = _poId;
            byte checkInitialRun = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                //Add entries to the Purchase Order table.
                PurchaseOrderModel poModel = new PurchaseOrderModel(
                    poId,
                    invoiceNumber,
                    POUpdateTotalAmountTextBox.Text,
                    today,
                    status);

                var p = new DynamicParameters();
                p.Add("@POId", poModel.POId);
                p.Add("@POInvoiceNumber", poModel.POInvoiceNumber);
                p.Add("@POTotalAmount", poModel.POTotalAmount);
                p.Add("@PODate", poModel.PODate);
                p.Add("@POStatus", poModel.POStatus);

                connection.Execute("dbo.spPO_UpdatePO", p, commandType: CommandType.StoredProcedure);

                //Add entries to the Purchase Order Item table.
                for (int j = 0; j < POUpdateListView.Items.Count; j++)
                {
                    PurchaseOrderModel orderModel = new PurchaseOrderModel(
                        poId,
                        POUpdateListView.Items[j].SubItems[2].Text, //Quantity
                        today,
                        status,
                        POUpdateListView.Items[j].SubItems[0].Text, //Item Id
                        decimal.Parse(POUpdateListView.Items[j].SubItems[3].Text), //Item Price
                        checkInitialRun);

                    var o = new DynamicParameters();

                    o.Add("@POId", orderModel.POId);
                    o.Add("@ItemId", orderModel.ItemId);
                    o.Add("@ItemPrice", orderModel.ItemPrice);
                    o.Add("@POQuantity", orderModel.POQuantity);
                    o.Add("@checkInitialRun", orderModel.CheckInitialRun);

                    connection.Execute("dbo.spPO_UpdateItemsToOrderItems", o, commandType: CommandType.StoredProcedure); //TODO - create stored procedure
                    checkInitialRun = 1;
                }

                
            }
        }

        private void POUpdatePostButton_Click(object sender, EventArgs e)
        {

            using (var form = new POInvoiceNumberForm())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _poInvoiceNumber = form.POInvoiceNumberValue;

                    string location = "warehouse";

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                    {

                        for (int i = 0; i < POUpdateListView.Items.Count; i++)
                        {
                            InventoryModel invModel = new InventoryModel(
                                POUpdateListView.Items[i].SubItems[0].Text,
                                POUpdateListView.Items[i].SubItems[1].Text,
                                POUpdateListView.Items[i].SubItems[2].Text,
                                location);

                            var q = new DynamicParameters();

                            q.Add("@InvItemId", invModel.ItemId);
                            q.Add("@InvItemname", invModel.ItemName);
                            q.Add("@InvItemQuantity", invModel.InvItemQuantity);
                            q.Add("@InvItemLocation", invModel.InvItemLocation);

                            connection.Execute("dbo.spPO_PostInInventory", q, commandType: CommandType.StoredProcedure);
                        }

                        var r = new DynamicParameters();
                        r.Add("@POId", this._poId);
                        r.Add("@POStatus", "Posted");
                        r.Add("@POInvoiceNumber", this._poInvoiceNumber);
                        connection.Execute("dbo.spPO_UpdateStatus", r, commandType: CommandType.StoredProcedure);
                    }

                    MessageBox.Show("Purchase Order order has been posted.");
                    this.Close();

                    PORePopulateInventoryFromItems();
                }

                    
            }
        }

        private void PORePopulateInventoryFromItems()
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
