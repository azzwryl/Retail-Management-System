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
    public partial class RMSForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSdb"].ConnectionString;

        public RMSForm()
        {
            InitializeComponent();

            RMSTabControl.DrawItem += new DrawItemEventHandler(RMSTabControl_DrawItem); //Arranges the tab control headers vertically.
            FormatAllColumnHeaders(); //Formats the listview column headers.
            ItemSearchTextBox.KeyDown += ItemSearchTextBox_EnterPressed; //Search function for the ItemListView.
            PopulateAllListViews(); //Populate all the listviews from the database.
            InvShowCheckBox.CheckedChanged += InvShowCheckBox_CheckedChanged; //Inventory show/hide disabled checkbox
        }

        //Populate listviews.
        private void PopulateAllListViews()
        {
            PopulateItemListView();
            PopulateCustomerListView();
            PopulateVendorListView();
            PopulatePOListView();
            PopulateInventoryFromItems();
            PopulateInventoryListView();
            PopulateSOListView();
            PopulateInvoiceListView();
        } //calls all the populate listview functions.
        private void PopulateItemListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spItem_GetAll", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                bool isChecked = (bool)dr["ItemDisabled"];
                string status;

                if (isChecked)
                {
                    status = "Disabled";
                }
                else

                {
                    status = "Enabled";
                }

                if (ItemShowDisabledCheckBox.Checked)
                {
                    ListViewItem item = new ListViewItem(dr["ItemId"].ToString());
                    item.SubItems.Add(dr["ItemName"].ToString());
                    item.SubItems.Add(dr["ItemDescription"].ToString());
                    item.SubItems.Add(String.Format("{0:n}", dr["ItemPrice"]));
                    item.SubItems.Add(dr["ItemDiscount"].ToString());
                    item.SubItems.Add(status);
                    ItemListView.Items.Add(item);
                }
                else
                {
                    if (status == "Enabled")
                    {
                        ListViewItem item = new ListViewItem(dr["ItemId"].ToString());
                        item.SubItems.Add(dr["ItemName"].ToString());
                        item.SubItems.Add(dr["ItemDescription"].ToString());
                        item.SubItems.Add(String.Format("{0:n}", dr["ItemPrice"]));
                        item.SubItems.Add(dr["ItemDiscount"].ToString());
                        item.SubItems.Add(status);
                        ItemListView.Items.Add(item);
                    }
                }
            }

            dr.Close();
            conn.Close();

        }
        private void PopulateCustomerListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spCustomer_GetAll", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                /**
                 * TODO - inactive Customers
                 * **/

                ListViewItem customer = new ListViewItem(dr["CustomerId"].ToString());
                customer.SubItems.Add(dr["CustomerName"].ToString());
                customer.SubItems.Add(dr["CustomerAddressExactLocation"].ToString());
                customer.SubItems.Add(dr["CustomerAddressCityOrTown"].ToString());
                customer.SubItems.Add(dr["CustomerAddressProvinceOrState"].ToString());
                customer.SubItems.Add(dr["CustomerAddressCountry"].ToString());
                customer.SubItems.Add(dr["CustomerEmailAddress"].ToString());
                customer.SubItems.Add(dr["CustomerContactNumber"].ToString());
                customer.SubItems.Add(dr["CustomerContactPerson"].ToString());
                CustomerListView.Items.Add(customer);
            }

            dr.Close();
            conn.Close();
        }
        private void PopulateVendorListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spVendor_GetAll", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //TODO - inactive Vendors

                ListViewItem vendor = new ListViewItem(dr["VendorId"].ToString());
                vendor.SubItems.Add(dr["VendorName"].ToString());
                vendor.SubItems.Add(dr["VendorAddressExactLocation"].ToString());
                vendor.SubItems.Add(dr["VendorAddressCityOrTown"].ToString());
                vendor.SubItems.Add(dr["VendorAddressProvinceOrState"].ToString());
                vendor.SubItems.Add(dr["VendorAddressCountry"].ToString());
                vendor.SubItems.Add(dr["VendorEmailAddress"].ToString());
                vendor.SubItems.Add(dr["VendorContactNumber"].ToString());
                vendor.SubItems.Add(dr["VendorContactPerson"].ToString());
                VendorListView.Items.Add(vendor);
            }
        }
        private void PopulatePOListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spPO_GetAll", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem po = new ListViewItem(dr["POId"].ToString());
                po.SubItems.Add(dr["POVendorId"].ToString());
                po.SubItems.Add(dr["POVendorName"].ToString());
                po.SubItems.Add(dr["POInvoiceNumber"].ToString());
                po.SubItems.Add(String.Format("{0:n}", dr["POTotalAmount"]));
                po.SubItems.Add(dr["PODate"].ToString().Split()[0]);
                po.SubItems.Add(dr["POStatus"].ToString());
                POListView.Items.Add(po);

            }

            dr.Close();
            conn.Close();
        }
        private void PopulateSOListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spSO_GetAll", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem so = new ListViewItem(dr["SOId"].ToString());
                so.SubItems.Add(dr["SOCustomerId"].ToString());
                so.SubItems.Add(dr["SOCustomerName"].ToString());
                so.SubItems.Add(String.Format("{0:n}", dr["SOTotalAmount"]));
                so.SubItems.Add(dr["SODate"].ToString().Split()[0]);
                so.SubItems.Add(dr["SOStatus"].ToString());
                SOListView.Items.Add(so);
            }

            conn.Close();
        }
        private void PopulateInvoiceListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spInvoice_GetAll", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem invoiceItem = new ListViewItem(dr["InvoiceNumber"].ToString());
                invoiceItem.SubItems.Add(dr["SOId"].ToString());
                invoiceItem.SubItems.Add(dr["SOCustomerName"].ToString());
                invoiceItem.SubItems.Add(String.Format("{0:n}", dr["InvoiceAmount"]));
                invoiceItem.SubItems.Add(dr["InvoiceDate"].ToString().Split()[0]);
                invoiceItem.SubItems.Add(dr["InvoiceStatus"].ToString());
                InvoiceListView.Items.Add(invoiceItem);
            }

            conn.Close();
        }
        private void PopulateInventoryListView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spInv_GetAll", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem inv = new ListViewItem(dr["InvItemId"].ToString());
                inv.SubItems.Add(dr["InvItemName"].ToString());
                inv.SubItems.Add(dr["InvItemQuantity"].ToString());
                inv.SubItems.Add(dr["InvItemLocation"].ToString());
                InventoryListView.Items.Add(inv);
            }

            conn.Close();
        }
        private void PopulateInventoryFromItems()
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

        //Format columnheaders
        private void FormatAllColumnHeaders()
        {
            ItemListView_FormatColumnHeader();
            CustomerListView_FormatColumnHeader();
            VendorListView_FormatColumnHeader();
            POListView_FormatColumnHeader();
            SOListView_FormatColumnHeader();
            InventoryListView_FormatColumnHeader();
        } //calls all the format columnheader functions.
        private void ItemListView_FormatColumnHeader()
        {
            ItemListView.FullRowSelect = true;

            ItemListView.Width = 1115;
            ItemListView.Location = new System.Drawing.Point(10, 90);

            ItemIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            ItemIdColumnHeader.Width = 150;

            ItemNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            ItemNameColumnHeader.Width = 400;

            ItemDescriptionColumnHeader.TextAlign = HorizontalAlignment.Left;
            ItemDescriptionColumnHeader.Width = 500;

            ItemPriceColumnHeader.TextAlign = HorizontalAlignment.Right;
            ItemPriceColumnHeader.Width = 155;

            ItemDiscountColumnHeader.TextAlign = HorizontalAlignment.Right;
            ItemDiscountColumnHeader.Width = 100;

            ItemDisabledColumnHeader.TextAlign = HorizontalAlignment.Left;
            ItemDisabledColumnHeader.Width = 80;
        }
        private void CustomerListView_FormatColumnHeader()
        {
            CustomerListView.Scrollable = true;
            CustomerListView.FullRowSelect = true;

            CustomerListView.Width = 1115;
            CustomerListView.Location = new System.Drawing.Point(10, 90);

            CustomerIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerIdColumnHeader.Width = 100;

            CustomerNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerNameColumnHeader.Width = 300;

            CustomerAddressColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerAddressColumnHeader.Width = 300;

            CustomerCityOrTownColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerCityOrTownColumnHeader.Width = 100;

            CustomerProvinceOrStateColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerProvinceOrStateColumnHeader.Width = 130;

            CustomerCountryColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerCountryColumnHeader.Width = 100;

            CustomerEmailColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerEmailColumnHeader.Width = 150;

            CustomerContactNumberColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerContactNumberColumnHeader.Width = 150;

            CustomerContactPersonColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerContactPersonColumnHeader.Width = 150;

            CustomerStatusColumnHeader.TextAlign = HorizontalAlignment.Left;
            CustomerStatusColumnHeader.Width = 100;
        }
        private void VendorListView_FormatColumnHeader()
        {
            VendorListView.Scrollable = true;
            VendorListView.FullRowSelect = true;

            VendorListView.Width = 1115;
            VendorListView.Location = new System.Drawing.Point(10, 90);

            VendorIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorIdColumnHeader.Width = 100;

            VendorNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorNameColumnHeader.Width = 300;

            VendorAddressColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorAddressColumnHeader.Width = 300;

            VendorCityOrTownColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorCityOrTownColumnHeader.Width = 100;

            VendorProvinceOrStateColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorProvinceOrStateColumnHeader.Width = 130;

            VendorCountryColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorCountryColumnHeader.Width = 100;

            VendorEmailColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorEmailColumnHeader.Width = 150;

            VendorContactNumberColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorContactNumberColumnHeader.Width = 150;

            VendorContactPersonColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorContactPersonColumnHeader.Width = 150;

            VendorStatusColumnHeader.TextAlign = HorizontalAlignment.Left;
            VendorStatusColumnHeader.Width = 100;
        }
        private void POListView_FormatColumnHeader()
        {
            POListView.FullRowSelect = true;

            POListView.Width = 1115;
            POListView.Location = new System.Drawing.Point(10, 90);

            POIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            POIdColumnHeader.Width = 100;

            POVendorIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            POVendorIdColumnHeader.Width = 100;

            POVendorNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            POVendorNameColumnHeader.Width = 400;

            POInvoiceColumnHeader.TextAlign = HorizontalAlignment.Left;
            POInvoiceColumnHeader.Width = 200;

            POTotalAmountColumnHeader.TextAlign = HorizontalAlignment.Left;
            POTotalAmountColumnHeader.Width = 300;

            PODateColumnHeader.TextAlign = HorizontalAlignment.Left;
            PODateColumnHeader.Width = 150;

            POStatusColumnHeader.TextAlign = HorizontalAlignment.Left;
            POStatusColumnHeader.Width = 100;
        }
        private void SOListView_FormatColumnHeader()
        {
            SOListView.FullRowSelect = true;

            SOListView.Width = 1115;
            SOListView.Location = new System.Drawing.Point(10, 90);

            SOIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            SOIdColumnHeader.Width = 100;

            SOCusIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            SOCusIdColumnHeader.Width = 120;

            SOCusNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            SOCusNameColumnHeader.Width = 400;

            SOTotalAmountColumnHeader.TextAlign = HorizontalAlignment.Left;
            SOTotalAmountColumnHeader.Width = 300;

            SODateColumnHeader.TextAlign = HorizontalAlignment.Left;
            SODateColumnHeader.Width = 150;

            SOStatusColumnHeader.TextAlign = HorizontalAlignment.Left;
            SOStatusColumnHeader.Width = 100;
        }
        private void InventoryListView_FormatColumnHeader()
        {
            InventoryListView.FullRowSelect = true;

            InventoryListView.Width = 1115;
            InventoryListView.Location = new System.Drawing.Point(10, 90);

            InvItemIdColumnHeader.TextAlign = HorizontalAlignment.Left;
            InvItemIdColumnHeader.Width = 200;

            InvItemNameColumnHeader.TextAlign = HorizontalAlignment.Left;
            InvItemNameColumnHeader.Width = 600;

            InvItemQuantityColumnHeader.TextAlign = HorizontalAlignment.Left;
            InvItemQuantityColumnHeader.Width = 200;

            InvItemLocationColumnHeader.TextAlign = HorizontalAlignment.Left;
            InvItemLocationColumnHeader.Width = 500;
        }

        //Refresh buttons.
        private void InventoryRefreshButton_Click(object sender, EventArgs e)
        {
            if (InvShowCheckBox.Checked == true)
            {
                InventoryListView.Items.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.spInv_GetAllWithQuantity", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem inv = new ListViewItem(dr["InvItemId"].ToString());
                    inv.SubItems.Add(dr["InvItemName"].ToString());
                    inv.SubItems.Add(dr["InvItemQuantity"].ToString());
                    inv.SubItems.Add(dr["InvItemLocation"].ToString());
                    InventoryListView.Items.Add(inv);
                }
            }
            else
            {
                InventoryListView.Items.Clear();
                PopulateInventoryListView();
            }
        }
        private void PORefreshButton_Click(object sender, EventArgs e)
        {
            POListView.Items.Clear();
            PopulatePOListView();
        }
        private void SORefreshButton_Click(object sender, EventArgs e)
        {
            SOListView.Items.Clear();
            PopulateSOListView();
        }
        private void VendorRefreshButton_Click(object sender, EventArgs e)
        {
            VendorListView.Items.Clear();
            PopulateVendorListView();
        }
        private void CustomerRefreshButton_Click(object sender, EventArgs e)
        {
            CustomerListView.Items.Clear();
            PopulateCustomerListView();
        }
        private void ItemRefreshButton_Click(object sender, EventArgs e)
        {
            ItemListView.Items.Clear();
            PopulateItemListView();
        }

        //Add New buttons.
        private void ItemAddItemButton_Click(object sender, EventArgs e)
        {
            AddNewItemForm form = new AddNewItemForm();
            form.Show();
        }
        private void VendorAddNewButton_Click(object sender, EventArgs e)
        {
            AddNewVendorForm form = new AddNewVendorForm();
            form.Show();
        }
        private void CustomerAddNewButton_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm form = new AddNewCustomerForm();
            form.Show();
        }
        private void POAddNewButton_Click(object sender, EventArgs e)
        {
            AddNewPOForm form = new AddNewPOForm();
            form.Show();
        }
        private void SOAddSOButton_Click(object sender, EventArgs e)
        {
            AddNewSOForm form = new AddNewSOForm();
            form.Show();
        }

        //Update buttons.
        private void ItemUpdateButton_Click(object sender, EventArgs e)
        {
            if (ItemListView.SelectedItems.Count > 0)
            {
                UpdateItemForm form = new UpdateItemForm(ItemListView.SelectedItems[0]);
                form.Show();
            } else
            {
                MessageBox.Show("Please choose an item.", "Error:");
            }
        }
        private void CustomerUpdateButton_Click(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems.Count > 0)
            {
                UpdateCustomerForm form = new UpdateCustomerForm(CustomerListView.SelectedItems[0]);
                form.Show();
            } else
            {
                MessageBox.Show("Please choose a customer.", "Error:");
            }
        }
        private void VendorUpdateButton_Click(object sender, EventArgs e)
        {
            if (VendorListView.SelectedItems.Count > 0)
            {
                UpdateVendorForm form = new UpdateVendorForm(VendorListView.SelectedItems[0]);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please choose a vendor.", "Error:");
            }
        }
        private void POUpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePOForm form = new UpdatePOForm(POListView.SelectedItems[0].SubItems[0].Text,
                POListView.SelectedItems[0].SubItems[1].Text, POListView.SelectedItems[0].SubItems[2].Text);
            form.Text = POListView.SelectedItems[0].SubItems[0].Text + " - PO Update Form";
            form.Show();
        }
        private void SOUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateSOForm form = new UpdateSOForm(SOListView.SelectedItems[0].SubItems[0].Text,
                                                 SOListView.SelectedItems[0].SubItems[1].Text,
                                                 SOListView.SelectedItems[0].SubItems[2].Text);
            form.Show();
        }

        //Checkboxes.
        private void ItemShowDisabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ItemListView.Items.Clear();
            PopulateItemListView();
        }
        private void InvShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InvShowCheckBox.Checked == true)
            {
                InventoryListView.Items.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.spInv_GetAllWithQuantity", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem inv = new ListViewItem(dr["InvItemId"].ToString());
                    inv.SubItems.Add(dr["InvItemName"].ToString());
                    inv.SubItems.Add(dr["InvItemQuantity"].ToString());
                    inv.SubItems.Add(dr["InvItemLocation"].ToString());
                    InventoryListView.Items.Add(inv);
                }

                conn.Close();
            }
            else
            {
                InventoryListView.Items.Clear();
                PopulateInventoryListView();
            }
        }

        //Search function.
        private void ItemSearchTextBox_EnterPressed(object sender, KeyEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.spItem_Search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ItemSearchValue", ItemSearchTextBox.Text);

            if (ItemSearchTextBox.Text != "")
            {
                if (e.KeyData == Keys.Enter)
                {
                    ItemListView.Items.Clear();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        bool isChecked = (bool)dr["ItemDisabled"];
                        string status;

                        if (isChecked)
                        {
                            status = "Disabled";
                        }
                        else

                        {
                            status = "Enabled";
                        }
                        if (ItemShowDisabledCheckBox.Checked)
                        {
                            ListViewItem item = new ListViewItem(dr["ItemId"].ToString());
                            item.SubItems.Add(dr["ItemName"].ToString());
                            item.SubItems.Add(dr["ItemDescription"].ToString());
                            item.SubItems.Add(String.Format("0:n", dr["ItemPrice"]));
                            item.SubItems.Add(dr["ItemDiscount"].ToString());
                            item.SubItems.Add(status);
                            ItemListView.Items.Add(item);
                        }
                        else
                        {
                            if (status == "Enabled")
                            {
                                ListViewItem item = new ListViewItem(dr["ItemId"].ToString());
                                item.SubItems.Add(dr["ItemName"].ToString());
                                item.SubItems.Add(dr["ItemDescription"].ToString());
                                item.SubItems.Add(String.Format("{0:n}", dr["ItemPrice"]));
                                item.SubItems.Add(dr["ItemDiscount"].ToString());
                                item.SubItems.Add(status);
                                ItemListView.Items.Add(item);
                            }
                        }
                    }
                    dr.Close();
                }
            }

            if (e.KeyData == Keys.Enter && ItemSearchTextBox.Text == "")
            {
                ItemListView.Items.Clear();
                PopulateItemListView();
            }

            conn.Close();
        }

        //Arranges Tab control.
        private void RMSTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = RMSTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = RMSTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.LightGray);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 14.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


    }
}
