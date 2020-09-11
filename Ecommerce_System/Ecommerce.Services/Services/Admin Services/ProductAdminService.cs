using Ecommerce.Model;
using Ecommerce.Services.Repository.Admin_Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Services.Services.Admin_Services
{
    public class ProductAdminService : IProductAdminService
    {
        public bool AddProductDAL(Product addProduct)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductDAL(Guid deleteProductID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByProductIDDAL(Guid productID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByProductNameDAL(string productName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProductPriceDAL(Product updateProduct)
        {
            throw new NotImplementedException();
        }
    }
}
