﻿using Microsoft.AspNetCore.Mvc;

namespace Bankk2.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
