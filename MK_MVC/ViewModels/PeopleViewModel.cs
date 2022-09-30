﻿using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;

namespace MK_MVC.ViewModels
{



	public class PeopleViewModel
	{

		public int PersonId { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
       
        public City City { get; set; }

		
		public List<Person> AllPeople { get; set; }

	}	
}

