using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System
{
    public partial class POInvoiceNumberForm : Form
    {
        public string POInvoiceNumberValue { get; set; }

        public POInvoiceNumberForm()
        {
            InitializeComponent();
        }

        private void POInvoiceFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POInvoiceFormPostButton_Click(object sender, EventArgs e)
        {
            this.POInvoiceNumberValue = POInvoiceNumberTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
