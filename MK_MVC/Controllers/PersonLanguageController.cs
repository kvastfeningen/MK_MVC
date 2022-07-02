using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using MK_MVC.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MK_MVC.Controllers
{
    public class PersonLanguageController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PersonLanguageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Language = new SelectList(_context.Languages, "LanguageId", "LanguageName");

            ViewBag.People = new SelectList(_context.People, "PersonId", "Name");


            return View();
        }

        [HttpPost]
        public IActionResult Create(int languageid, int personid)
        {
            
            PersonLanguage model = new PersonLanguage();
            
            model.LanguageId = languageid;
            model.PersonId = personid;
            _context.PersonLanguages.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Create");

            //return View();
        }

    }
}
