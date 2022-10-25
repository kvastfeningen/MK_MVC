﻿using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;
using MK_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Http;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MK_MVC.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("api/people")]
        public IEnumerable<Person> GetAllPeople()
        {
            List<Person> listOfPeople = _context.People.ToList();

            return listOfPeople;
        }

        [Route("api/people")]
        [HttpGet("{id:int}")]
        // [HttpGet]
        
        public ActionResult<Person> GetPerson(int id)
        {
            //Person p = new Person();
            //var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault(); //List<Person> listOfPeople = _context.People.ToList();
            var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault();
            //var p = _context.People.Find(id);

            if (p == null)
            {
                return NotFound();
            }
            return p;
        }

        [HttpGet]
        [Route("api/cities")]
        public IEnumerable<City> GetAllCities()
        {
            // List<City> listOfCities = _context.Cities.Include(p => p.Country).Where(c => c.CityId == id).ToList();
            List<City> listOfCities = _context.Cities.ToList();


            return (listOfCities);
        }

        /*[Route("api/details")]
        [HttpGet("{id}")]
        //[HttpGet]
        public object Details(int id)
        //public IActionResult Details(int id)
        //public async Task<IActionResult> Details(int id)
        {
            
            var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault();*/
        [Route("api/details/{id}")]
         [HttpGet("{id:int}")]
        //[HttpGet]
        public ActionResult<Person> GetP(int id)
            {
            var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault();
            //var p = _context.People.FirstOrDefault((p) => p.PersonId == id);
                if (p == null)
                {
                    return NotFound();
                }
                return p;
            }

        

        [Route("api/create")]
        [HttpPost]
          public IActionResult CreatePerson(object p)
        {
            ReactPerson rperson = JsonSerializer.Deserialize<ReactPerson>(p.ToString());
            
            Person person = new Person();
            person.PersonId = rperson.PersonId;
            person.Name = rperson.Name;
            person.Phone = rperson.Phone;
            person.CityId = Convert.ToInt32(rperson.CityId);
            
            _context.People.Add(person);
            _context.SaveChanges();

            return Ok();
        }



        [Route("api/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            
            var personToRemove = _context.People.Where(x => x.PersonId == id).ToList().FirstOrDefault();

            if (personToRemove == null)
            {
                return NotFound();
            }

            _context.People.Remove(personToRemove);
        
            _context.SaveChanges();

            return NoContent();
          
        }
    

       
    }
}
