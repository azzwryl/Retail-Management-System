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
    public partial class UpdateSOForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSDb"].ConnectionString;
        private List<string> itemIdList = new List<string>();
        private List<string> itemNameList = new List<string>();
        private List<decimal> itemPriceList = new List<decimal>();
        private List<int> itemQuantityList = new List<int>();
        private string _invoiceNumber = "";
        private string _soId = "";
        private decimal _invoiceAmount = 0;
        private DateTime _invoiceDate = DateTime.Today;
        private string _invoiceStatus = "for shipping";
        private string lastInvoiceNumber = "";
        private string resultString = "";

        public UpdateSOForm(string soId, string customerId, string customerName)
        {
            InitializeComponent();

            SOUpdateCustomerIdTextBox.Text = customerId;
            SOUpdateCustomerNameTextBox.Text = customerName;

            SOUpdateItemIdComboBox.SelectedValueChanged += new EventHandler(SOUpdateItemIdComboBox_SelectedValueChanged);
            SOUpdateItemNameComboBox.SelectedValueChanged += new EventHandler(SOUpdateItemNameComboBox_SelectedValueChanged);

            decimal totalAmount = 0;
            _soId = soId;

            SOUpdateListView.FullRowSelect = true;

            //Fill out the item comboboxes.
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spSO_GetItemIdAndNameList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SOUpdateItemNameComboBox.Items.Add(dr["InvItemName"]);
                SOUpdateItemIdComboBox.Items.Add(dr["InvItemId"]);
                itemNameList.Add(dr["InvItemName"].ToString());
                itemIdList.Add(dr["InvItemId"].ToString());
                itemPriceList.Add(decimal.Parse(dr["ItemPrice"].ToString()));
                itemQuantityList.Add(Int32.Parse(dr["InvItemQuantity"].ToString()));
            }

            dr.Close();

            //Fill out the item listview.
            SqlCommand itemsCmd = new SqlCommand("dbo.spSO_GetSoItems", conn);
            itemsCmd.CommandType = CommandType.StoredProcedure;
            itemsCmd.Parameters.AddWithValue("@SOId", soId);

            SqlDataReader itemDr = itemsCmd.ExecuteReader();

            while (itemDr.Read())
            {
                decimal totalUnitPriceAndQuantity = 0;

                ListViewItem item = new ListViewItem(itemDr["ItemId"].ToString());
                item.SubItems.Add(itemDr["ItemName"].ToString());
                item.SubItems.Add(itemDr["SOQuantity"].ToString());
                item.SubItems.Add(itemDr["ItemPrice"].ToString());
                totalUnitPriceAndQuantity = Convert.ToDecimal(itemDr["SOQuantity"].ToString()) * Convert.ToDecimal(itemDr["ItemPrice"].ToString());
                item.SubItems.Add(totalUnitPriceAndQuantity.ToString());
                SOUpdateListView.Items.Add(item);
            }

            itemDr.Close();

            for (int i = 0; i < SOUpdateListView.Items.Count; i++)
            {
                totalAmount += decimal.Parse(SOUpdateListView.Items[i].SubItems[4].Text);
            }

            SOUpdateTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);
        }

        private void SOUpdateItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemNameList.IndexOf(SOUpdateItemNameComboBox.SelectedItem.ToString());
            SOUpdateItemIdComboBox.SelectedItem = itemIdList[i];
            SOUpdateUnitPriceTextBox.Text = itemPriceList[i].ToString();
            SOUpdateAvailableQtyTextBox.Text = itemQuantityList[i].ToString();
        }

        private void SOUpdateItemIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {      
            int i = itemIdList.IndexOf(SOUpdateItemIdComboBox.SelectedItem.ToString());
            SOUpdateItemNameComboBox.SelectedItem = itemNameList[i];
            SOUpdateUnitPriceTextBox.Text = itemPriceList[i].ToString();
            SOUpdateAvailableQtyTextBox.Text = itemQuantityList[i].ToString();
        }

        private void SOUpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SOUpdateInvoiceButton_Click(object sender, EventArgs e)
        {
            _invoiceAmount = decimal.Parse(SOUpdateTotalAmountTextBox.Text.ToString());
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.spInv_GetLastRecordId", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastInvoiceNumber = dr["InvoiceNumber"].ToString();
                }

                resultString = Regex.Match(lastInvoiceNumber, @"\d+").Value;

                if (resultString != "")
                {
                    i = Convert.ToInt32(resultString);
                }

                i += 1;
                _invoiceNumber = "I-" + i.ToString("D5");

                connection.Close();
            }

            //update invoice table.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("SOId", _soId);
                p.Add("SOStatus", "Invoiced");
                p.Add("InvoiceNumber", _invoiceNumber);
                connection.Execute("dbo.spInvoice_TransferSOItemsToInvoice", p, commandType: CommandType.StoredProcedure);

                var q = new DynamicParameters();
                q.Add("SOId", _soId);
                q.Add("InvoiceAmount", _invoiceAmount);
                q.Add("InvoiceStatus", _invoiceStatus);
                q.Add("InvoiceDate", _invoiceDate);
                q.Add("InvoiceNumber", _invoiceNumber);
                connection.Execute("dbo.spInvoice_UpdateInvoiceTable", q, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Sales Order " + _soId + " has been invoiced.");
            this.Close();
        }

        private void SOUpdateSaveButton_Click(object sender, EventArgs e)
        {
            string status = "Pending";
            DateTime today = DateTime.Today;
            string soId = _soId;
            byte checkInitialRun = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                //Add entries to the Sales Order table.
                SalesOrderModel soModel = new SalesOrderModel(
                    soId,
                    decimal.Parse(SOUpdateTotalAmountTextBox.Text.ToString()),
                    today,
                    status);

                var p = new DynamicParameters();
                p.Add("@SOId", soModel.SOId);
                p.Add("@SOTotalAmount", soModel.SOTotalAmount);
                p.Add("@SODate", soModel.SODate);
                p.Add("@SOStatus", soModel.SOStatus);

                connection.Execute("dbo.spSO_UpdateSO", p, commandType: CommandType.StoredProcedure);

                //Add entries to the Sales Order Item table.
                for (int j = 0; j < SOUpdateListView.Items.Count; j++)
                {
                    SalesOrderModel orderModel = new SalesOrderModel(
                        soId,
                        SOUpdateListView.Items[j].SubItems[2].Text, //Quantity
                        today,
                        status,
                        SOUpdateListView.Items[j].SubItems[0].Text, //Item Id
                        decimal.Parse(SOUpdateListView.Items[j].SubItems[3].Text), //Item Price
                        checkInitialRun);

                    var o = new DynamicParameters();

                    o.Add("@SOId", orderModel.SOId);
                    o.Add("@ItemId", orderModel.ItemId);
                    o.Add("@ItemPrice", orderModel.ItemPrice);
                    o.Add("@SOQuantity", orderModel.SOQuantity);
                    o.Add("@checkInitialRun", orderModel.CheckInitialRun);

                    connection.Execute("dbo.spSO_UpdateItemsToOrderItems", o, commandType: CommandType.StoredProcedure); //TODO - create stored procedure
                    checkInitialRun = 1;
                }


            }
        }

        private void SOUpdateAddItemButton_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            decimal totalUnitPriceAndQuantity = decimal.Parse(SOUpdateQuantityTextBox.Text) * decimal.Parse(SOUpdateUnitPriceTextBox.Text);

            ListViewItem item = new ListViewItem(SOUpdateItemIdComboBox.SelectedItem.ToString());
            item.SubItems.Add(SOUpdateItemNameComboBox.SelectedItem.ToString());
            item.SubItems.Add(SOUpdateQuantityTextBox.Text);
            item.SubItems.Add(SOUpdateUnitPriceTextBox.Text);
            item.SubItems.Add(String.Format("{0:n}", totalUnitPriceAndQuantity));
            SOUpdateListView.Items.Add(item);

            for (int i = 0; i < SOUpdateListView.Items.Count; i++)
            {
                totalAmount += decimal.Parse(SOUpdateListView.Items[i].SubItems[4].Text);
            }

            SOUpdateTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);
        }

        private void SOUpdateDeleteButton_Click(object sender, EventArgs e)
        {
            SOUpdateListView.SelectedItems[0].Remove();
        }
    }
}
