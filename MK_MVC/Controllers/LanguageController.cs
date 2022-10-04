using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using MK_MVC.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Net;
using MK_MVC.Migrations;

namespace MK_MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LanguageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Language> listOfLanguages = _context.Languages.ToList();
            return View(listOfLanguages);
            //var p = _context.People.Include(pl => pl.PersonLanguages).Where(s => s.PersonId.Contains(s.PersonId)).ToList();
            /*
             var viewModel = (from a in _context.PersonLanguages
                             join b in _context.Languages on a.LanguageId equals b.LanguageId
                             join c in _context.People on a.PersonId equals c.PersonId
                             select new ShowLanguageViewModel
                             {
                                 Language = b.LanguageName,
                                 Name = c.Name,

                             }).ToList();
            */

            /*
                         List < Language > listOfLanguages = _context.Languages
                 .Include(pl => pl.PersonLanguages)
                 .ToList();
               */


            return View();
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Language language)
        {

            if (ModelState.IsValid)
            {
                _context.Languages.Add(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult ShowPeopleLanguages (int Id)
        {
            var personDetails = _context.People.Find(Id);

            var apl = _context.PersonLanguages?.Include(p => p.Person).Include(l => l.Language).Where(s => s.LanguageId.Equals(Id)).ToList(); //  || s.City.Contains(SearchWord)

            var viewModel = new ShowLanguageViewModel()
            {
                AllPeopleLanguages = apl
            };
            return View(viewModel);
        }

        /*
        public IActionResult Details()
        {
            var vm = new ShowLanguageViewModel();
            vm.Languages = _context.Languages
                .Include(pl => pl.PersonLanguages.Select(i=>i.PersonId))
                .Include(p=>p.PersonLanguages);

            return View(vm);;
        }
        */
    }
}

/*
ShowLanguageViewModel showLanguageViewModel = new ShowLanguageViewModel()
            {
               
            };
*/