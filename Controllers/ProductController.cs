using Microsoft.AspNetCore.Mvc;
using intpr_uyg1.Models;
using System.Collections.Generic;


namespace intpr_uyg1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "telefon", Price = 100000 },
                new Product { Id = 2, Name = "tablet", Price = 15000 },
                new Product { Id  =3, Name = "mouse", Price = 1000 }
            };
            return View(products);
        }
    }
}
