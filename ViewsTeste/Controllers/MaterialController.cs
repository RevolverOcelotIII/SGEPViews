﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewsTeste.Controllers
{
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View("MaterialView");
        }
    }
}