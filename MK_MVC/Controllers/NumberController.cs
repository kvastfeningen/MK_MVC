using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MK_MVC.Controllers
{
    public class NumberController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {

            int num = (int)HttpContext.Session.GetInt32("correctNumber");
           
            if (guess > num)
            {
                ViewBag.Msg = "För högt!";
                
            }
            else if (guess < num)
            {
                ViewBag.Msg = "För lågt!";
                
            }
            else
            {
                ViewBag.Msg = "Grattis, du fixade det!";
            }

            ViewBag.Num = guess;

            return View();
        }

        
        public IActionResult GuessNumber()

        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            int guesses = 0;
            HttpContext.Session.SetInt32("correctNumber", number);
            


            return View();
        }
    }
}
