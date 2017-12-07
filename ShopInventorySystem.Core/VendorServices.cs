using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class VendorServices : IVendorServices
    {
        private static VendorDataAccess vendorDataAccess = null;
        public VendorServices()
        {
            if(VendorServices.vendorDataAccess == null)
            {
                VendorServices.vendorDataAccess = new VendorDataAccess();
            }
        }
        public int Add(Vendor vendor)
        {
            return VendorServices.vendorDataAccess.Add(vendor);
        }

        public int Edit(Vendor vendor)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetByProduct(string product)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
