using System;

namespace CreatingAndUsingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cat cat = new Cat("Perry", 1.6);

            cat.SayMiau();
            
            
        }
    }
}

namespace CreatingAndUsingObjects
{
    public class Cat
    {
        public string Name;

        public double Weight;

        public Cat(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void SayMiau()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Cat {i} said Miau");
            }
           
        }

    }


    public class Sequence
    {

    }
}


