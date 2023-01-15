using Microsoft.AspNetCore.Mvc;
using ProductsShop.Models;
using System.Collections.Generic;

namespace ProductsShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Products product = Database.GetProduct(slugLink);
            return View(product);
        }
        public IActionResult List()
        {
            List<Products> products = Database.GetProductsList();
            return View(products);
        }
    }
}
