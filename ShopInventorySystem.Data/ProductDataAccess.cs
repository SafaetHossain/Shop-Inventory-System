using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class ProductDataAccess
    {
        public int Add(Product product)
        {
            string query = string.Format("INSERT INTO PRODUCT(ProductId, ProductName, ProductType, ProductPrice, ProductStock, LowRunLimit, ReceiveDate, ExpiaryDate, LineNumber) VALUES('{0}','{1}','{2}',{3},{4},{5},'{6}','{7}','{8}')", product.ProductId, product.ProductName, product.ProductType, product.ProductPrice, product.ProductStock, product.LowRunLimit, product.ReceiveDate, product.ExpiaryDate, product.LineNumber);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(string id)
        {
            string query = "DELETE FROM Product WHERE ProductId = '" + id + "'";
            return DataAccess.ExecuteQuery(query);
        }
        public int Edit(Product product)
        {
            string query = "UPDATE Product SET ProductName='" + product.ProductName + "', ProductType='" + product.ProductType + "', UnitPrice='" + product.ProductPrice + "', UnitsAvailable='" + product.ProductStock + "', LowRunLimit='" + product.LowRunLimit + "', ReceiveDate='" + product.ReceiveDate + "', ExpiaryDate='" + product.ExpiaryDate + "', LotNumber='" + product.LineNumber + "' WHERE Productid = '" + product.ProductId + "'";

            return DataAccess.ExecuteQuery(query);
        }
        public int EditProductStock(string productId,string productStock)
        {
            string query = "UPDATE Product SET UnitsAvailable='" + productStock + "' WHERE Productid = '" + productId + "'";

            return DataAccess.ExecuteQuery(query);
        }
        public List<Product> GetAll()
        {
            string query = "SELECT * FROM Product";
            SqlDataReader reader = DataAccess.GetData(query);
            Product product = null;

            List<Product> productList = new List<Product>();
            while (reader.Read())
            {
                product = new Product();
                product.ProductId = reader["ProductId"].ToString();
                product.ProductName = reader["ProductName"].ToString();
                product.ProductType = reader["ProductType"].ToString();
                product.ProductPrice = Convert.ToDouble(reader["ProductPrice"].ToString());
                product.ProductStock = Convert.ToInt32(reader["ProductStock"].ToString());
                product.LowRunLimit = Convert.ToInt32(reader["LowRunLimit"].ToString());
                product.ReceiveDate = reader["ReceiveDate"].ToString();
                product.ExpiaryDate = reader["ExpiaryDate"].ToString();
                product.LineNumber = reader["LineNumber"].ToString();

                productList.Add(product);
            }
            return productList;
        }
        public List<Product> GetByName(string name)
        {
            string query = "SELECT * FROM Product where ProductName='" + name + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            Product product = null;

            List<Product> productList = new List<Product>();
            while (reader.Read())
            {
                product = new Product();
                product.ProductId = reader["ProductId"].ToString();
                product.ProductName = reader["ProductName"].ToString();
                product.ProductType = reader["ProductType"].ToString();
                product.ProductPrice = Convert.ToDouble(reader["ProductPrice"].ToString());
                product.ProductStock = Convert.ToInt32(reader["ProductStock"].ToString());
                product.LowRunLimit = Convert.ToInt32(reader["LowRunLimit"].ToString());
                product.ReceiveDate = reader["ReceiveDate"].ToString();
                product.ExpiaryDate = reader["ExpiaryDate"].ToString();
                product.LineNumber = reader["LineNumber"].ToString();

                productList.Add(product);
            }
            return productList;
        }

        public List<Product> GetByType(string type)
        {
            string query = "SELECT * FROM Product where ProductType='" + type + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            Product product = null;

            List<Product> productList = new List<Product>();
            while (reader.Read())
            {
                product = new Product();
                product.ProductId = reader["ProductId"].ToString();
                product.ProductName = reader["ProductName"].ToString();
                product.ProductType = reader["ProductType"].ToString();
                product.ProductPrice = Convert.ToDouble(reader["ProductPrice"].ToString());
                product.ProductStock = Convert.ToInt32(reader["ProductStock"].ToString());
                product.LowRunLimit = Convert.ToInt32(reader["LowRunLimit"].ToString());
                product.ReceiveDate = reader["ReceiveDate"].ToString();
                product.ExpiaryDate = reader["ExpiaryDate"].ToString();
                product.LineNumber = reader["LineNumber"].ToString();

                productList.Add(product);
            }
            return productList;
        }
    }
}
