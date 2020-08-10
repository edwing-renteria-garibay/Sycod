﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sycod.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   

        public IActionResult Filosofia()
        {
            return View("Views/Empresa/Filosofia/index.cshtml");
        }
    }

}