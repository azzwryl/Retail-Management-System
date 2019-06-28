using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    public class ItemModel
    {
        public string ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal ItemDiscount { get; set; }

        public string ItemDisabled { get; set; }

        public int Id { get; set; }

        public ItemModel ()
        {

        }

        public ItemModel(string itemId, string itemName, string itemDescription, string itemPrice, string itemDiscount)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemDescription = itemDescription;

            decimal itemPriceValue = 0;
            decimal.TryParse(itemPrice, out itemPriceValue);
            ItemPrice = itemPriceValue;

            decimal itemDiscountValue = 0;
            decimal.TryParse(itemDiscount, out itemDiscountValue);
            ItemDiscount = itemDiscountValue;
        }
            
    }
}
