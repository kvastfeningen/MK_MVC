using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;

namespace MK_MVC.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PeopleList()
        {
            var p = PeopleViewModel.People;
            var viewModel = new PeopleViewModel()
            {
                AllPeople = p
            };
            return PartialView("_PersonList", viewModel);

        }
        
        public IActionResult IdPerson()
        {
            
            return View();

        }
        
        /*
        public IActionResult IdPerson(int personId)
        {
            var p = PeopleViewModel.People.Where(s => s.PersonId == personId).ToList(); //  || s.City.Contains(SearchWord)

            var viewModel = new PeopleViewModel()
            {
                AllPeople = p
            };
            return PartialView("_PersonList2", viewModel);
            //return View();

        }
        */
        [HttpPost]
        public IActionResult IdPerson(int personId)
        {
            var p = PeopleViewModel.People.Where(s => s.PersonId == personId).ToList(); //  || s.City.Contains(SearchWord)

            var viewModel = new PeopleViewModel()
            {
                AllPeople = p
            };
            return PartialView("_PersonList2", viewModel);
        }
    
        
        public IActionResult Remove()
        {

            return View();
           // return RedirectToAction("Index");
        }
        
        /*
        public IActionResult Remove(int personId)
        {
            PeopleViewModel.Remove(personId);

            return RedirectToAction("Index");
        }
        */
        [HttpPost]
        public IActionResult Remove(int personId)
        {
            PeopleViewModel.Remove(personId);

            //return RedirectToAction("Index");
            //return PartialView("_PersonList2", viewMode);
            return Content("The person is removed!");
        }
        
      
    }
}
