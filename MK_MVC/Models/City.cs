using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MK_MVC.Models;
using MK_MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using MK_MVC.Data;
using System.ComponentModel.DataAnnotations;

namespace MK_MVC.Models
{
    public class City
    {
        //[Key]
       // public int CityId { get; set; }
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public List<Person> People { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }


    }
}