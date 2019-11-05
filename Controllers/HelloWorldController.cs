﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        //public string index(){
        //    return "this is my default action...";
        //}

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1) {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}