using System;

namespace variables2_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables交换变量的值
            int a = 123;
            int b = 526;
            /*
            string s1 = a.ToString();
            string s2 = Convert.ToString(a);
            string s3 = b.ToString();
            string s4 = Convert.ToString(b);
            */
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"print{a},{b}");
           
        }
    }
}
