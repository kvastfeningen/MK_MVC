using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MK_MVC.Controllers
{
    public class PersonController : Controller
    {
        

        public IActionResult Index(string SearchWord)
        {
           if(string.IsNullOrEmpty(SearchWord))
            {
                PeopleViewModel viewModel = new PeopleViewModel();

                return View(viewModel);
            }
            else
            {
               
                var p = PeopleViewModel.People?.Where(s => s.Name.Contains(SearchWord) || s.City.Contains(SearchWord)).ToList(); //  || s.City.Contains(SearchWord)

                var viewmodel = new PeopleViewModel()
                {
                    AllPeople = p
                };
                return View(viewmodel);
              
            }
        }

        public IActionResult Add()
        {
             
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Add(CreatePersonViewModel createPersonViewModel)
        {

            if (ModelState.IsValid)
            {
                Person newPerson = new Person
                {
                    Name = createPersonViewModel.Name,
                    Phone = createPersonViewModel.Phone,
                    City = createPersonViewModel.City
                };

                CreatePersonViewModel.Add(newPerson);
               
                return RedirectToAction("Index");
              
            }
            //return View();
            return RedirectToAction("Index");
        }
        
        public IActionResult Remove()
        {
            /*
             PeopleViewModel viewModel = new PeopleViewModel();
            
            var pList = PeopleViewModel.People.ToList();

            var viewmodel = new PeopleViewModel()
            {
                AllPeople = pList
            };
            */
            //return View("Index", viewmodel);
            //return View("Index");
            //return View();
            //return RedirectToAction("Index", viewModel);
           return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Remove(int personId)
            {
            PeopleViewModel.Remove(personId);
            //Person pToRemove = PeopleViewModel.People.Single(x => x.PersonId == personId);

            //PeopleViewModel.People.Remove(pToRemove);
           // pToRemove = null;
            //var p = PeopleViewModel.People.SingleOrDefault(c => c.PersonId == personId);
            //PeopleViewModel.People.Remove(p);
            //ModelState.Clear();
           // PeopleViewModel viewModel = new PeopleViewModel();
            //var pList = PeopleViewModel.People.ToList();
            //viewModel = pList();
           /*
            var viewmodel = new PeopleViewModel()
            {
                AllPeople = pList
            };
            */
            //return RedirectToAction("Index", new { personId = 0 });
            //return RedirectToAction("Index", viewmodel);
            return RedirectToAction("Index");
            //return View("Index");
        }

    }
}
