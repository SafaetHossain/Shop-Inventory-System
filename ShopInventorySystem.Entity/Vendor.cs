using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class Vendor
    {
        private string vendorName, vendorPhone, vendorAddress, vendorProductType, vendorLastSupplyDate;
        private double vendorLastPayment;

        public Vendor()
        {
            vendorName = "";
            vendorPhone = "";
            vendorProductType = "";
            vendorAddress = "";
            vendorLastSupplyDate = "";
            vendorLastPayment = 0.0;
        }

        public Vendor(string vendorName, string vendorPhone, string vendorAddress, string vendorProductType, string vendorLastSupplyDate,double vendorLastPayment)
        {
            this.vendorName = vendorName;
            this.vendorPhone = vendorPhone;
            this.vendorProductType = vendorProductType;
            this.vendorAddress = vendorAddress;
            this.vendorLastSupplyDate = vendorLastSupplyDate;
            this.vendorLastPayment = vendorLastPayment;
        }


        public string VendorName
        {
            set{ this.vendorName = value; }
            get{ return vendorName; }    
        }

        public string VendorPhone
        {
            set { this.vendorPhone = value; }
            get { return vendorPhone; }
        }

        public string VendorAddress
        {
            set { this.vendorAddress = value; }
            get { return vendorAddress; }
        }

        public string VendorProductType
        {
            set { this.vendorProductType = value; }
            get { return vendorProductType; }
        }

        public string VendorLastSupplyDate
        {
            set { this.vendorLastSupplyDate = value; }
            get { return vendorLastSupplyDate; }
        }

        public double VendorLastPayment
        {
            set { this.vendorLastPayment = value; }
            get { return vendorLastPayment; }
        }
    }
}
