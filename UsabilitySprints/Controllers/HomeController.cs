using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsabilitySprints.Models;

/*
 * Majid Tooranisama
 * Assignment # 2 , Created : Feb 22, 2019
 */

namespace UsabilitySprints.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ConvertViewModel myNumber, string command)
        {
            if (command == "D2B")
            {
                myNumber.Result1 = DB(myNumber.Decimal);
            }
            if (command == "B2D")
            {
                myNumber.Result2 = BD(myNumber.Binary);
            }
            return View(myNumber);
        }

        [HttpGet]
        public IActionResult B2D()
        {
            return View();
        }

        [HttpPost]
        public IActionResult B2D(ConvertViewModel myNumber, string command)
        {
            if (command == "D2B")
            {
                myNumber.Result1 = DB(myNumber.Decimal);
            }
            if (command == "B2D")
            {
                myNumber.Result2 = BD(myNumber.Binary);
            }
            return View(myNumber);
        }

        public string DB(int decimalNumber)
        {
            try
            {
                if (decimalNumber < 2)
                    return decimalNumber.ToString();

                var divisor = decimalNumber / 2;
                var remainder = decimalNumber % 2;

                return DB(divisor) + remainder;
            }
            catch (Exception)
            {
                return "Invalid input";
            }
                        
        }

        public string BD(string binary)
        {
            try
            {
                string decimalNumber = Convert.ToInt32(binary, 2).ToString();
                return decimalNumber;
            }
            catch(Exception)
            {
                return "Invalid input";
            }            
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
