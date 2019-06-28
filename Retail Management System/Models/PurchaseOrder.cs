using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    public class PurchaseOrderModel : ItemModel
    {
        public string POId { get; set; }

        public int POQuantity { get; set; }

        public DateTime PODate { get; set; }

        public string POInvoiceNumber { get; set; }

        public decimal POTotalAmount { get; set; }

        public string POStatus { get; set; }

        public string POVendorId { get; set; }

        public string POVendorName { get; set; }

        public byte CheckInitialRun { get; set; }

        public PurchaseOrderModel ()
        {

        }

        public PurchaseOrderModel (string poId, string poQuantity, DateTime poDate, string poStatus, string itemId, decimal itemPrice)
        {
            POId = poId;

            int poQuantityValue = 0;
            Int32.TryParse(poQuantity, out poQuantityValue);
            POQuantity = poQuantityValue;

            PODate = poDate;
            POStatus = poStatus;
            ItemId = itemId;
            ItemPrice = itemPrice;
        }

        public PurchaseOrderModel (string poId, string poVendorId, string poVendorName, string poInvoiceNumber, string poTotalAmount, 
                                    DateTime poDate, string poStatus)
        {
            POId = poId;
            POVendorId = poVendorId;
            POVendorName = poVendorName;
            POInvoiceNumber = poInvoiceNumber;

            decimal poTotalAmountValue = 0;
            decimal.TryParse(poTotalAmount, out poTotalAmountValue);
            POTotalAmount = poTotalAmountValue;

            PODate = poDate;
            POStatus = poStatus;
        }

        public PurchaseOrderModel (string poId, string poInvoiceNumber, string poTotalAmount,
                                    DateTime poDate, string poStatus)
        {
            POId = poId;
            POInvoiceNumber = poInvoiceNumber;

            decimal poTotalAmountValue = 0;
            decimal.TryParse(poTotalAmount, out poTotalAmountValue);
            POTotalAmount = poTotalAmountValue;

            PODate = poDate;
            POStatus = poStatus;
        }

        public PurchaseOrderModel(string poId, string poQuantity, DateTime poDate, string poStatus, string itemId, decimal itemPrice,
                                    byte checkInitialRun)
        {
            POId = poId;

            int poQuantityValue = 0;
            Int32.TryParse(poQuantity, out poQuantityValue);
            POQuantity = poQuantityValue;

            PODate = poDate;
            POStatus = poStatus;
            ItemId = itemId;
            ItemPrice = itemPrice;
            CheckInitialRun = checkInitialRun;
        }
    }
}
