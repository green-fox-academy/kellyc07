

using System;

namespace AverageOfInput17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,

            /*Console.WriteLine("please enter 5 integers");
            Console.ReadLine();
            // then it should print the sum and the average of these numbers like:
            /*int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            */
            //Console.WriteLine("Sum:{0}, Average:{1}", numbers);

            //
            // Sum: 22, Average: 4.4
            Console.Write("please input 5 intergers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];
            double sum = 0;
            for (int i = 0; i < a.Length; i++) ;
            {
                Console.WriteLine();
                sum += num;
            }
            Console.WriteLine("sum:{0},average:{1}", sum, sum / a.Length);
            Console.ReadKey();
            double result = add(1.2, 3.4);
        }
    }
}
