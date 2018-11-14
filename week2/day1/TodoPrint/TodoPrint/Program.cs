using System;
using System.Text;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Add "My todo:" to the beginning of the todoText
            string todoText = " - Buy milk\n";
            StringBuilder a = new StringBuilder(todoText);
            a.Insert(0, "my todo:\n");
            a.Insert(20, " \n - Download games\n" + "    - Diablo");
            Console.WriteLine(a);
            
            



            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            

        }
    }
}
