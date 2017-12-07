using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class VendorHistory
    {
        private string vendorSupplyDate,vendorSupplyProduct;
        private double vendorPayment, vendorProductPrice, vendorPayable;
        private int vendorHistoryId;

        public VendorHistory(string vendorSupplyDate, string vendorSupplyProduct, double vendorPayment, double vendorProductPrice, double vendorPayable)
        {
            this.vendorSupplyDate = vendorSupplyDate;
            this.vendorSupplyProduct = vendorSupplyProduct;
            this.vendorPayment = vendorPayment;
            this.vendorProductPrice = vendorProductPrice;
            this.vendorPayable = vendorPayable;
        }

        public int VendorHistoryId
        {
            set { this.vendorHistoryId = value;  }
            get { return vendorHistoryId; }
        }
        public string VendorSupplyDate
        {
            set { this.vendorSupplyDate = value; }
            get { return vendorSupplyDate; }
        }

        public string VendorSupplyProduct
        {
            set { this.vendorSupplyProduct = value; }
            get { return vendorSupplyProduct; }
        }

        public double VendorPayment
        {
            set { this.vendorPayment = value; }
            get { return vendorPayment; }
        }

        public double VendorProductPrice
        {
            set { this.vendorProductPrice = value; }
            get { return vendorProductPrice; }
        }

        public double VendorPayable
        {
            set { this.vendorPayable = value; }
            get { return vendorPayable; }
        }
    }
}
