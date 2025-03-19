using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductApp.Models;

namespace RazorProductApp.Pages
{
    public class ProductListModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 20000, Stock = 5},
            new Product { Id = 2, Name = "Mouse", Price = 500, Stock = 10},
            new Product { Id = 3, Name = "Klavye", Price = 1000, Stock = 0}
        };
    }
}
