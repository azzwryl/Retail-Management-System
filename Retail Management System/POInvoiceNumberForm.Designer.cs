namespace Retail_Management_System
{
    partial class POInvoiceNumberForm
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
            this.POInvoiceFormCancelButton = new System.Windows.Forms.Button();
            this.POInvoiceFormPostButton = new System.Windows.Forms.Button();
            this.POInvoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // POInvoiceFormCancelButton
            // 
            this.POInvoiceFormCancelButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POInvoiceFormCancelButton.Location = new System.Drawing.Point(337, 93);
            this.POInvoiceFormCancelButton.Name = "POInvoiceFormCancelButton";
            this.POInvoiceFormCancelButton.Size = new System.Drawing.Size(158, 39);
            this.POInvoiceFormCancelButton.TabIndex = 34;
            this.POInvoiceFormCancelButton.Text = "Cancel";
            this.POInvoiceFormCancelButton.UseVisualStyleBackColor = true;
            this.POInvoiceFormCancelButton.Click += new System.EventHandler(this.POInvoiceFormCancelButton_Click);
            // 
            // POInvoiceFormPostButton
            // 
            this.POInvoiceFormPostButton.Font = new System.Drawing.Font("Arial", 15F);
            this.POInvoiceFormPostButton.Location = new System.Drawing.Point(173, 93);
            this.POInvoiceFormPostButton.Name = "POInvoiceFormPostButton";
            this.POInvoiceFormPostButton.Size = new System.Drawing.Size(158, 39);
            this.POInvoiceFormPostButton.TabIndex = 33;
            this.POInvoiceFormPostButton.Text = "Post";
            this.POInvoiceFormPostButton.UseVisualStyleBackColor = true;
            this.POInvoiceFormPostButton.Click += new System.EventHandler(this.POInvoiceFormPostButton_Click);
            // 
            // POInvoiceNumberTextBox
            // 
            this.POInvoiceNumberTextBox.Location = new System.Drawing.Point(246, 20);
            this.POInvoiceNumberTextBox.Name = "POInvoiceNumberTextBox";
            this.POInvoiceNumberTextBox.Size = new System.Drawing.Size(433, 34);
            this.POInvoiceNumberTextBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "PO Invoice Number:";
            // 
            // POInvoiceNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 157);
            this.Controls.Add(this.POInvoiceNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.POInvoiceFormCancelButton);
            this.Controls.Add(this.POInvoiceFormPostButton);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "POInvoiceNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PO InvoiceNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button POInvoiceFormCancelButton;
        private System.Windows.Forms.Button POInvoiceFormPostButton;
        private System.Windows.Forms.TextBox POInvoiceNumberTextBox;
        private System.Windows.Forms.Label label1;
    }
}