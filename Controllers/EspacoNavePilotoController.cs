﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceshipManager.Controllers
{
    public class EspacoNavePilotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}