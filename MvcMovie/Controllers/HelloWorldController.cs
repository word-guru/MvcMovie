﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld
        //public string Index()
        //{
        //    return "This is my default action....";
        //}
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HElloWorld/Welcom
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

//[controller]/[ActionName]/[Parameters]
