using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace mvcAlexKren.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Hacker()
        {
            return "You got hacked bae :)";
        }

        public IActionResult Welcome(string name, int numTimes = 1, int Id= 3 * 2)
        {
            ViewData["Message"] = $"Hello {name} Sinu id on {Id}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        
            
    }
}
