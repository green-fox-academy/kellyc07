using Microsoft.AspNetCore.Mvc;
using newapplication.Models;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapplication.Controllers
{
        [Route("web")]
        public class WebController : Controller
        {
            [HttpGet("greeting")]
            public IActionResult Greeting()
            {
                var greeting = new Greeting(1, "from the model")
                {
                   
                };

                return View(greeting);
            }
        }
    
}
