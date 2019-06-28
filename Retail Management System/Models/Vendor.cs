using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Management_System.Models
{
    public class VendorModel
    {
        public string VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorAddressCountry { get; set; }

        public string VendorAddressProvinceOrState { get; set; }

        public string VendorAddressCityOrTown { get; set; }

        public string VendorAddressExactLocation { get; set; }

        public string VendorEmailAddress { get; set; }

        public string VendorContactNumber { get; set; }

        public string VendorContactPerson { get; set; }

        public string VendorPurchase { get; set; }

        public VendorModel()
        {

        }

        public VendorModel(string vendorId, string vendorName, string vendorAddressCountry, string vendorAddressProvinceOrState,
                            string vendorAddressCityOrTown, string vendorAddressExactLocation, string vendorEmailAddress,
                            string vendorContactNumber, string vendorContactPerson)
        {
            VendorId = vendorId;
            VendorName = vendorName;
            VendorAddressCountry = vendorAddressCountry;
            VendorAddressProvinceOrState = vendorAddressProvinceOrState;
            VendorAddressCityOrTown = vendorAddressCityOrTown;
            VendorAddressExactLocation = vendorAddressExactLocation;
            VendorEmailAddress = vendorEmailAddress;
            VendorContactNumber = vendorContactNumber;
            VendorContactPerson = vendorContactPerson;
        }
            


    }
}
