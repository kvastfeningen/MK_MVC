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

            var viewModel = (from a in _context.PersonLanguages
                            join b in _context.Languages on a.LanguageId equals b.LanguageId
                            join c in _context.People on a.PersonId equals c.PersonId
                            select new ShowLanguageViewModel
                            {
                                Language = b.LanguageName,
                                Name = c.Name,

                            }).ToList();
            /*
                         List < Language > listOfLanguages = _context.Languages
                 .Include(pl => pl.PersonLanguages)
                 .ToList();
               */

            return View(viewModel);
            
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