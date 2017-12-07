using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class SalesHistoryDataAccess
    {
        public int Add(SalesHistory salesHistory)
        {
            string query = string.Format("INSERT INTO SalesHistory(ProductSaleDate,SellingProduct,ProductPrice,ProductPayment,ProductDiscount,ProductPayable) VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}'", salesHistory.ProductSaleDate,salesHistory.SellingProduct,salesHistory.ProductPrice,salesHistory.ProductPayment,salesHistory.ProductDiscount,salesHistory.ProductPayable);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(int id)
        {
            string query = "DELETE FROM SalesHistory WHERE SalesId = '" + id + "';";
            return DataAccess.ExecuteQuery(query);
        }
    }
}
