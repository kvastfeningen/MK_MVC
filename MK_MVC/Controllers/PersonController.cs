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
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Remove(int Id)
        {
            PeopleViewModel.Remove(Id);
            
            return RedirectToAction("Index");
        }
       
    }
}
