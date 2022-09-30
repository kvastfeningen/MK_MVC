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
		public int PersonId { get; set; }

		[Required(ErrorMessage = "You must insert name!")]
		public string Name { get; set; }

		public string Phone { get; set; }

		[Required(ErrorMessage = "You must insert city!")]
		public City City { get; set; }

        public int CityId { get; set; }
        public List<SelectListItem> Cities { get; set; }
		
	}

}
