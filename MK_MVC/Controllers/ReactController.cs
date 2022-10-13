using Microsoft.AspNetCore.Cors;
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
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
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

        
        [HttpPost]
        [Route("api/create")]
        public IActionResult CreatePerson(Person p)
        {
            Person person = new Person();
            person.PersonId = p.PersonId;
            person.Name = p.Name;
            person.Phone = p.Phone;
            person.City = p.City;

            _context.People.Add(person);
            _context.SaveChanges();

            return Ok();
        }
        

        [HttpGet]
        [Route("api/details")]
        public object Details(int id)
        {
            // List<Person> PersonDetails = _context.People.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(s => s.PersonId.Equals(id)).ToList();

            //var p = _context.People?.Include(pl => pl.PersonLanguages).Include(p => p.City).Where(p => p.PersonId == id).ToList().FirstOrDefault();  //  || s.City.Contains(SearchWord)
            var p = _context.People?.Include(p => p.City).Where(p => p.PersonId == id).ToList().FirstOrDefault();  //  || s.City.Contains(SearchWord)
            /*
            if (p.PersonId > 0)
            {

                p.Name = Person.Name;
                p.Phone = st.Rollno;
                p.City = st.Address;

                Person person = new Person();
            person.PersonId = p.PersonId;
            person.Name = p.Name;
            person.Phone = p.Phone;
            person.City = p.City;
           */

            return (p);
        }
    
        [Route("api/delete/{id}")]
        [HttpDelete]
        //[ProducesResponseType(200)]
        public async Task<IActionResult> Delete(int id)
        //public Object Delete(int id)
        {
            //var personToRemove = await _context.People.FindAsync(id);
            
            //var personToRemove = _context.People.Find(id);
            var personToRemove = _context.People.Where(x => x.PersonId == id).ToList().FirstOrDefault();

            if (personToRemove == null)
            {
                return NotFound();
            }

            _context.People.Remove(personToRemove);
            //_context.SaveChanges();
            await _context.SaveChangesAsync();

            return NoContent();
            //return Ok();
        }
    

        /*
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(long id)
        {
            var personToRemove = await _context.People.FindAsync(id);

            if (personToRemove == null)
            {
                return NotFound();
            }

            _context.People.Remove(personToRemove);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonItemExists(long id)
        {
            return _context.People.Any(e => e.PersonId == id);
        }

        private static PersonDTO PersonToDTO(Person personToRemove) =>
            new TodoItemDTO
            {
                Id = personToRemove.PersonId,
                Name = personToRemove.Name,
                IsComplete = personToRemove.IsComplete
            };
        */
    }
}
