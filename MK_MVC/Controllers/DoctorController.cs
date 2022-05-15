using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;

namespace MK_MVC.Controllers
{
	public class DoctorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ActionResult FeverCheck()
		{
			
			return View();
		}
		 
		[HttpPost]
			public ActionResult FeverCheck(double temp)
			{
				TempCheck model = new TempCheck();	
				ViewBag.Msg = model.Fever(temp);	

					return View();
		}
	}
}
