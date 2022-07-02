using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MK_MVC.ViewModels
{
	
	public class CreatePersonViewModel
	{
		//public List<SelectListItem> Cities { get; set; }
		public int PersonId { get; set; }

		[Required(ErrorMessage = "You must insert name!")]
		public string Name { get; set; }

		
		public string Phone { get; set; }

		[Required(ErrorMessage = "You must insert city!")]
		public City City { get; set; }
		public List<SelectListItem> Cities { get; set; }
		/*
				public static void Add(Person newperson)
				{
					//_context.People.Add()
					//_context.SaveChanges();
					PeopleViewModel.People.Add(newperson);
				}

		*/
	}

	
}
