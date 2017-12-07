using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class VendorHistoryServices : IVendorHistoryServices
    {
        private static VendorHistoryDataAccess vendorHistoryDataAccess = null;
        public VendorHistoryServices()
        {
            if(VendorHistoryServices.vendorHistoryDataAccess == null)
            {
                VendorHistoryServices.vendorHistoryDataAccess = new VendorHistoryDataAccess();
            }
        }
        public int Add(VendorHistory history,Vendor vendor)
        {
            return VendorHistoryServices.vendorHistoryDataAccess.Add(history,vendor);
        }

        public List<VendorHistory> GetAll(double vendorPayable)
        {
            throw new NotImplementedException();
        }

        public List<VendorHistory> GetAll(string vendorSupplyDate)
        {
            throw new NotImplementedException();
        }
        public List<VendorHistory> GetAll()
        {
            return VendorHistoryServices.vendorHistoryDataAccess.GetAll();
        }
        public List<VendorHistory> GetAllSupplyProduct(string VendorSupplyProduct)
        {
            throw new NotImplementedException();
        }
    }
}
