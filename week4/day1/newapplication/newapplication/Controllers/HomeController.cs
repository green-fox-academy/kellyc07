using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapplication.Controllers
{
    public class HomeController
    {
        [Route("/")]
        public string Index()
        {
            return "Hello from the Controller!"; 
        }
        

    }
}
