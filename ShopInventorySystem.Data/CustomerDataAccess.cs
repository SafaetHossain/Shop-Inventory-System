using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class CustomerDataAccess
    {
        public int Add(Customer customer)
        {
            string query = string.Format("INSERT INTO Customer(CustomerName,CustomerPhone,CustomerAddress,CustomerLastBuyingDate) VALUES('{0}', '{1}', {2}, '{3}'", customer.CustomerName,customer.CustomerPhone,customer.CustomerAddress,customer.CustomerLastBuyingDate);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string phone)
        {
            string query = "DELETE FROM Customer WHERE CustomerPhone = '" + phone + "';";
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Customer cutomer)
        {
            string query = "UPDATE Product SET CustomerAddress='" + cutomer.CustomerAddress + "', CustomerLastBuyingDate='" + cutomer.CustomerLastBuyingDate + "' WHERE CustomerPhone = '" + cutomer.CustomerPhone + "'";
            return DataAccess.ExecuteQuery(query);
        }
        public int EditLastBuyingDate(string phone,string lastBuyingDate)
        {
            string query = "UPDATE Customer SET CustomerLastBuyingDate ='" + lastBuyingDate +"' where CustomerPhone = '"+ phone +"'";
            return DataAccess.ExecuteQuery(query);
        }
        
        public List<Customer> GetAll()
        {
            string query = "SELECT * FROM Customer";
            SqlDataReader reader = DataAccess.GetData(query);

            Customer customer = null;
            List<Customer> customerList = new List<Customer>();
            while (reader.Read())
            {
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerPhone = reader["CustomerPhone"].ToString();
                customer.CustomerAddress = reader["CustomerAddress"].ToString();
                customer.CustomerLastBuyingDate = reader["CustomerLastBuyingDate"].ToString();

                customerList.Add(customer);
            }
            return customerList;
        }
        public List<Customer> GetByName(string name)
        {
            string query = "SELECT * FROM Customer WHERE CustomerName = '" + name + "'";
            SqlDataReader reader = DataAccess.GetData(query);

            Customer customer = null;
            List<Customer> customerList = new List<Customer>();
            while (reader.Read())
            {
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerPhone = reader["CustomerPhone"].ToString();
                customer.CustomerAddress = reader["CustomerAddress"].ToString();
                customer.CustomerLastBuyingDate = reader["CustomerLastBuyingDate"].ToString();

                customerList.Add(customer);
            }
            return customerList;
        }
        public List<Customer> GetByPhone(string phone)
        {
            string query = "SELECT * FROM Customer WHERE CustomerPhone = '" + phone + "'";
            SqlDataReader reader = DataAccess.GetData(query);

            Customer customer = null;
            List<Customer> customerList = new List<Customer>();
            while (reader.Read())
            {
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerPhone = reader["CustomerPhone"].ToString();
                customer.CustomerAddress = reader["CustomerAddress"].ToString();
                customer.CustomerLastBuyingDate = reader["CustomerLastBuyingDate"].ToString();

                customerList.Add(customer);
            }
            return customerList;
        }
    }
}
