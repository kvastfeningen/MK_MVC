using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using MK_MVC.Data;

namespace MK_MVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string SearchWord)
        {
           if(string.IsNullOrEmpty(SearchWord))
            {
                List<Person> persons = _context.People.ToList();
                 
                 var p = _context.People.ToList();
                 var viewModel = new PeopleViewModel()

                 {
                     AllPeople = p
                 };
                return View(viewModel);
            }
            else
            {
               
                var p = _context.People?.Where(s => s.Name.Contains(SearchWord) || s.City.Contains(SearchWord)).ToList(); //  || s.City.Contains(SearchWord)

                var viewModel = new PeopleViewModel()
                {
                    AllPeople = p
                };
               
                return View(viewModel);
              
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
                    PersonId = createPersonViewModel.PersonId,
                    Name = createPersonViewModel.Name,
                    Phone = createPersonViewModel.Phone,
                    City = createPersonViewModel.City
                };

                //CreatePersonViewModel.Add(newPerson);
                _context.People.Add(newPerson);
              _context.SaveChanges();
                return RedirectToAction("Index");
              
            }
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Remove(int Id)
        {
            // PeopleViewModel.Remove(Id);
            var personToRemove = _context.People.Find(Id);
            _context.People.Remove(personToRemove);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
       
    }
}
