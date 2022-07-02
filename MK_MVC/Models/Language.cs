using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MK_MVC.Models
{
    public class Language
    {

        [Key]
        public int LanguageId { get; set; }

        [Required]
        public string LanguageName { get; set; }

        // int PersonId { get; set; }
        //public List<Person> People { get; set; }
        public List<PersonLanguage> PersonLanguages { get; set; }
    }
}
