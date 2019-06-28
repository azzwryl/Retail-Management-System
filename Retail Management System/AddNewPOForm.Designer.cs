namespace Retail_Management_System
{
    partial class AddNewPOForm
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
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.PONewVendorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PONewDisplayVendorIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PONewDeleteButton = new System.Windows.Forms.Button();
            this.PONewUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PONewListView = new System.Windows.Forms.ListView();
            this.PONewItemIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewItemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewUnitPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewTotalAmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POAddItemButton = new System.Windows.Forms.Button();
            this.PONewQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PONewItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PONewItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PONewTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PONewSaveButton = new System.Windows.Forms.Button();
            this.PONewCancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(14, 21);
            this.ItemIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(165, 27);
            this.ItemIdLabel.TabIndex = 6;
            this.ItemIdLabel.Text = "Vendor Name:";
            // 
            // PONewVendorComboBox
            // 
            this.PONewVendorComboBox.FormattingEnabled = true;
            this.PONewVendorComboBox.Location = new System.Drawing.Point(187, 14);
            this.PONewVendorComboBox.Name = "PONewVendorComboBox";
            this.PONewVendorComboBox.Size = new System.Drawing.Size(871, 34);
            this.PONewVendorComboBox.Sorted = true;
            this.PONewVendorComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vendor Id:";
            // 
            // PONewDisplayVendorIdTextBox
            // 
            this.PONewDisplayVendorIdTextBox.Enabled = false;
            this.PONewDisplayVendorIdTextBox.Location = new System.Drawing.Point(187, 62);
            this.PONewDisplayVendorIdTextBox.Name = "PONewDisplayVendorIdTextBox";
            this.PONewDisplayVendorIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.PONewDisplayVendorIdTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PONewDeleteButton);
            this.groupBox1.Controls.Add(this.PONewUnitPriceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PONewListView);
            this.groupBox1.Controls.Add(this.POAddItemButton);
            this.groupBox1.Controls.Add(this.PONewQuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PONewItemNameComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PONewItemIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 587);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // PONewDeleteButton
            // 
            this.PONewDeleteButton.Font = new System.Drawing.Font("Arial", 15F);
            this.PONewDeleteButton.Location = new System.Drawing.Point(182, 176);
            this.PONewDeleteButton.Name = "PONewDeleteButton";
            this.PONewDeleteButton.Size = new System.Drawing.Size(158, 39);
            this.PONewDeleteButton.TabIndex = 25;
            this.PONewDeleteButton.Text = "Delete Item";
            this.PONewDeleteButton.UseVisualStyleBackColor = true;
            this.PONewDeleteButton.Click += new System.EventHandler(this.PONewDeleteButton_Click);
            // 
            // PONewUnitPriceTextBox
            // 
            this.PONewUnitPriceTextBox.Enabled = false;
            this.PONewUnitPriceTextBox.Location = new System.Drawing.Point(564, 126);
            this.PONewUnitPriceTextBox.Name = "PONewUnitPriceTextBox";
            this.PONewUnitPriceTextBox.Size = new System.Drawing.Size(252, 34);
            this.PONewUnitPriceTextBox.TabIndex = 24;
            this.PONewUnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // PONewListView
            // 
            this.PONewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PONewItemIdColumnHeader,
            this.PONewItemNameColumnHeader,
            this.PONewQuantityColumnHeader,
            this.PONewUnitPriceColumnHeader,
            this.PONewTotalAmountColumnHeader});
            this.PONewListView.Location = new System.Drawing.Point(13, 235);
            this.PONewListView.Name = "PONewListView";
            this.PONewListView.Size = new System.Drawing.Size(1218, 346);
            this.PONewListView.TabIndex = 22;
            this.PONewListView.UseCompatibleStateImageBehavior = false;
            this.PONewListView.View = System.Windows.Forms.View.Details;
            // 
            // PONewItemIdColumnHeader
            // 
            this.PONewItemIdColumnHeader.Text = "ID";
            this.PONewItemIdColumnHeader.Width = 95;
            // 
            // PONewItemNameColumnHeader
            // 
            this.PONewItemNameColumnHeader.Text = "Name";
            this.PONewItemNameColumnHeader.Width = 597;
            // 
            // PONewQuantityColumnHeader
            // 
            this.PONewQuantityColumnHeader.Text = "Quantity";
            this.PONewQuantityColumnHeader.Width = 187;
            // 
            // PONewUnitPriceColumnHeader
            // 
            this.PONewUnitPriceColumnHeader.Text = "Unit Price";
            this.PONewUnitPriceColumnHeader.Width = 142;
            // 
            // PONewTotalAmountColumnHeader
            // 
            this.PONewTotalAmountColumnHeader.Text = "Total Amount";
            this.PONewTotalAmountColumnHeader.Width = 191;
            // 
            // POAddItemButton
            // 
            this.POAddItemButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POAddItemButton.Location = new System.Drawing.Point(13, 176);
            this.POAddItemButton.Name = "POAddItemButton";
            this.POAddItemButton.Size = new System.Drawing.Size(158, 39);
            this.POAddItemButton.TabIndex = 21;
            this.POAddItemButton.Text = "Add Item";
            this.POAddItemButton.UseVisualStyleBackColor = true;
            this.POAddItemButton.Click += new System.EventHandler(this.POAddItemButton_Click);
            // 
            // PONewQuantityTextBox
            // 
            this.PONewQuantityTextBox.Location = new System.Drawing.Point(151, 126);
            this.PONewQuantityTextBox.Name = "PONewQuantityTextBox";
            this.PONewQuantityTextBox.Size = new System.Drawing.Size(252, 34);
            this.PONewQuantityTextBox.TabIndex = 14;
            this.PONewQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // PONewItemNameComboBox
            // 
            this.PONewItemNameComboBox.FormattingEnabled = true;
            this.PONewItemNameComboBox.Location = new System.Drawing.Point(151, 79);
            this.PONewItemNameComboBox.Name = "PONewItemNameComboBox";
            this.PONewItemNameComboBox.Size = new System.Drawing.Size(895, 34);
            this.PONewItemNameComboBox.Sorted = true;
            this.PONewItemNameComboBox.TabIndex = 12;
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
            // PONewItemIdComboBox
            // 
            this.PONewItemIdComboBox.FormattingEnabled = true;
            this.PONewItemIdComboBox.Location = new System.Drawing.Point(151, 32);
            this.PONewItemIdComboBox.Name = "PONewItemIdComboBox";
            this.PONewItemIdComboBox.Size = new System.Drawing.Size(252, 34);
            this.PONewItemIdComboBox.TabIndex = 10;
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
            // PONewTotalAmountTextBox
            // 
            this.PONewTotalAmountTextBox.Enabled = false;
            this.PONewTotalAmountTextBox.Location = new System.Drawing.Point(222, 715);
            this.PONewTotalAmountTextBox.Name = "PONewTotalAmountTextBox";
            this.PONewTotalAmountTextBox.Size = new System.Drawing.Size(503, 34);
            this.PONewTotalAmountTextBox.TabIndex = 16;
            this.PONewTotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 722);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "PO Total Amount:";
            // 
            // PONewSaveButton
            // 
            this.PONewSaveButton.Font = new System.Drawing.Font("Arial", 15F);
            this.PONewSaveButton.Location = new System.Drawing.Point(921, 711);
            this.PONewSaveButton.Name = "PONewSaveButton";
            this.PONewSaveButton.Size = new System.Drawing.Size(158, 39);
            this.PONewSaveButton.TabIndex = 22;
            this.PONewSaveButton.Text = "Save";
            this.PONewSaveButton.UseVisualStyleBackColor = true;
            this.PONewSaveButton.Click += new System.EventHandler(this.PONewSaveButton_Click);
            // 
            // PONewCancelButton
            // 
            this.PONewCancelButton.Font = new System.Drawing.Font("Arial", 15F);
            this.PONewCancelButton.Location = new System.Drawing.Point(1085, 711);
            this.PONewCancelButton.Name = "PONewCancelButton";
            this.PONewCancelButton.Size = new System.Drawing.Size(158, 39);
            this.PONewCancelButton.TabIndex = 23;
            this.PONewCancelButton.Text = "Cancel";
            this.PONewCancelButton.UseVisualStyleBackColor = true;
            this.PONewCancelButton.Click += new System.EventHandler(this.PONewCancelButton_Click);
            // 
            // AddNewPOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 758);
            this.Controls.Add(this.PONewCancelButton);
            this.Controls.Add(this.PONewSaveButton);
            this.Controls.Add(this.PONewTotalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PONewDisplayVendorIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PONewVendorComboBox);
            this.Controls.Add(this.ItemIdLabel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddNewPOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Purchase Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.ComboBox PONewVendorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PONewDisplayVendorIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PONewQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PONewItemNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PONewItemIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button POAddItemButton;
        private System.Windows.Forms.ListView PONewListView;
        private System.Windows.Forms.ColumnHeader PONewItemIdColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewItemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewUnitPriceColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewTotalAmountColumnHeader;
        private System.Windows.Forms.TextBox PONewTotalAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PONewSaveButton;
        private System.Windows.Forms.Button PONewCancelButton;
        private System.Windows.Forms.TextBox PONewUnitPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PONewDeleteButton;
    }
}