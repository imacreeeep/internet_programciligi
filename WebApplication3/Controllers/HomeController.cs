using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeControllers : Controller
    {
        public IActionResult Index()
        {
            return Content("hello world!");
        }
    }
}
