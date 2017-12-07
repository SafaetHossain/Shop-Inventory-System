using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public interface IVendorHistoryServices
    {
        List<VendorHistory> GetAll(string vendorSupplyDate);
        List<VendorHistory> GetAll(double vendorPayable);
        List<VendorHistory> GetAllSupplyProduct(string VendorSupplyProduct);
       // List<VendorHistory> GetByPhone(string phone);
        List<VendorHistory> GetAll();
        int Add(VendorHistory history, Vendor vendor);
    }
}
