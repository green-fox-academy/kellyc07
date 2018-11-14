using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "some text";
            //int[] intArray = new[] { 1, 2, 3 };
            //Console.WriteLine(intArray[1]);
            Console.WriteLine(text[2]);
            Console.WriteLine(text.Length);
            Console.WriteLine(text.Substring(0, 4));

            String text = "Alex;22;175";
            string[] arrayOfDate = text.Split(";");
            foreach (var data in arrayOfDate)
            {
                Console.WriteLine(date);
            }

            // you can modify 
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            text += "hello";

            List<int> intList = new List<int>() { 1, 2, 3 };//()  add many elements compare to array
            //arraylist<int> intlist = new arraylist(); //不可用
            //List<List<int>> intList = new List<int>();
           

            intList.Add(5);
            intList.Add(2);
            intList.Add(1);
           // Console.WriteLine(intList.ToString());
           foreach (var element  in intList)
            {
                Console.WriteLine(element);

            }

           for (int i =0; i< intList.Count;i++)
            {
                Console.WriteLine(intList[1]);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Console.WtireLine(dict[1]);//key 1
            //Console.WriteLine(intList[1]);// index 1

            foreach (var element in dict) 
            {
                Console.WriteLine(element);
            }

            for(int i =0; i<dict.Count; i++)
            {
                Console.WriteLine(dict[i]);//moreuseful way: dict.ElementAt(i)
            }
            dict.Elementat(int)
            //dict.Add(1, "something"); //key should be only don't use one again
            Console.ReadLine;

            // if(dict,ContainsKey(4))
            // {//

            // }//check

            string result;
            if(dict.TryGetValue("2", out result))
            {

            }


        }
    }
}
