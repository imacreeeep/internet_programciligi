using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace MovieApp.Web.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			string filmBasligi = "film başlığı";
			string filmAciklama = "film açıklaması";
			string filmYonetmen = "film yönetmen adı";
			string[] oyuncular = { "oyuncu 1", "oyuncu 2" };

			ViewBag.FilmBasligi = filmBasligi;
			ViewBag.FilmAciklama = filmAciklama;
			ViewBag.FilmYonetmen = filmYonetmen;
			ViewBag.Oyuncular = oyuncular;

			return View();
		}
		
		public IActionResult About()
		{
			return View();
		}
	}
}
