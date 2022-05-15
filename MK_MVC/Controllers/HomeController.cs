using Microsoft.AspNetCore.Mvc;

namespace MK_MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

			ViewBag.Name = "Micke Kantvik";
			return View();
		}
		public IActionResult Contact()
		{

			ViewBag.Name = "Micke Kantvik";
			return View();
		}

		public IActionResult About()
		{

			ViewBag.Name = "Micke Kantvik";
			return View();
		}

		public IActionResult Projects()
		{

			ViewBag.Name = "Micke Kantvik";
			return View();
		}
	}
}
