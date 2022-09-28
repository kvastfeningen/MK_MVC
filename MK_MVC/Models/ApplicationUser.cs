﻿using Microsoft.AspNetCore.Identity;

namespace MK_MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
    }
}
