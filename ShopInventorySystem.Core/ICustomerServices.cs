using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public interface ICustomerServices
    {
        int Add(Customer customer);
        int Remove(string id);
        int Edit(Customer customer);
        List<Customer> GetAll();
        List<Customer> GetByName(string name);
        List<Customer> GetByPhone(string phone);
    }
}
