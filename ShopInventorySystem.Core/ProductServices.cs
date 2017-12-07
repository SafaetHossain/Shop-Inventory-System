using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class ProductServices : IProductServices
    {
        private static ProductDataAccess productDataAccess = null;
        public ProductServices()
        {
            if(ProductServices.productDataAccess == null)
            {
                ProductServices.productDataAccess = new ProductDataAccess();
            }
        }

        public int Add(Product products)
        {
            return ProductServices.productDataAccess.Add(products);
        }

        public int Remove(string id)
        {
            return ProductServices.productDataAccess.Remove(id);
        }

        public List<Product> GetAll()
        {
            return ProductServices.productDataAccess.GetAll();
        }

        public List<Product> GetByExpiaryDate(string GetByExpiaryDate)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByName(string name)
        {
            return ProductServices.productDataAccess.GetByName(name);
        }

        public List<Product> GetByReceiveDate(string receiveDate)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByType(string type)
        {
            return ProductServices.productDataAccess.GetByType(type);
        }

        public int Update(Product products)
        {
            throw new NotImplementedException();
        }
    }
}
