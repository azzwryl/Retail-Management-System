using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    class SalesOrderModel : ItemModel
    {
        public string SOId { get; set; }
        public string SOCustomerId { get; set; }
        public string SOCustomerName { get; set; }
        public decimal SOTotalAmount { get; set; }
        public DateTime SODate { get; set; }
        public string SOStatus { get; set; }
        public int SOQuantity { get; set; }

        public SalesOrderModel()
        {

        }

        public SalesOrderModel(string soId, string soCustomerId, string soCustomerName, decimal soTotalAmount, 
            DateTime soDate, string soStatus)
        {
            SOId = soId;
            SOCustomerId = soCustomerId;
            SOCustomerName = soCustomerName;
            SOTotalAmount = soTotalAmount;
            SODate = soDate;
            SOStatus = soStatus;
        }

        public SalesOrderModel(string soId, string soQuantity, DateTime soDate, string soStatus, string itemId, decimal itemPrice)
        {
            SOId = soId;

            int soQuantityValue = 0;
            Int32.TryParse(soQuantity, out soQuantityValue);
            SOQuantity = soQuantityValue;

            SODate = soDate;
            SOStatus = soStatus;
            ItemId = itemId;
            ItemPrice = itemPrice;
        }

    }
}
