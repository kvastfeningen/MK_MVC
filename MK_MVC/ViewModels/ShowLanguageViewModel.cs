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

        public Person Person { get; set; }
        public Language Language { get; set; }
        public PersonLanguage PersonLanguage { get; set; }

        public int PersonId { get; set; }
        public string Name { get; set; }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<PersonLanguage> PersonLanguages { get; set; }

       public int Pid = PersonLanguage.PersonId;

        List<string>

    }
}

