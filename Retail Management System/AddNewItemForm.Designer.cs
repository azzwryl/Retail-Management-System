namespace Retail_Management_System
{
    partial class AddNewItemForm
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
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.ItemDiscountLabel = new System.Windows.Forms.Label();
            this.NewItemIdTextbox = new System.Windows.Forms.TextBox();
            this.NewItemNameTextBox = new System.Windows.Forms.TextBox();
            this.NewItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NewItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.NewItemDiscountTextBox = new System.Windows.Forms.TextBox();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(21, 21);
            this.ItemIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(95, 27);
            this.ItemIdLabel.TabIndex = 0;
            this.ItemIdLabel.Text = "Item ID:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(21, 66);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(135, 27);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Item Name:";
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(21, 117);
            this.ItemDescriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(139, 27);
            this.ItemDescriptionLabel.TabIndex = 2;
            this.ItemDescriptionLabel.Text = "Description:";
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.AutoSize = true;
            this.ItemPriceLabel.Location = new System.Drawing.Point(21, 171);
            this.ItemPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(73, 27);
            this.ItemPriceLabel.TabIndex = 3;
            this.ItemPriceLabel.Text = "Price:";
            // 
            // ItemDiscountLabel
            // 
            this.ItemDiscountLabel.AutoSize = true;
            this.ItemDiscountLabel.Location = new System.Drawing.Point(21, 223);
            this.ItemDiscountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemDiscountLabel.Name = "ItemDiscountLabel";
            this.ItemDiscountLabel.Size = new System.Drawing.Size(113, 27);
            this.ItemDiscountLabel.TabIndex = 4;
            this.ItemDiscountLabel.Text = "Discount:";
            // 
            // NewItemIdTextbox
            // 
            this.NewItemIdTextbox.Location = new System.Drawing.Point(166, 14);
            this.NewItemIdTextbox.Name = "NewItemIdTextbox";
            this.NewItemIdTextbox.Size = new System.Drawing.Size(252, 34);
            this.NewItemIdTextbox.TabIndex = 5;
            // 
            // NewItemNameTextBox
            // 
            this.NewItemNameTextBox.Location = new System.Drawing.Point(166, 59);
            this.NewItemNameTextBox.Name = "NewItemNameTextBox";
            this.NewItemNameTextBox.Size = new System.Drawing.Size(789, 34);
            this.NewItemNameTextBox.TabIndex = 6;
            // 
            // NewItemDescriptionTextBox
            // 
            this.NewItemDescriptionTextBox.Location = new System.Drawing.Point(166, 110);
            this.NewItemDescriptionTextBox.Name = "NewItemDescriptionTextBox";
            this.NewItemDescriptionTextBox.Size = new System.Drawing.Size(789, 34);
            this.NewItemDescriptionTextBox.TabIndex = 7;
            // 
            // NewItemPriceTextBox
            // 
            this.NewItemPriceTextBox.Location = new System.Drawing.Point(166, 164);
            this.NewItemPriceTextBox.Name = "NewItemPriceTextBox";
            this.NewItemPriceTextBox.Size = new System.Drawing.Size(252, 34);
            this.NewItemPriceTextBox.TabIndex = 8;
            this.NewItemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewItemDiscountTextBox
            // 
            this.NewItemDiscountTextBox.Location = new System.Drawing.Point(166, 216);
            this.NewItemDiscountTextBox.Name = "NewItemDiscountTextBox";
            this.NewItemDiscountTextBox.Size = new System.Drawing.Size(252, 34);
            this.NewItemDiscountTextBox.TabIndex = 9;
            this.NewItemDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItemButton.Location = new System.Drawing.Point(366, 288);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(110, 52);
            this.AddNewItemButton.TabIndex = 10;
            this.AddNewItemButton.Text = "ADD";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNewItemButton);
            this.Controls.Add(this.NewItemDiscountTextBox);
            this.Controls.Add(this.NewItemPriceTextBox);
            this.Controls.Add(this.NewItemDescriptionTextBox);
            this.Controls.Add(this.NewItemNameTextBox);
            this.Controls.Add(this.NewItemIdTextbox);
            this.Controls.Add(this.ItemDiscountLabel);
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.ItemDescriptionLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemIdLabel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddNewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Label ItemPriceLabel;
        private System.Windows.Forms.Label ItemDiscountLabel;
        private System.Windows.Forms.TextBox NewItemIdTextbox;
        private System.Windows.Forms.TextBox NewItemNameTextBox;
        private System.Windows.Forms.TextBox NewItemDescriptionTextBox;
        private System.Windows.Forms.TextBox NewItemPriceTextBox;
        private System.Windows.Forms.TextBox NewItemDiscountTextBox;
        private System.Windows.Forms.Button AddNewItemButton;
        private System.Windows.Forms.Button button1;
    }
}