using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;
using System.Net;

namespace MK_MVC.ViewModels
{
    

    public class ShowLanguageViewModel
    {

        //public IEnumerable<Language> Languages { get; set; }
       // public IEnumerable<Person> People { get; set; }
        //public IEnumerable<PersonLanguage> PersonLanguages { get; set; }

       
        public string Language { get; set; }
        public string Name { get; set; }

        public int LanguagId { get; set; }
        public string LanguageName { get; set; }

        public Person Person { get; set; }


        public List<PersonLanguage> AllPeopleLanguages { get; set; }


    }
}

