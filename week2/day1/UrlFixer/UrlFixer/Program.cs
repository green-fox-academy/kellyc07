using System;
using System.Text;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string b = url.Replace("bots", "odds");

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            
            Console.WriteLine(b);
               
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            StringBuilder a = new StringBuilder(b);
            a.Insert(5, ":");
            // Try to solve it more than once using different string functions!

            Console.WriteLine(a);
        }
    }
}
