using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapplication.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public Greeting(long number, string content)
        {
            this.Id = number;
            this.Content = content;
        }
    }
}
//  Greeting greeting = new Greeting(1, name);
       //     return greeting;
        
       // Greeting greeting = new Greeting(1,"Hello, world!");