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
        [Required]
        public string City { get; set; }
        
        private static int nextId = 1;

        public Person(string name, string phone, string city)
        {
            PersonId = nextId++;
            Name = name;
            Phone = phone;
            City = city;

        }
        public Person()
            {
                PersonId = nextId;
                nextId++;
            }
        }
}
