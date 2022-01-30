using System;
using System.Net;

namespace Chapter12Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            using (WebClient web0 = new WebClient()) 

                web0.DownloadFile("https://www.alislam.org/book/muhammad-in-the-bible/" , "a.pdf");
        }
    }
}
