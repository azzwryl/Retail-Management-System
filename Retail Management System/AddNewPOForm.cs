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
    public partial class AddNewPOForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private List<string> itemIdList = new List<string>();
        private List<string> itemNameList = new List<string>();
        private List<decimal> itemPriceList = new List<decimal>();
        private List<string> vendorIdList = new List<string>();
        private int vendorIndex = 0;

        public AddNewPOForm()
        {
            InitializeComponent();

            PopulateVendorComboBox();
            PopulateItemIdAndNameComboBox();

            PONewItemIdComboBox.SelectedValueChanged += new EventHandler(PONewItemIdComboBox_SelectedValueChanged);
            PONewItemNameComboBox.SelectedValueChanged += new EventHandler(PONewItemNameComboBox_SelectedValueChanged);
            PONewVendorComboBox.SelectedValueChanged += new EventHandler(PONewVendorComboBox_SelectedValueChanged);

            PONewListView.FullRowSelect = true;
        }

        private void PONewVendorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            vendorIndex = PONewVendorComboBox.SelectedIndex;

            PONewDisplayVendorIdTextBox.Text = vendorIdList[vendorIndex];
        }

        private void PONewItemIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemIdList.IndexOf(PONewItemIdComboBox.SelectedItem.ToString());
            PONewItemNameComboBox.SelectedItem = itemNameList[i];
            PONewUnitPriceTextBox.Text = itemPriceList[i].ToString();
        }

        private void PONewItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemNameList.IndexOf(PONewItemNameComboBox.SelectedItem.ToString());
            PONewItemIdComboBox.SelectedItem = itemIdList[i];
            PONewUnitPriceTextBox.Text = itemPriceList[i].ToString();
        }

        private void PopulateVendorComboBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spPO_GetVendorList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PONewVendorComboBox.Items.Add(dr[1]);
                vendorIdList.Add(dr[0].ToString());
            }
        }

        private void PopulateItemIdAndNameComboBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spPO_GetItemIdAndNameList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PONewItemNameComboBox.Items.Add(dr["ItemName"]);
                PONewItemIdComboBox.Items.Add(dr["ItemId"]);
                itemNameList.Add(dr["ItemName"].ToString());
                itemIdList.Add(dr["ItemId"].ToString());
                itemPriceList.Add(decimal.Parse(dr["ItemPrice"].ToString()));
            }
        }

        private void PONewCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POAddItemButton_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            decimal totalUnitPriceAndQuantity = decimal.Parse(PONewQuantityTextBox.Text) * decimal.Parse(PONewUnitPriceTextBox.Text);

            ListViewItem item = new ListViewItem(PONewItemIdComboBox.SelectedItem.ToString());
            item.SubItems.Add(PONewItemNameComboBox.SelectedItem.ToString());
            item.SubItems.Add(PONewQuantityTextBox.Text);
            item.SubItems.Add(PONewUnitPriceTextBox.Text);
            item.SubItems.Add(String.Format("{0:n}", totalUnitPriceAndQuantity));
            PONewListView.Items.Add(item);

            for (int i = 0; i < PONewListView.Items.Count; i++)
            {
                totalAmount += decimal.Parse(PONewListView.Items[i].SubItems[4].Text);
            }

            PONewTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);
        }

        private void PONewSaveButton_Click(object sender, EventArgs e)
        {
            string poId = "";
            DateTime today = DateTime.Today;
            string status = "Pending";
            string invoiceNumber = "-";
            string lastPOId = "";
            string resultString = "";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.spPO_GetLastRecordId", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastPOId = dr["POId"].ToString();
                }

                resultString = Regex.Match(lastPOId, @"\d+").Value;

                if (resultString != "")
                {
                    i = Convert.ToInt32(resultString);
                }

                i += 1;
                poId = "P-" + i.ToString("D5");

                connection.Close();
            }
         
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                //Add entries to the Purchase Order table.
                PurchaseOrderModel poModel = new PurchaseOrderModel(
                    poId,
                    PONewDisplayVendorIdTextBox.Text,
                    PONewVendorComboBox.SelectedItem.ToString(),
                    invoiceNumber,
                    PONewTotalAmountTextBox.Text,
                    today,
                    status);

                var p = new DynamicParameters();

                p.Add("@POId", poModel.POId);
                p.Add("@POVendorId", poModel.POVendorId);
                p.Add("@POVendorName", poModel.POVendorName);
                p.Add("@POInvoiceNumber", poModel.POInvoiceNumber);
                p.Add("@POTotalAmount", poModel.POTotalAmount);
                p.Add("@PODate", poModel.PODate);
                p.Add("@POStatus", poModel.POStatus);

                connection.Execute("dbo.spPO_CreateNewPO", p, commandType: CommandType.StoredProcedure);

                //Add entries to the Purchase Order Item table.
                for (int j = 0; j < PONewListView.Items.Count; j++)
                {
                    PurchaseOrderModel orderModel = new PurchaseOrderModel(
                        poId,
                        PONewListView.Items[j].SubItems[2].Text, //Quantity
                        today,
                        status,
                        PONewListView.Items[j].SubItems[0].Text, //Item Id
                        decimal.Parse(PONewListView.Items[j].SubItems[3].Text)); //Item Price

                    var o = new DynamicParameters();

                    o.Add("@POId", orderModel.POId);
                    o.Add("@ItemId", orderModel.ItemId);
                    o.Add("@ItemPrice", orderModel.ItemPrice);
                    o.Add("@POQuantity", orderModel.POQuantity);

                    connection.Execute("dbo.spPO_AddItemsToOrderItems", o, commandType: CommandType.StoredProcedure); //TODO - create stored procedure
                }
            }

            MessageBox.Show(poId.ToString() + " has successfully been created.");
            this.Close();
        }

        private void PONewDeleteButton_Click(object sender, EventArgs e)
        {
            PONewListView.SelectedItems[0].Remove();
        }
    }
}
