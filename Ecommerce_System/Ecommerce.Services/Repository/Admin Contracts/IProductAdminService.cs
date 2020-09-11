using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Services.Repository.Admin_Contracts
{
    public interface IProductAdminService
    {
        //Methods for CRUD
        public abstract List<Product> GetAllProducts();
        public abstract Product GetProductByProductIDDAL(Guid productID);
        public abstract List<Product> GetProductsByProductNameDAL(string productName);
        public abstract bool AddProductDAL(Product addProduct);
        public abstract bool DeleteProductDAL(Guid deleteProductID);
        public abstract bool UpdateProductPriceDAL(Product updateProduct);

    }
}
