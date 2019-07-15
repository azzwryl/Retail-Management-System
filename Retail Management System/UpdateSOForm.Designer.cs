namespace Retail_Management_System
{
    partial class UpdateSOForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SOUpdateCancelButton = new System.Windows.Forms.Button();
            this.SOUpdateSaveButton = new System.Windows.Forms.Button();
            this.SOUpdateTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SOUpdateAvailableQtyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SOUpdateDeleteButton = new System.Windows.Forms.Button();
            this.SOUpdateUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SOUpdateListView = new System.Windows.Forms.ListView();
            this.SONewItemIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewItemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewUnitPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewTotalAmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewInventoryQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOUpdateAddItemButton = new System.Windows.Forms.Button();
            this.SOUpdateQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SOUpdateItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SOUpdateItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PONewDisplayVendorIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.SOUpdateCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.SOUpdateCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.SOUpdateInvoiceButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SOUpdateCancelButton
            // 
            this.SOUpdateCancelButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOUpdateCancelButton.Location = new System.Drawing.Point(919, 699);
            this.SOUpdateCancelButton.Name = "SOUpdateCancelButton";
            this.SOUpdateCancelButton.Size = new System.Drawing.Size(158, 39);
            this.SOUpdateCancelButton.TabIndex = 42;
            this.SOUpdateCancelButton.Text = "Cancel";
            this.SOUpdateCancelButton.UseVisualStyleBackColor = true;
            this.SOUpdateCancelButton.Click += new System.EventHandler(this.SOUpdateCancelButton_Click);
            // 
            // SOUpdateSaveButton
            // 
            this.SOUpdateSaveButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOUpdateSaveButton.Location = new System.Drawing.Point(755, 699);
            this.SOUpdateSaveButton.Name = "SOUpdateSaveButton";
            this.SOUpdateSaveButton.Size = new System.Drawing.Size(158, 39);
            this.SOUpdateSaveButton.TabIndex = 41;
            this.SOUpdateSaveButton.Text = "Save";
            this.SOUpdateSaveButton.UseVisualStyleBackColor = true;
            this.SOUpdateSaveButton.Click += new System.EventHandler(this.SOUpdateSaveButton_Click);
            // 
            // SOUpdateTotalAmountTextBox
            // 
            this.SOUpdateTotalAmountTextBox.Enabled = false;
            this.SOUpdateTotalAmountTextBox.Location = new System.Drawing.Point(222, 703);
            this.SOUpdateTotalAmountTextBox.Name = "SOUpdateTotalAmountTextBox";
            this.SOUpdateTotalAmountTextBox.Size = new System.Drawing.Size(503, 34);
            this.SOUpdateTotalAmountTextBox.TabIndex = 40;
            this.SOUpdateTotalAmountTextBox.Text = "0.00";
            this.SOUpdateTotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 710);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "SO Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SOUpdateAvailableQtyTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SOUpdateDeleteButton);
            this.groupBox1.Controls.Add(this.SOUpdateUnitPriceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SOUpdateListView);
            this.groupBox1.Controls.Add(this.SOUpdateAddItemButton);
            this.groupBox1.Controls.Add(this.SOUpdateQuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SOUpdateItemNameComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SOUpdateItemIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 587);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // SOUpdateAvailableQtyTextBox
            // 
            this.SOUpdateAvailableQtyTextBox.Enabled = false;
            this.SOUpdateAvailableQtyTextBox.Location = new System.Drawing.Point(601, 176);
            this.SOUpdateAvailableQtyTextBox.Name = "SOUpdateAvailableQtyTextBox";
            this.SOUpdateAvailableQtyTextBox.Size = new System.Drawing.Size(252, 34);
            this.SOUpdateAvailableQtyTextBox.TabIndex = 27;
            this.SOUpdateAvailableQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "Available Qty:";
            // 
            // SOUpdateDeleteButton
            // 
            this.SOUpdateDeleteButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOUpdateDeleteButton.Location = new System.Drawing.Point(182, 176);
            this.SOUpdateDeleteButton.Name = "SOUpdateDeleteButton";
            this.SOUpdateDeleteButton.Size = new System.Drawing.Size(158, 39);
            this.SOUpdateDeleteButton.TabIndex = 25;
            this.SOUpdateDeleteButton.Text = "Delete Item";
            this.SOUpdateDeleteButton.UseVisualStyleBackColor = true;
            this.SOUpdateDeleteButton.Click += new System.EventHandler(this.SOUpdateDeleteButton_Click);
            // 
            // SOUpdateUnitPriceTextBox
            // 
            this.SOUpdateUnitPriceTextBox.Enabled = false;
            this.SOUpdateUnitPriceTextBox.Location = new System.Drawing.Point(601, 126);
            this.SOUpdateUnitPriceTextBox.Name = "SOUpdateUnitPriceTextBox";
            this.SOUpdateUnitPriceTextBox.Size = new System.Drawing.Size(252, 34);
            this.SOUpdateUnitPriceTextBox.TabIndex = 24;
            this.SOUpdateUnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Unit Price:";
            // 
            // SOUpdateListView
            // 
            this.SOUpdateListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SONewItemIdColumnHeader,
            this.SONewItemNameColumnHeader,
            this.SONewQuantityColumnHeader,
            this.SONewUnitPriceColumnHeader,
            this.SONewTotalAmountColumnHeader,
            this.SONewInventoryQuantity});
            this.SOUpdateListView.Location = new System.Drawing.Point(13, 235);
            this.SOUpdateListView.Name = "SOUpdateListView";
            this.SOUpdateListView.Size = new System.Drawing.Size(1218, 346);
            this.SOUpdateListView.TabIndex = 22;
            this.SOUpdateListView.UseCompatibleStateImageBehavior = false;
            this.SOUpdateListView.View = System.Windows.Forms.View.Details;
            // 
            // SONewItemIdColumnHeader
            // 
            this.SONewItemIdColumnHeader.Text = "ID";
            this.SONewItemIdColumnHeader.Width = 95;
            // 
            // SONewItemNameColumnHeader
            // 
            this.SONewItemNameColumnHeader.Text = "Name";
            this.SONewItemNameColumnHeader.Width = 597;
            // 
            // SONewQuantityColumnHeader
            // 
            this.SONewQuantityColumnHeader.Text = "Quantity";
            this.SONewQuantityColumnHeader.Width = 187;
            // 
            // SONewUnitPriceColumnHeader
            // 
            this.SONewUnitPriceColumnHeader.Text = "Unit Price";
            this.SONewUnitPriceColumnHeader.Width = 142;
            // 
            // SONewTotalAmountColumnHeader
            // 
            this.SONewTotalAmountColumnHeader.Text = "Total Amount";
            this.SONewTotalAmountColumnHeader.Width = 191;
            // 
            // SONewInventoryQuantity
            // 
            this.SONewInventoryQuantity.Width = 0;
            // 
            // SOUpdateAddItemButton
            // 
            this.SOUpdateAddItemButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOUpdateAddItemButton.Location = new System.Drawing.Point(13, 176);
            this.SOUpdateAddItemButton.Name = "SOUpdateAddItemButton";
            this.SOUpdateAddItemButton.Size = new System.Drawing.Size(158, 39);
            this.SOUpdateAddItemButton.TabIndex = 21;
            this.SOUpdateAddItemButton.Text = "Add Item";
            this.SOUpdateAddItemButton.UseVisualStyleBackColor = true;
            this.SOUpdateAddItemButton.Click += new System.EventHandler(this.SOUpdateAddItemButton_Click);
            // 
            // SOUpdateQuantityTextBox
            // 
            this.SOUpdateQuantityTextBox.Location = new System.Drawing.Point(151, 126);
            this.SOUpdateQuantityTextBox.Name = "SOUpdateQuantityTextBox";
            this.SOUpdateQuantityTextBox.Size = new System.Drawing.Size(252, 34);
            this.SOUpdateQuantityTextBox.TabIndex = 14;
            this.SOUpdateQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity:";
            // 
            // SOUpdateItemNameComboBox
            // 
            this.SOUpdateItemNameComboBox.FormattingEnabled = true;
            this.SOUpdateItemNameComboBox.Location = new System.Drawing.Point(151, 79);
            this.SOUpdateItemNameComboBox.Name = "SOUpdateItemNameComboBox";
            this.SOUpdateItemNameComboBox.Size = new System.Drawing.Size(895, 34);
            this.SOUpdateItemNameComboBox.Sorted = true;
            this.SOUpdateItemNameComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item Name:";
            // 
            // SOUpdateItemIdComboBox
            // 
            this.SOUpdateItemIdComboBox.FormattingEnabled = true;
            this.SOUpdateItemIdComboBox.Location = new System.Drawing.Point(151, 32);
            this.SOUpdateItemIdComboBox.Name = "SOUpdateItemIdComboBox";
            this.SOUpdateItemIdComboBox.Size = new System.Drawing.Size(252, 34);
            this.SOUpdateItemIdComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item ID:";
            // 
            // PONewDisplayVendorIdTextBox
            // 
            this.PONewDisplayVendorIdTextBox.Enabled = false;
            this.PONewDisplayVendorIdTextBox.Location = new System.Drawing.Point(850, 364);
            this.PONewDisplayVendorIdTextBox.Name = "PONewDisplayVendorIdTextBox";
            this.PONewDisplayVendorIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.PONewDisplayVendorIdTextBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Customer Id:";
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(14, 9);
            this.ItemIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(193, 27);
            this.ItemIdLabel.TabIndex = 34;
            this.ItemIdLabel.Text = "Customer Name:";
            // 
            // SOUpdateCustomerNameTextBox
            // 
            this.SOUpdateCustomerNameTextBox.Enabled = false;
            this.SOUpdateCustomerNameTextBox.Location = new System.Drawing.Point(208, 6);
            this.SOUpdateCustomerNameTextBox.Name = "SOUpdateCustomerNameTextBox";
            this.SOUpdateCustomerNameTextBox.Size = new System.Drawing.Size(870, 34);
            this.SOUpdateCustomerNameTextBox.TabIndex = 44;
            // 
            // SOUpdateCustomerIdTextBox
            // 
            this.SOUpdateCustomerIdTextBox.Enabled = false;
            this.SOUpdateCustomerIdTextBox.Location = new System.Drawing.Point(208, 50);
            this.SOUpdateCustomerIdTextBox.Name = "SOUpdateCustomerIdTextBox";
            this.SOUpdateCustomerIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.SOUpdateCustomerIdTextBox.TabIndex = 43;
            this.SOUpdateCustomerIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SOUpdateInvoiceButton
            // 
            this.SOUpdateInvoiceButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOUpdateInvoiceButton.Location = new System.Drawing.Point(1083, 699);
            this.SOUpdateInvoiceButton.Name = "SOUpdateInvoiceButton";
            this.SOUpdateInvoiceButton.Size = new System.Drawing.Size(158, 39);
            this.SOUpdateInvoiceButton.TabIndex = 45;
            this.SOUpdateInvoiceButton.Text = "Invoice";
            this.SOUpdateInvoiceButton.UseVisualStyleBackColor = true;
            this.SOUpdateInvoiceButton.Click += new System.EventHandler(this.SOUpdateInvoiceButton_Click);
            // 
            // UpdateSOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 758);
            this.Controls.Add(this.SOUpdateInvoiceButton);
            this.Controls.Add(this.SOUpdateCustomerNameTextBox);
            this.Controls.Add(this.SOUpdateCustomerIdTextBox);
            this.Controls.Add(this.SOUpdateCancelButton);
            this.Controls.Add(this.SOUpdateSaveButton);
            this.Controls.Add(this.SOUpdateTotalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PONewDisplayVendorIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemIdLabel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateSOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSOForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SOUpdateCancelButton;
        private System.Windows.Forms.Button SOUpdateSaveButton;
        private System.Windows.Forms.TextBox SOUpdateTotalAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SOUpdateAvailableQtyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SOUpdateDeleteButton;
        private System.Windows.Forms.TextBox SOUpdateUnitPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView SOUpdateListView;
        private System.Windows.Forms.ColumnHeader SONewItemIdColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewItemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewUnitPriceColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewTotalAmountColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewInventoryQuantity;
        private System.Windows.Forms.Button SOUpdateAddItemButton;
        private System.Windows.Forms.TextBox SOUpdateQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SOUpdateItemNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SOUpdateItemIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PONewDisplayVendorIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.TextBox SOUpdateCustomerNameTextBox;
        private System.Windows.Forms.TextBox SOUpdateCustomerIdTextBox;
        private System.Windows.Forms.Button SOUpdateInvoiceButton;
    }
}