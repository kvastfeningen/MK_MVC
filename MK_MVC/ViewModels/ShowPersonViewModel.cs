﻿using Microsoft.AspNetCore.Mvc;
using MK_MVC.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Data;
using System.Net;

namespace MK_MVC.ViewModels
{
    public class ShowPersonViewModel
    {

        public Person Person { get; set; }
        public Language Language { get; set; }
        public PersonLanguage PersonLanguage { get; set; }
    }
}