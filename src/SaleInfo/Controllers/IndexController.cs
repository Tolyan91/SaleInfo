﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleInfo.Controllers
{
    public class IndexController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is IndexController!";
        }
    }
}
