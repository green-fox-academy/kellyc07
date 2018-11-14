using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.eat();
            dog.drink();
           
            Console.WriteLine("{0}\n{1}\n", dog.hunger, dog.thirst);
            
        }

        class Animal
        {
            public int hunger = 50;
            public int thirst = 50;



            public void eat()
            {
                hunger -= 1;
            }

            public void drink()
            {
                thirst -= 1;
            }
            public void play()
            {
                thirst += 1;
                hunger += 1;
            }

        }
    }
}

