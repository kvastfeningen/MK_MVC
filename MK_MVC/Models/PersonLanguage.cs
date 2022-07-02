using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MK_MVC.Models
{
    public class PersonLanguage
    {
        public int PersonId { get; set; }

        public Person Person { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

    }
}
