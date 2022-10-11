using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;
using MK_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MK_MVC.Controllers
{
    //[Route("api/[ReactController]")]
    [ApiController]
    public class ReactController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }
        //[EnableCors("AllowReact")]

        [HttpGet]
        [Route("api/people")]
        public IEnumerable<Person> GetAllPeople()
        {
            List<Person> listOfPeople = _context.People.ToList();



            return (listOfPeople);
        }


        [HttpGet]
        [Route("api/create")]
        public IEnumerable<Person> CreatePerson(int id)
        {
            List<Person> PersonDetails = _context.People.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(s => s.PersonId.Equals(id)).ToList();
            //var p = _context.People?.Where(s => s.PersonId.Equals(id)).ToList(); //  || s.City.Contains(SearchWord)



            return (PersonDetails);
        }


        [HttpGet]
        [Route("api/details")]
        public IEnumerable<Person> GetPerson(int id)
        {
           // List<Person> PersonDetails = _context.People.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(s => s.PersonId.Equals(id)).ToList();
            var p = _context.People?.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(p => p.PersonId == id).ToList(); //  || s.City.Contains(SearchWord)
           


            return (p);
        }

        [HttpPost]
        [Route("api/delete")]
        public IActionResult Remove(int Id)
        {
            // PeopleViewModel.Remove(Id);
            var personToRemove = _context.People.Find(Id);
            _context.People.Remove(personToRemove);
            _context.SaveChanges();

            return Ok();
        }
    
    }
}
