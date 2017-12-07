using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class Customer
    {
        private string customerName, customerPhone, customerAddress, customerLastBuyingDate;

        public Customer(string customerName, string customerPhone, string customerAddress, string customerLastBuyingDate)
        {
            this.customerName = customerName;
            this.customerPhone = customerPhone;
            this.customerAddress = customerAddress;
            this.customerLastBuyingDate = customerLastBuyingDate;
        }

        public string CustomerName
        {
            set { this.customerName = value; }
            get { return customerName; }
        }

        public string CustomerPhone
        {
            set { this.customerPhone = value; }
            get { return customerPhone; }
        }

        public string CustomerAddress
        {
            set { this.customerAddress = value; }
            get { return customerAddress; }
        }

        public string CustomerLastBuyingDate
        {
            set { this.customerLastBuyingDate = value; }
            get { return customerLastBuyingDate; }
        }
    }
}
