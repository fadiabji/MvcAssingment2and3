﻿using Microsoft.AspNetCore.Mvc;

namespace mvcDemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
