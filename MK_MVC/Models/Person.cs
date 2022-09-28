using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MK_MVC.Models
{
    public class Person
    {
       
        [Key]
        public int PersonId { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        //[Required]
        // public string CityName { get; set; }

        
        //[Required]
       public int CityId { get; set; }
        public City City { get; set; }

        //public List<Language> Languages { get; set; }
        public List<PersonLanguage> PersonLanguages { get; set; }

        
    }
}
