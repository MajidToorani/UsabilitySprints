using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsabilitySprints.Models;

namespace UsabilitySprints.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult B2D()
        {
            return View();
        }
        [HttpPost]
        public IActionResult B2D(ConvertViewModel myNumber, string value)
        {
            if (value == "B2D")
            {
                myNumber.Result = myNumber.DB(myNumber.Decimal);
            }
            if (value == "B2D")
            {
                myNumber.Result = myNumber.BD(myNumber.Binary);
            }
            return View(myNumber);
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }        
    }
}
