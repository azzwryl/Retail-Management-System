namespace Retail_Management_System
{
    partial class UpdatePOForm
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
            this.POUpdateCancelButton = new System.Windows.Forms.Button();
            this.POUpdateSaveButton = new System.Windows.Forms.Button();
            this.POUpdateTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.POUpdateDeleteButton = new System.Windows.Forms.Button();
            this.POUpdateUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.POUpdateListView = new System.Windows.Forms.ListView();
            this.PONewItemIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewItemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewUnitPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PONewTotalAmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POUpdateAddItemButton = new System.Windows.Forms.Button();
            this.POUpdateQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.POUpdateItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.POUpdateItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.POUpdateVendorIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.POUpdateVendorNameTextBox = new System.Windows.Forms.TextBox();
            this.POUpdatePostButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // POUpdateCancelButton
            // 
            this.POUpdateCancelButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POUpdateCancelButton.Location = new System.Drawing.Point(918, 708);
            this.POUpdateCancelButton.Name = "POUpdateCancelButton";
            this.POUpdateCancelButton.Size = new System.Drawing.Size(158, 39);
            this.POUpdateCancelButton.TabIndex = 32;
            this.POUpdateCancelButton.Text = "Cancel";
            this.POUpdateCancelButton.UseVisualStyleBackColor = true;
            this.POUpdateCancelButton.Click += new System.EventHandler(this.POUpdateCancelButton_Click);
            // 
            // POUpdateSaveButton
            // 
            this.POUpdateSaveButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POUpdateSaveButton.Location = new System.Drawing.Point(754, 708);
            this.POUpdateSaveButton.Name = "POUpdateSaveButton";
            this.POUpdateSaveButton.Size = new System.Drawing.Size(158, 39);
            this.POUpdateSaveButton.TabIndex = 31;
            this.POUpdateSaveButton.Text = "Save";
            this.POUpdateSaveButton.UseVisualStyleBackColor = true;
            this.POUpdateSaveButton.Click += new System.EventHandler(this.POUpdateSaveButton_Click);
            // 
            // POUpdateTotalAmountTextBox
            // 
            this.POUpdateTotalAmountTextBox.Enabled = false;
            this.POUpdateTotalAmountTextBox.Location = new System.Drawing.Point(222, 712);
            this.POUpdateTotalAmountTextBox.Name = "POUpdateTotalAmountTextBox";
            this.POUpdateTotalAmountTextBox.Size = new System.Drawing.Size(503, 34);
            this.POUpdateTotalAmountTextBox.TabIndex = 30;
            this.POUpdateTotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 719);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "PO Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.POUpdateDeleteButton);
            this.groupBox1.Controls.Add(this.POUpdateUnitPriceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.POUpdateListView);
            this.groupBox1.Controls.Add(this.POUpdateAddItemButton);
            this.groupBox1.Controls.Add(this.POUpdateQuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.POUpdateItemNameComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.POUpdateItemIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 587);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // POUpdateDeleteButton
            // 
            this.POUpdateDeleteButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POUpdateDeleteButton.Location = new System.Drawing.Point(182, 176);
            this.POUpdateDeleteButton.Name = "POUpdateDeleteButton";
            this.POUpdateDeleteButton.Size = new System.Drawing.Size(158, 39);
            this.POUpdateDeleteButton.TabIndex = 25;
            this.POUpdateDeleteButton.Text = "Delete Item";
            this.POUpdateDeleteButton.UseVisualStyleBackColor = true;
            this.POUpdateDeleteButton.Click += new System.EventHandler(this.POUpdateDeleteButton_Click);
            // 
            // POUpdateUnitPriceTextBox
            // 
            this.POUpdateUnitPriceTextBox.Enabled = false;
            this.POUpdateUnitPriceTextBox.Location = new System.Drawing.Point(564, 126);
            this.POUpdateUnitPriceTextBox.Name = "POUpdateUnitPriceTextBox";
            this.POUpdateUnitPriceTextBox.Size = new System.Drawing.Size(252, 34);
            this.POUpdateUnitPriceTextBox.TabIndex = 24;
            this.POUpdateUnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // POUpdateListView
            // 
            this.POUpdateListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PONewItemIdColumnHeader,
            this.PONewItemNameColumnHeader,
            this.PONewQuantityColumnHeader,
            this.PONewUnitPriceColumnHeader,
            this.PONewTotalAmountColumnHeader});
            this.POUpdateListView.Location = new System.Drawing.Point(13, 235);
            this.POUpdateListView.Name = "POUpdateListView";
            this.POUpdateListView.Size = new System.Drawing.Size(1218, 346);
            this.POUpdateListView.TabIndex = 22;
            this.POUpdateListView.UseCompatibleStateImageBehavior = false;
            this.POUpdateListView.View = System.Windows.Forms.View.Details;
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
            // POUpdateAddItemButton
            // 
            this.POUpdateAddItemButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POUpdateAddItemButton.Location = new System.Drawing.Point(13, 176);
            this.POUpdateAddItemButton.Name = "POUpdateAddItemButton";
            this.POUpdateAddItemButton.Size = new System.Drawing.Size(158, 39);
            this.POUpdateAddItemButton.TabIndex = 21;
            this.POUpdateAddItemButton.Text = "Add Item";
            this.POUpdateAddItemButton.UseVisualStyleBackColor = true;
            this.POUpdateAddItemButton.Click += new System.EventHandler(this.POUpdateAddItemButton_Click);
            // 
            // POUpdateQuantityTextBox
            // 
            this.POUpdateQuantityTextBox.Location = new System.Drawing.Point(151, 126);
            this.POUpdateQuantityTextBox.Name = "POUpdateQuantityTextBox";
            this.POUpdateQuantityTextBox.Size = new System.Drawing.Size(252, 34);
            this.POUpdateQuantityTextBox.TabIndex = 14;
            this.POUpdateQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // POUpdateItemNameComboBox
            // 
            this.POUpdateItemNameComboBox.FormattingEnabled = true;
            this.POUpdateItemNameComboBox.Location = new System.Drawing.Point(151, 79);
            this.POUpdateItemNameComboBox.Name = "POUpdateItemNameComboBox";
            this.POUpdateItemNameComboBox.Size = new System.Drawing.Size(895, 34);
            this.POUpdateItemNameComboBox.TabIndex = 12;
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
            // POUpdateItemIdComboBox
            // 
            this.POUpdateItemIdComboBox.FormattingEnabled = true;
            this.POUpdateItemIdComboBox.Location = new System.Drawing.Point(151, 32);
            this.POUpdateItemIdComboBox.Name = "POUpdateItemIdComboBox";
            this.POUpdateItemIdComboBox.Size = new System.Drawing.Size(252, 34);
            this.POUpdateItemIdComboBox.TabIndex = 10;
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
            // POUpdateVendorIdTextBox
            // 
            this.POUpdateVendorIdTextBox.Enabled = false;
            this.POUpdateVendorIdTextBox.Location = new System.Drawing.Point(187, 59);
            this.POUpdateVendorIdTextBox.Name = "POUpdateVendorIdTextBox";
            this.POUpdateVendorIdTextBox.Size = new System.Drawing.Size(252, 34);
            this.POUpdateVendorIdTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vendor Id:";
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(14, 18);
            this.ItemIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(165, 27);
            this.ItemIdLabel.TabIndex = 24;
            this.ItemIdLabel.Text = "Vendor Name:";
            // 
            // POUpdateVendorNameTextBox
            // 
            this.POUpdateVendorNameTextBox.Enabled = false;
            this.POUpdateVendorNameTextBox.Location = new System.Drawing.Point(187, 11);
            this.POUpdateVendorNameTextBox.Name = "POUpdateVendorNameTextBox";
            this.POUpdateVendorNameTextBox.Size = new System.Drawing.Size(870, 34);
            this.POUpdateVendorNameTextBox.TabIndex = 33;
            // 
            // POUpdatePostButton
            // 
            this.POUpdatePostButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POUpdatePostButton.Location = new System.Drawing.Point(1082, 708);
            this.POUpdatePostButton.Name = "POUpdatePostButton";
            this.POUpdatePostButton.Size = new System.Drawing.Size(158, 39);
            this.POUpdatePostButton.TabIndex = 34;
            this.POUpdatePostButton.Text = "Post";
            this.POUpdatePostButton.UseVisualStyleBackColor = true;
            this.POUpdatePostButton.Click += new System.EventHandler(this.POUpdatePostButton_Click);
            // 
            // UpdatePOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 758);
            this.Controls.Add(this.POUpdatePostButton);
            this.Controls.Add(this.POUpdateVendorNameTextBox);
            this.Controls.Add(this.POUpdateCancelButton);
            this.Controls.Add(this.POUpdateSaveButton);
            this.Controls.Add(this.POUpdateTotalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.POUpdateVendorIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemIdLabel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UpdatePOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update PO Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button POUpdateCancelButton;
        private System.Windows.Forms.Button POUpdateSaveButton;
        private System.Windows.Forms.TextBox POUpdateTotalAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button POUpdateDeleteButton;
        private System.Windows.Forms.TextBox POUpdateUnitPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView POUpdateListView;
        private System.Windows.Forms.ColumnHeader PONewItemIdColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewItemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewUnitPriceColumnHeader;
        private System.Windows.Forms.ColumnHeader PONewTotalAmountColumnHeader;
        private System.Windows.Forms.Button POUpdateAddItemButton;
        private System.Windows.Forms.TextBox POUpdateQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox POUpdateItemNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox POUpdateItemIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox POUpdateVendorIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.TextBox POUpdateVendorNameTextBox;
        private System.Windows.Forms.Button POUpdatePostButton;
    }
}