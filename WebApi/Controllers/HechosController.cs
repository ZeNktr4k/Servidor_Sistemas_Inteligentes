﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class HechosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}