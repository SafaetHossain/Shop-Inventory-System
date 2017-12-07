using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public interface ISalesHistoryServices
    {
        List<SalesHistory> GetAll(string dateReceive);
        List<SalesHistory> GetAll();
        int Add(SalesHistory history);
    }
}
