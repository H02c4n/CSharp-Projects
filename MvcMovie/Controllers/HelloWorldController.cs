using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Controllers
{
    // [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 2)
        {
            ViewData["Msg"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}