using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class Product
    {
        private string productId,productName, productType, lineNumber, receiveDate, expiaryDate;
        private int productStock, lowRunLimit;
        private double productPrice;

        public Product()
        {
            productId = "";
            productName = "";
            productType = "";
            productPrice = 0.0;
            lineNumber = "";
            productStock = 0;
            lowRunLimit = 0;
            receiveDate = "";
            expiaryDate = "";

        } 

        public Product(string productId,string productName,string productType, double productPrice,string lineNumber,int productStock,int lowRunLimit,string receiveDate,string expiaryDate)
        {
            this.productId = productId;
            this.productName = productName;
            this.productType = productType;
            this.productPrice = productPrice;
            this.lineNumber = lineNumber;
            this.productStock = productStock;
            this.lowRunLimit = lowRunLimit;
            this.receiveDate = receiveDate;
            this.expiaryDate = expiaryDate;
        }

        public string ProductId
        {
            set { this.productId = value; }
            get { return productId; }
        }

        public string ProductName
        {
            set { this.productName = value; }
            get { return productName; }
        }

        public string ProductType
        {
            set { this.productType = value; }
            get { return productType; }
        }

        public double ProductPrice
        {
            set { this.productPrice = value; }
            get { return productPrice; }
        }

        public string LineNumber
        {
            set { this.lineNumber = value; }
            get { return lineNumber; }
        }

        public int ProductStock
        {
            set { this.productStock = value; }
            get { return productStock; }
        }

        public int LowRunLimit
        {
            set { this.lowRunLimit = value; }
            get { return lowRunLimit; }
        }

        public string ReceiveDate
        {
            set { this.receiveDate = value; }
            get { return receiveDate; }
        }

        public string ExpiaryDate
        {
            set { this.expiaryDate = value; }
            get { return expiaryDate; }
        }
    }
}
