using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MK_MVC.ViewModels
{



	public class PeopleViewModel
	{
		public static List<Person> People = new List<Person>()

		{
			new Person ("Howard Bishop", "(749) 863-3748", "Guápiles"),
			new Person ("Derek Dixon", "(542) 246-1009", "Valéncia"),
			new Person ("Nathan Gilbert", "1-676-671-1754", "Lauro de Freitas"),
			new Person ("Clementine Michael", "(385) 763-6528", "Uberlândia"),
			new Person ("Elliott Carrillo", "(950) 400-6396", "Canberra"),
		};
        internal List<Person> viewModel;

        public int PersonId { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		
		
		public static void Remove(int personId)
		{
            
            var item = People.Single(x => x.PersonId == personId);

			People.Remove(item);

		}
		public List<Person> AllPeople { get; set; }
		public PeopleViewModel()
		{
			
		AllPeople = new List<Person>(People);
		
		}

	}	
}

