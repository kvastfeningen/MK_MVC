using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using MK_MVC.Data;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace MK_MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AjaxController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PeopleList()
        {
            var p = _context.People.ToList();
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
            var p = _context.People.Where(s => s.PersonId == personId).ToList(); //  || s.City.Contains(SearchWord)

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
            //PeopleViewModel.Remove(personId);

            //return RedirectToAction("Index");
            //return PartialView("_PersonList2", viewModel);
            var personToRemove = _context.People.Find(personId);
            _context.People.Remove(personToRemove);
            _context.SaveChanges();
            return Content("The person is removed!");
        }
        
      
    }
}
