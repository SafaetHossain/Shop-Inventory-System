using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    class ServiceFactory
    {
        public IEmployeeServices GetEmployeeServiceInstance()
        {
            return new EmployeeServices();
        }
        public IProductServices GetProductServicesInstance()
        {
            return new ProductServices();
        }
        public ICustomerServices GetCustomerServicesInstance()
        {
            return new CustomerServices();
        }
        public ISalesHistoryServices GetSalesHistoryServicesInstance()
        {
            return new SalesHistoryServices();
        }
        public IVendorServices GetVendorServicesInstance()
        {
            return new VendorServices();
        }
        public IVendorHistoryServices GetVendorHistoryServicesInstance()
        {
            return new VendorHistoryServices();
        }
    }
}
