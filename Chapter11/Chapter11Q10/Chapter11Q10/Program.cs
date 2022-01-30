using System;

namespace Chapter11Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string num = "45 50 5 90 100 83";

            string [] figures = (num.Split(" "));
            int figure1 = int.Parse(figures[0]);
            int figure2 = int.Parse(figures[1]);
            int figure3 = int.Parse(figures[2]);
            int figure4 = int.Parse(figures[3]);
            int figure5 = int.Parse(figures[4]);

            int sum = figure1 + figure2 + figure3 + figure4 + figure5;

            Console.WriteLine(sum);
        }
    }
}
