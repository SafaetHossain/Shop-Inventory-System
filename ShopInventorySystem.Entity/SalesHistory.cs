using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class SalesHistory
    {
        private string productSaleDate, sellingProduct;
        private double productPrice, productPayment, productPayable;
        private int productDiscount;

        public SalesHistory()
        {
            productSaleDate = "";
            sellingProduct = "";
            productPrice = 0.0;
            productPayment = 0.0;
            productPayable = 0.0;
            productDiscount = 0;
        }
        public SalesHistory(string productSaleDate, string sellingProduct, double productPrice, double productPayment, double productPayable, int productDiscount)
        {
            this.productSaleDate = productSaleDate;
            this.sellingProduct = sellingProduct;
            this.productPrice = productPrice;
            this.productPayment = productPayment;
            this.productPayable = productPayable;
            this.productDiscount = productDiscount;
        }
        public string ProductSaleDate
        {
            set { this.productSaleDate = value; }
            get { return productSaleDate; }
        }
        public string SellingProduct
        {
            set { this.sellingProduct = value; }
            get { return sellingProduct; }
        }
        public double ProductPrice
        {
            set { this.productPrice = value; }
            get { return productPrice; }
        }
        public double ProductPayment
        {
            set { this.productPayment = value; }
            get { return productPayment; }
        }
        public double ProductPayable
        {
            set { this.productPayable = value; }
            get { return productPayable; }
        }
        public int ProductDiscount
        {
            set { this.productDiscount = value; }
            get { return productDiscount; }
        }
    }
}
