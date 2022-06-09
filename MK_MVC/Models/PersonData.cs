using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MK_MVC.Models
{
    public class PersonData
    {

		/*

		//GetAll
		public static List<Person> GetAll()
		{
			return Persons;
		}
		*/
		//Add

		
		/*
		//Remove
		public static void Remove(string name)
        {
			Person personToRemove = GetByName(name);
			Persons.Remove(personToRemove);
			
        }

		//GetById
		public static Person GetByName(string name)
        {
			return Persons.SingleOrDefault(x => x.Name == name);
        }
		

		public static Person SearchThis(string searchBy, string SearchWord)
		{
			
			if (!string.IsNullOrEmpty(SearchWord))
			{
				if (searchBy == "Name")
				{
					//return (Person)Persons.Find(s => s.Name.Contains(SearchWord));
					List<Person> p = Persons.Where(s => s.Name.Contains(SearchWord)).ToList();
				}
				else
				{
					return Persons.Find(s => s.City.Contains(SearchWord));
				}
			}
			return null;
		}

        
        /*
public static Person SearchThis(string SearchWord)
{
    return Persons.Find(x => x.Name.Contains(SearchWord));
}
*/
    }
}
