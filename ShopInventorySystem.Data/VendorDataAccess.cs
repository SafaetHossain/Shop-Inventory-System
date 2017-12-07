using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class VendorDataAccess
    {
        public int Add(Vendor vendor)
        {
            string query = string.Format("INSERT INTO Vendor(VendorName,VendorPhone,VendorAddress,VendorProductType,VendorLastSupplyDate,VendorLastPayemtt) VALUES('{0}', '{1}', {2}, '{3}', '{4}', {5}", vendor.VendorName,vendor.VendorPhone,vendor.VendorAddress,vendor.VendorProductType, vendor.VendorLastSupplyDate,vendor.VendorLastPayment);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(string phone)
        {
            string query = "DELETE FROM Vendor WHERE VendorPhone = '" + phone + "';";
            return DataAccess.ExecuteQuery(query);
        }
        public int Edit(Vendor vendor)
        {
            string query = string.Format("UPDATE Vendor SET VendorName ='{0}',VendorAddress={2},VendorProductType='{3}',VendorLastSupplyDate='{4}',VendorLastPayment='{5}' WHERE VendorPhone='{1}'", vendor.VendorName,vendor.VendorPhone,vendor.VendorAddress,vendor.VendorProductType, vendor.VendorLastSupplyDate,vendor.VendorLastPayment);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Vendor> GetByPhone(string phone)
        {
            string query = "SELECT * FROM Vendor WHERE VendorName = '" + phone + "'";
            SqlDataReader reader = DataAccess.GetData(query);

            Vendor vendor = null;
            List<Vendor> vendorList = new List<Vendor>();
            while (reader.Read())
            {
                vendor.VendorName = reader["VendorName"].ToString();
                vendor.VendorPhone = reader["VendorPhone"].ToString();
                vendor.VendorAddress = reader["VendorAddress"].ToString();
                vendor.VendorProductType = reader["VendorProductType"].ToString();
                vendor.VendorLastSupplyDate = reader["VendorLastSupplyDate"].ToString();
                vendor.VendorLastPayment = Convert.ToDouble(reader["VendorLastPayment"].ToString());

                vendorList.Add(vendor);
            }
            return vendorList;
        }
    }
}
