using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Repository
{
    public interface IProductUserService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByName(string product);
    }
}
