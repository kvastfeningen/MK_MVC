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
            List<Language> listOfLanguages = _context.Languages
                .Include(pl => pl.PersonLanguages)
                .ToList();

            //List<PersonLanguage> listOfPersonLanguages = _context.PersonLanguages.Include(p => p.People).ToList();
            //List<Person> listOfPersonLanguages = _context.People.Include(p => p.PersonLanguages).ToList();
            
            return View(listOfLanguages);
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

        public IActionResult Details()
        {
            var viewModel = new ShowLanguageViewModel();
            viewModel.Languages = _context.Languages
                .Include(pl => pl.PersonLanguages.Select(i=>i.PersonId))
                .Include(p=>p.PersonLanguages);

            return View(viewModel);;
        }

    }
}

/*
ShowLanguageViewModel showLanguageViewModel = new ShowLanguageViewModel()
            {
               
            };
/*