using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class CustomerServices : ICustomerServices
    {
        private static CustomerDataAccess customerDataAccess = null;

        public CustomerServices()
        {
            if(CustomerServices.customerDataAccess == null)
            {
                CustomerServices.customerDataAccess = new CustomerDataAccess();
            }
        }
        public int Add(Customer customer)
        {
            return CustomerServices.customerDataAccess.Add(customer);
        }

        public int Edit(Customer customer)
        {
            return CustomerServices.customerDataAccess.Edit(customer);
        }

        public List<Customer> GetAll()
        {
            return CustomerServices.customerDataAccess.GetAll();
        }

        public List<Customer> GetByPhone(string phone)
        {
            return CustomerServices.customerDataAccess.GetByPhone(phone);
        }
        public List<Customer> GetByName(string name)
        {
            return CustomerServices.customerDataAccess.GetByPhone(name);
        }
        public int Remove(string id)
        {
            return CustomerServices.customerDataAccess.Remove(id);
        }
    }
}
