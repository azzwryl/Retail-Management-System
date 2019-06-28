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
    public partial class AddNewSOForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;
        private List<string> itemIdList = new List<string>();
        private List<string> itemNameList = new List<string>();
        private List<decimal> itemPriceList = new List<decimal>();
        private List<string> customerIdList = new List<string>();
        private List<int> itemQuantityList = new List<int>();
        private int customerIndex = 0;
        private int newInventoryQuantity = 0;

        public AddNewSOForm()
        {
            InitializeComponent();

            PopulateCustomerComboBox();
            PopulateSalesItemIdAndNameComboBox();

            SONewItemIdComboBox.SelectedValueChanged += new EventHandler(SONewItemIdComboBox_SelectedValueChanged);
            SONewItemNameComboBox.SelectedValueChanged += new EventHandler(SONewItemNameComboBox_SelectedValueChanged);
            SONewCustomerComboBox.SelectedValueChanged += new EventHandler(SONewCustomerComboBox_SelectedValueChanged);

            SONewListView.FullRowSelect = true;
        }

        private void SONewCustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            customerIndex = SONewCustomerComboBox.SelectedIndex;

            SONewCustomerIdTextBox.Text = customerIdList[customerIndex];
        }

        private void SONewItemIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemIdList.IndexOf(SONewItemIdComboBox.SelectedItem.ToString());
            SONewItemNameComboBox.SelectedItem = itemNameList[i];
            SONewUnitPriceTextBox.Text = itemPriceList[i].ToString();
            SONewAvailableQtyTextBox.Text = itemQuantityList[i].ToString();
        }

        private void SONewItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = itemNameList.IndexOf(SONewItemNameComboBox.SelectedItem.ToString());
            SONewItemIdComboBox.SelectedItem = itemIdList[i];
            SONewUnitPriceTextBox.Text = itemPriceList[i].ToString();
            SONewAvailableQtyTextBox.Text = itemQuantityList[i].ToString();
        }

        private void PopulateCustomerComboBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spSO_GetCustomerList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SONewCustomerComboBox.Items.Add(dr[1]);
                customerIdList.Add(dr[0].ToString());
            }
        }

        private void PopulateSalesItemIdAndNameComboBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spSO_GetItemIdAndNameList", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SONewItemNameComboBox.Items.Add(dr["InvItemName"]);
                SONewItemIdComboBox.Items.Add(dr["InvItemId"]);
                itemNameList.Add(dr["InvItemName"].ToString());
                itemIdList.Add(dr["InvItemId"].ToString());
                itemPriceList.Add(decimal.Parse(dr["ItemPrice"].ToString()));
                itemQuantityList.Add(Convert.ToInt32(dr["InvItemQuantity"]));
            }
        }

        private void SONewCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SOAddItemButton_Click_1(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            decimal totalUnitPriceAndQuantity = decimal.Parse(SONewQuantityTextBox.Text) * decimal.Parse(SONewUnitPriceTextBox.Text);

            if (Int32.Parse(SONewQuantityTextBox.Text.ToString()) <= Int32.Parse(SONewAvailableQtyTextBox.Text.ToString()))
            {
                newInventoryQuantity = Int32.Parse(SONewAvailableQtyTextBox.Text.ToString()) - Int32.Parse(SONewQuantityTextBox.Text.ToString());
                ListViewItem item = new ListViewItem(SONewItemIdComboBox.SelectedItem.ToString());
                item.SubItems.Add(SONewItemNameComboBox.SelectedItem.ToString());
                item.SubItems.Add(SONewQuantityTextBox.Text);
                item.SubItems.Add(SONewUnitPriceTextBox.Text);
                item.SubItems.Add(String.Format("{0:n}", totalUnitPriceAndQuantity));
                item.SubItems.Add(newInventoryQuantity.ToString());
                SONewListView.Items.Add(item);

                for (int i = 0; i < SONewListView.Items.Count; i++)
                {
                    totalAmount += decimal.Parse(SONewListView.Items[i].SubItems[4].Text);
                }

                SONewTotalAmountTextBox.Text = String.Format("{0:n}", totalAmount);
            } else
            {
                MessageBox.Show("Input quantity is greater than the available quantity. Please try again...");
            }


        }

        private void SONewSaveButton_Click(object sender, EventArgs e)
        {
            string soId = "";
            DateTime today = DateTime.Today;
            string status = "Pending";
            string lastSOId = "";
            string resultString = "";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.spSO_GetLastRecordId", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastSOId = dr["SOId"].ToString();
                }

                resultString = Regex.Match(lastSOId, @"\d+").Value;

                if (resultString != "")
                {
                    i = Convert.ToInt32(resultString);
                }

                i += 1;
                soId = "S-" + i.ToString("D5");

                connection.Close();
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                //Add entries to the Sales Order table.
                SalesOrderModel soModel = new SalesOrderModel(
                    soId,
                    SONewCustomerIdTextBox.Text,
                    SONewCustomerComboBox.SelectedItem.ToString(),
                    decimal.Parse(SONewTotalAmountTextBox.Text),
                    today,
                    status);

                var p = new DynamicParameters();

                p.Add("@SOId", soModel.SOId);
                p.Add("@SOCustomerId", soModel.SOCustomerId);
                p.Add("@SOCustomerName", soModel.SOCustomerName);
                p.Add("@SOTotalAmount", soModel.SOTotalAmount);
                p.Add("@SODate", soModel.SODate);
                p.Add("@SOStatus", soModel.SOStatus);

                connection.Execute("dbo.spSO_CreateNewSO", p, commandType: CommandType.StoredProcedure);

                //Add entries to the Sales Order Item table.
                for (int j = 0; j < SONewListView.Items.Count; j++)
                {
                    SalesOrderModel orderModel = new SalesOrderModel(
                        soId,
                        SONewListView.Items[j].SubItems[2].Text, //Quantity
                        today,
                        status,
                        SONewListView.Items[j].SubItems[0].Text, //Item Id
                        decimal.Parse(SONewListView.Items[j].SubItems[3].Text)); //Item Price

                    var o = new DynamicParameters();

                    o.Add("@SOId", orderModel.SOId);
                    o.Add("@ItemId", orderModel.ItemId);
                    o.Add("@ItemPrice", orderModel.ItemPrice);
                    o.Add("@SOQuantity", orderModel.SOQuantity);

                    connection.Execute("dbo.spSO_AddItemsToSOItems", o, commandType: CommandType.StoredProcedure); 
                }

                //Update quantity of the Inventory.
                for (int k = 0; k < SONewListView.Items.Count; k++)
                {
                    var q = new DynamicParameters();

                    q.Add("@ItemId", SONewListView.Items[k].SubItems[0].Text);
                    MessageBox.Show(SONewListView.Items[k].SubItems[5].Text.ToString());
                    q.Add("@SOQuantity", SONewListView.Items[k].SubItems[5].Text);

                    connection.Execute("dbo.spSO_UpdateInventoryQuantity", q, commandType: CommandType.StoredProcedure);
                }
            }

            MessageBox.Show(soId.ToString() + " has successfully been created.");
            this.Close();
        }

        private void SONewDeleteButton_Click(object sender, EventArgs e)
        {
            SONewListView.SelectedItems[0].Remove();
        }
    }
}
