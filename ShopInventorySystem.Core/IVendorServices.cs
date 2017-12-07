using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public interface IVendorServices
    {
        int Add(Vendor vendor);
        int Remove(string id);
        int Edit(Vendor vendor);
        List<Vendor> GetAll();
        List<Vendor> GetById(string id);
        List<Vendor> GetByName(string name);
        List<Vendor> GetByProduct(string product);
        List<Vendor> GetByPhone(string phone);
    }
}
