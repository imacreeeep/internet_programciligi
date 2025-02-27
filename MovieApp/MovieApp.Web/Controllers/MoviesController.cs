using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List()
		{
			return View("Movies");
		}
		public IActionResult Details()
		{
			return View();
		}
	}
}
