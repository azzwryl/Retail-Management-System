using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System
{
    public partial class UpdateSOForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RMSDb"].ConnectionString;
        private string _invoiceNumber = "";
        private string _soId = "";

        public UpdateSOForm(string soId)
        {
            InitializeComponent();
            _soId = soId;
        }

        private void SOUpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SOUpdateInvoiceButton_Click(object sender, EventArgs e)
        {
            //update invoice table.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("SOId", _soId);
                p.Add("SOStatus", "Invoiced");

                connection.Execute("dbo.spInvoice_TransferSOItemsToInvoice", p, commandType: CommandType.StoredProcedure);
            }
            //update soitems table.

            //update so status.

        }
    }
}
