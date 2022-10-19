﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;
using MK_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MK_MVC.Controllers
{
  
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

            return (listOfPeople);
        }

        [HttpGet]
        [Route("api/cities")]
        public IEnumerable<City> GetAllCities()
        {
           // List<City> listOfCities = _context.Cities.Include(p => p.Country).Where(c => c.CityId == id).ToList();
            List<City> listOfCities = _context.Cities.ToList();


            return (listOfCities);
        }

        [Route("api/details/{id}")]
        [HttpGet]
        public object Details(int id)
        //public object Details(int id)
        //public async Task<IActionResult> Details(int id)
        {
            // List<Person> PersonDetails = _context.People.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(s => s.PersonId.Equals(id)).ToList();

            //var p = _context.People?.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(p => p.PersonId == id).ToList().FirstOrDefault();  //  || s.City.Contains(SearchWord)
            //var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault();  

            var p = _context.People?.Where(p => p.PersonId == id).ToList().FirstOrDefault();  
            /*
            if (p.PersonId > 0)
            {
            */
            /*
                Person person = new Person();
                person.PersonId = p.PersonId;
                person.Name = p.Name;
                person.Phone = p.Phone;
                person.City = p.City;

                //return Ok();
                return person;
            }

            Include(p => p.City).
            */
            return p;

        }

        [Route("api/create")]
        [HttpPost]
        public async Task<IActionResult> CreatePerson(Person p)
        //public object CreatePerson(Person p)
        {
            Person person = new Person();
            
            person.Name = p.Name;
            person.Phone = p.Phone;
            person.CityId = p.City.CityId;
            //person.City = p.City;
            _context.People.Add(person);
            await _context.SaveChangesAsync();

            return Ok();
        }



        [Route("api/delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            
            var personToRemove = _context.People.Where(x => x.PersonId == id).ToList().FirstOrDefault();

            if (personToRemove == null)
            {
                return NotFound();
            }

            _context.People.Remove(personToRemove);
        
            await _context.SaveChangesAsync();

            return NoContent();
          
        }
    

       
    }
}
