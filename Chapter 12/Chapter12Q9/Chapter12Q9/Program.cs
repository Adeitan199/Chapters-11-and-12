using System;
using System.IO;

namespace Chapter12Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        static void ReadText()
        {
            string file = "user.txt";
            {
                try
                {
                    if (File.Exists(file))
                    {
                        var allUsers = File.ReadAllLines(file);

                    }
                }
                catch (FileNotFoundException)
                {
                    
                }
               

            }

        }
    }


}
