using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    class InventoryModel : ItemModel
    {
        public int InvItemQuantity { get; set; }
        public string InvItemLocation { get; set; }

        public InventoryModel ()
        {

        }

        public InventoryModel (string itemId, string itemName, string invItemQuantity, string invItemLocation)
        {
            ItemId = itemId;
            ItemName = itemName;

            int invItemQuantityValue = 0;
            Int32.TryParse(invItemQuantity, out invItemQuantityValue);
            InvItemQuantity = invItemQuantityValue;
            InvItemLocation = invItemLocation;
        }
    }
}
