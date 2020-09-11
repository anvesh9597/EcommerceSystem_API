using Ecommerce.Model;
using Ecommerce.Model.ViewModel;
using Ecommerce.Services.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Services.User_Services
{
    public class ProductUserService : IProductUserService
    {
        private readonly string baseUrl = "https://localhost:44391/";
        public async Task<List<Product>> GetAllProductsAsync()
        {
            List<Product> productList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl+"products"))
                {
                    if (response.IsSuccessStatusCode) {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        productList = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                    }
                    
                }
            }
            return productList;
        }

        public async Task<Product> GetProductByName(string getProductByName)
        {
            List<Product> productList = new List<Product>();
            productList = await GetAllProductsAsync();

            var product = productList.Find(item => item.ProductName.Contains(getProductByName));


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl+"products/" + product.ProductID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return product;
        }
    }
}
