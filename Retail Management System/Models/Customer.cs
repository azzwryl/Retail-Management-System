using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    public class CustomerModel
    {
        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddressCountry { get; set; }
        
        public string CustomerAddressProvinceOrState { get; set; }

        public string CustomerAddressCityOrTown { get; set; }

        public string CustomerAddressExactLocation { get; set; }

        public string CustomerEmailAddress { get; set; }

        public string CustomerContactNumber { get; set; }
        
        public string CustomerContactPerson { get; set; }

        public string CustomerSalesOrder { get; set; }

        public string CustomerInvoice { get; set; }

        public CustomerModel()
        {

        }

        public CustomerModel (string customerId, string customerName, string customerAddressCountry, string customerAddressProvinceOrState,
                              string customerAddressCityOrTown, string customerAddressExactLocation, string customerEmailAddress,
                              string customerContactNumber, string customerContactPerson)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerAddressCountry = customerAddressCountry;
            CustomerAddressProvinceOrState = customerAddressProvinceOrState;
            CustomerAddressCityOrTown = customerAddressCityOrTown;
            CustomerAddressExactLocation = customerAddressExactLocation;
            CustomerEmailAddress = customerEmailAddress;
            CustomerContactNumber = customerContactNumber;
            CustomerContactPerson = customerContactPerson;
        }
    }
}
