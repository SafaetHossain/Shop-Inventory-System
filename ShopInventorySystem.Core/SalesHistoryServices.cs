using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class SalesHistoryServices : ISalesHistoryServices
    {
        private static SalesHistoryDataAccess salesHistoryDataAccess = null;
        public SalesHistoryServices()
        {
            if (SalesHistoryServices.salesHistoryDataAccess == null)
            {
                SalesHistoryServices.salesHistoryDataAccess = new SalesHistoryDataAccess();
            }
        }
        public int Add(SalesHistory history)
        {
            return SalesHistoryServices.salesHistoryDataAccess.Add(history);
        }

        public List<SalesHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SalesHistory> GetAll(string dateReceive)
        {
            throw new NotImplementedException();
        }
    }
}
