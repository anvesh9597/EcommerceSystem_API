using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Model;
using Ecommerce.Model.ViewModel;
using Ecommerce.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly IProductUserService _productUserService;
        public CartController(IProductUserService productUserService)
        {
            _productUserService = productUserService;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);
            return View();
        }

        [Route("buy/{id}")]
        public async Task<IActionResult> Buy(Guid id)
        {
            //ProductViewModel productModel = new ProductViewModel();

            var productsList = await _productUserService.GetAllProductsAsync();

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();

                cart.Add(new Item { Product = productsList.Find(x => x.ProductID == id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = productsList.Find(x => x.ProductID == id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        private int isExist(Guid id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }

}
