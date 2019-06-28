namespace Retail_Management_System
{
    partial class AddNewSOForm
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
            this.SONewCancelButton = new System.Windows.Forms.Button();
            this.SONewSaveButton = new System.Windows.Forms.Button();
            this.SONewTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SONewAvailableQtyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SONewDeleteButton = new System.Windows.Forms.Button();
            this.SONewUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SONewListView = new System.Windows.Forms.ListView();
            this.SONewItemIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewItemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewUnitPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewTotalAmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SONewInventoryQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOAddItemButton = new System.Windows.Forms.Button();
            this.SONewQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SONewItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SONewItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PONewDisplayVendorIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SONewCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.SONewCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SONewCancelButton
            // 
            this.SONewCancelButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SONewCancelButton.Location = new System.Drawing.Point(1085, 699);
            this.SONewCancelButton.Name = "SONewCancelButton";
            this.SONewCancelButton.Size = new System.Drawing.Size(158, 39);
            this.SONewCancelButton.TabIndex = 32;
            this.SONewCancelButton.Text = "Cancel";
            this.SONewCancelButton.UseVisualStyleBackColor = true;
            this.SONewCancelButton.Click += new System.EventHandler(this.SONewCancelButton_Click);
            // 
            // SONewSaveButton
            // 
            this.SONewSaveButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SONewSaveButton.Location = new System.Drawing.Point(921, 699);
            this.SONewSaveButton.Name = "SONewSaveButton";
            this.SONewSaveButton.Size = new System.Drawing.Size(158, 39);
            this.SONewSaveButton.TabIndex = 31;
            this.SONewSaveButton.Text = "Save";
            this.SONewSaveButton.UseVisualStyleBackColor = true;
            this.SONewSaveButton.Click += new System.EventHandler(this.SONewSaveButton_Click);
            // 
            // SONewTotalAmountTextBox
            // 
            this.SONewTotalAmountTextBox.Enabled = false;
            this.SONewTotalAmountTextBox.Location = new System.Drawing.Point(222, 703);
            this.SONewTotalAmountTextBox.Name = "SONewTotalAmountTextBox";
            this.SONewTotalAmountTextBox.Size = new System.Drawing.Size(503, 34);
            this.SONewTotalAmountTextBox.TabIndex = 30;
            this.SONewTotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 710);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "SO Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SONewAvailableQtyTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SONewDeleteButton);
            this.groupBox1.Controls.Add(this.SONewUnitPriceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SONewListView);
            this.groupBox1.Controls.Add(this.SOAddItemButton);
            this.groupBox1.Controls.Add(this.SONewQuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SONewItemNameComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SONewItemIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 587);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // SONewAvailableQtyTextBox
            // 
            this.SONewAvailableQtyTextBox.Enabled = false;
            this.SONewAvailableQtyTextBox.Location = new System.Drawing.Point(601, 176);
            this.SONewAvailableQtyTextBox.Name = "SONewAvailableQtyTextBox";
            this.SONewAvailableQtyTextBox.Size = new System.Drawing.Size(252, 34);
            this.SONewAvailableQtyTextBox.TabIndex = 27;
            this.SONewAvailableQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // SONewDeleteButton
            // 
            this.SONewDeleteButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SONewDeleteButton.Location = new System.Drawing.Point(182, 176);
            this.SONewDeleteButton.Name = "SONewDeleteButton";
            this.SONewDeleteButton.Size = new System.Drawing.Size(158, 39);
            this.SONewDeleteButton.TabIndex = 25;
            this.SONewDeleteButton.Text = "Delete Item";
            this.SONewDeleteButton.UseVisualStyleBackColor = true;
            this.SONewDeleteButton.Click += new System.EventHandler(this.SONewDeleteButton_Click);
            // 
            // SONewUnitPriceTextBox
            // 
            this.SONewUnitPriceTextBox.Enabled = false;
            this.SONewUnitPriceTextBox.Location = new System.Drawing.Point(601, 126);
            this.SONewUnitPriceTextBox.Name = "SONewUnitPriceTextBox";
            this.SONewUnitPriceTextBox.Size = new System.Drawing.Size(252, 34);
            this.SONewUnitPriceTextBox.TabIndex = 24;
            this.SONewUnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // SONewListView
            // 
            this.SONewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SONewItemIdColumnHeader,
            this.SONewItemNameColumnHeader,
            this.SONewQuantityColumnHeader,
            this.SONewUnitPriceColumnHeader,
            this.SONewTotalAmountColumnHeader,
            this.SONewInventoryQuantity});
            this.SONewListView.Location = new System.Drawing.Point(13, 235);
            this.SONewListView.Name = "SONewListView";
            this.SONewListView.Size = new System.Drawing.Size(1218, 346);
            this.SONewListView.TabIndex = 22;
            this.SONewListView.UseCompatibleStateImageBehavior = false;
            this.SONewListView.View = System.Windows.Forms.View.Details;
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
            // SOAddItemButton
            // 
            this.SOAddItemButton.Font = new System.Drawing.Font("Arial", 15F);
            this.SOAddItemButton.Location = new System.Drawing.Point(13, 176);
            this.SOAddItemButton.Name = "SOAddItemButton";
            this.SOAddItemButton.Size = new System.Drawing.Size(158, 39);
            this.SOAddItemButton.TabIndex = 21;
            this.SOAddItemButton.Text = "Add Item";
            this.SOAddItemButton.UseVisualStyleBackColor = true;
            this.SOAddItemButton.Click += new System.EventHandler(this.SOAddItemButton_Click_1);
            // 
            // SONewQuantityTextBox
            // 
            this.SONewQuantityTextBox.Location = new System.Drawing.Point(151, 126);
            this.SONewQuantityTextBox.Name = "SONewQuantityTextBox";
            this.SONewQuantityTextBox.Size = new System.Drawing.Size(252, 34);
            this.SONewQuantityTextBox.TabIndex = 14;
            this.SONewQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // SONewItemNameComboBox
            // 
            this.SONewItemNameComboBox.FormattingEnabled = true;
            this.SONewItemNameComboBox.Location = new System.Drawing.Point(151, 79);
            this.SONewItemNameComboBox.Name = "SONewItemNameComboBox";
            this.SONewItemNameComboBox.Size = new System.Drawing.Size(895, 34);
            this.SONewItemNameComboBox.Sorted = true;
            this.SONewItemNameComboBox.TabIndex = 12;
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
            // SONewItemIdComboBox
            // 
            this.SONewItemIdComboBox.FormattingEnabled = true;
            this.SONewItemIdComboBox.Location = new System.Drawing.Point(151, 32);
            this.SONewItemIdComboBox.Name = "SONewItemIdComboBox";
            this.SONewItemIdComboBox.Size = new System.Drawing.Size(252, 34);
            this.SONewItemIdComboBox.TabIndex = 10;
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
            this.PONewDisplayVendorIdTextBox.Location = new System.Drawing.Point(519, 207);
            this.PONewDisplayVendorIdTextBox.Name = "PONewDisplayVendorIdTextBox";
            this.PONewDisplayVendorIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.PONewDisplayVendorIdTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Id:";
            // 
            // SONewCustomerComboBox
            // 
            this.SONewCustomerComboBox.FormattingEnabled = true;
            this.SONewCustomerComboBox.Location = new System.Drawing.Point(208, 2);
            this.SONewCustomerComboBox.Name = "SONewCustomerComboBox";
            this.SONewCustomerComboBox.Size = new System.Drawing.Size(871, 34);
            this.SONewCustomerComboBox.Sorted = true;
            this.SONewCustomerComboBox.TabIndex = 25;
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(14, 9);
            this.ItemIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(193, 27);
            this.ItemIdLabel.TabIndex = 24;
            this.ItemIdLabel.Text = "Customer Name:";
            // 
            // SONewCustomerIdTextBox
            // 
            this.SONewCustomerIdTextBox.Enabled = false;
            this.SONewCustomerIdTextBox.Location = new System.Drawing.Point(208, 50);
            this.SONewCustomerIdTextBox.Name = "SONewCustomerIdTextBox";
            this.SONewCustomerIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.SONewCustomerIdTextBox.TabIndex = 33;
            this.SONewCustomerIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddNewSOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 758);
            this.Controls.Add(this.SONewCustomerIdTextBox);
            this.Controls.Add(this.SONewCancelButton);
            this.Controls.Add(this.SONewSaveButton);
            this.Controls.Add(this.SONewTotalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PONewDisplayVendorIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SONewCustomerComboBox);
            this.Controls.Add(this.ItemIdLabel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddNewSOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Sales Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SONewCancelButton;
        private System.Windows.Forms.Button SONewSaveButton;
        private System.Windows.Forms.TextBox SONewTotalAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SONewDeleteButton;
        private System.Windows.Forms.TextBox SONewUnitPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView SONewListView;
        private System.Windows.Forms.ColumnHeader SONewItemIdColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewItemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewUnitPriceColumnHeader;
        private System.Windows.Forms.ColumnHeader SONewTotalAmountColumnHeader;
        private System.Windows.Forms.Button SOAddItemButton;
        private System.Windows.Forms.TextBox SONewQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SONewItemNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SONewItemIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PONewDisplayVendorIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SONewCustomerComboBox;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.TextBox SONewCustomerIdTextBox;
        private System.Windows.Forms.TextBox SONewAvailableQtyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader SONewInventoryQuantity;
    }
}