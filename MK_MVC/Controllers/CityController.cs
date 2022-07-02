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
    public class CityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<City> listOfCities = _context.Cities.ToList();
            return View(listOfCities);
        }

        public IActionResult Create()
        {

            ViewBag.Countries = new SelectList(_context.Countries, "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(string cityname, int countryid)
        {
            City c = new City
            {
                CityName = cityname,
                CountryId = countryid
            };

            _context.Cities.Add(c);
                //_context.Cities.Add(countryid);
                _context.SaveChanges();
                return RedirectToAction("Index");
         
            //return View();
        }

    }
}
