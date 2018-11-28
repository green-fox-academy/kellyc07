using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapplication.Models
{
    
    public class RestController
    {
         static int id = 0;
        [HttpGet("api/greeting")]
  

        public Greeting Greet(string name)
        {
            int id = 0;
            return new Greeting(id++, name);
        }
     
           
       

       
        





    }
       
    
}

