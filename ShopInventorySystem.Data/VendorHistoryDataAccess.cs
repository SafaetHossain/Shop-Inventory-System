using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class VendorHistoryDataAccess
    {
        public int Add(VendorHistory vendorhistroy,Vendor vendor)
        {
            string query = string.Format("INSERT INTO VendorHistory(VendorSupplyDate,VendorSupplyProduct,VendorPayment,VendorProductPrice,VendorPayable,VendorPhone) VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}'", vendorhistroy.VendorSupplyDate, vendorhistroy.VendorSupplyProduct, vendorhistroy.VendorPayment, vendorhistroy.VendorProductPrice, vendorhistroy.VendorPayable, vendor.VendorPhone);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(string id)
        {
            string query = "DELETE FROM VendorHistory WHERE VendorHistoryId = '" + id + "';";
            return DataAccess.ExecuteQuery(query);
        }
        public int Edit(VendorHistory vendorHistory)
        {
            string query = "UPDATE vendorHistory SET VendorPayable = "+ vendorHistory.VendorPayable +" where VendorHistoryId = " + vendorHistory.VendorHistoryId;
            return DataAccess.ExecuteQuery(query);
        }
        public List<VendorHistory> GetAll()
        {
            string query = "SELECT * FROM VendorHistory ";
            SqlDataReader reader = DataAccess.GetData(query);

            VendorHistory vendorhistory = null;
            List<VendorHistory> vendorhistoryList = new List<VendorHistory>();
            while (reader.Read())
            {
                vendorhistory.VendorHistoryId = Convert.ToInt32(reader["VendorHistoryId"].ToString());
                vendorhistory.VendorSupplyDate = reader["VendorSupplyDate"].ToString();
                vendorhistory.VendorSupplyProduct = reader["VendorSupplyProduct"].ToString();
                vendorhistory.VendorPayment = Convert.ToDouble(reader["VendorPayment"].ToString());
                vendorhistory.VendorProductPrice = Convert.ToDouble(reader["VendorProductPrice"].ToString());
                vendorhistory.VendorPayable = Convert.ToDouble(reader["VendorPayable"].ToString());

                vendorhistoryList.Add(vendorhistory);
            }
            return vendorhistoryList;
        }
    }
}
