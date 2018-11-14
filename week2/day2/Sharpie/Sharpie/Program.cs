using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie haha = new Sharpie("red",3.0f);
            haha.use();
            Console.WriteLine("{0}{1}{2}", haha.Color, haha.Width, haha.InkAmount);

        }
    }
    class Sharpie
    {
        public string Color;
        public float Width;
        public float InkAmount;

        public void use()
        {
            InkAmount -= 1;
        }

        public Sharpie (string color,float width)
        {
            this.Color = color;
            this.Width = width;
            InkAmount = 100;
            
    }
    }




}
