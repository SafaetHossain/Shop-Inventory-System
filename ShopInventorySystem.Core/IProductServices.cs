using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public interface IProductServices
    {
        int Add(Product products);
        int Remove(string query);
        int Update(Product products);
        List<Product> GetAll();
        List<Product> GetById(string id);
        List<Product> GetByName(string name);
        List<Product> GetByType(string type);
        List<Product> GetByReceiveDate(string receiveDate);
        List<Product> GetByExpiaryDate(string GetByExpiaryDate);
    }
}
