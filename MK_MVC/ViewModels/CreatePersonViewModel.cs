using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MK_MVC.ViewModels
{
	
	public class CreatePersonViewModel
	{
		
		public int PersonId { get; set; }

		[Required(ErrorMessage = "You must insert name!")]
		public string Name { get; set; }

		
		public string Phone { get; set; }

		[Required(ErrorMessage = "You must insert city!")]
		public string City { get; set; }


		public static void Add(Person newperson)
		{
			PeopleViewModel.People.Add(newperson);
		}


	}

	
}
