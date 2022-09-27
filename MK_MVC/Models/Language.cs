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
using System.ComponentModel.DataAnnotations;

namespace MK_MVC.Models
{
    public class Language
    {

        [Key]
        public int LanguageId { get; set; }

        //[Required]
        public string LanguageName { get; set; }

        //public int PersonId { get; set; }
       // public List<Person> People { get; set; }
        public List<PersonLanguage> PersonLanguages { get; set; }
    }
}
