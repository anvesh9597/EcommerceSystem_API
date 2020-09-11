using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Ecommerce.Model;
using Ecommerce.Model.ViewModel;
using Ecommerce.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Ecommerce.Presentation.Controllers
{
    
    public class UserController : Controller
    {
        private readonly IProductUserService _productUserService;

        public UserController(IProductUserService productUserService)
        {
            _productUserService = productUserService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllProducts()
        {
            var productsList = await _productUserService.GetAllProductsAsync();
            return View(productsList);
        }

        public ViewResult GetProductByName() => View();

        [HttpPost]
        public async Task<IActionResult> GetProductByName(string productName)
        {
            var getProductByName = await _productUserService.GetProductByName(productName);
            return View(getProductByName);
        }

    }
}
