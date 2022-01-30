using System;

namespace Chapter11Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();     

            string[] laudatoryMessage = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
            string[] laudatoryStories = { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too.I am very satisfied." };
            string[] FirstName = { "Daniel", "Mary", "Hanna", "John" };
            string[] LastName = { "Johnson,", "Peterson,", "Charles,", "Francis," };
            string[] Cities = { "Moscow.", "Copenhagen.", "Berlin.", "New York.", "Madrid." };

            var laudatorymess = rand.Next(laudatoryMessage.Length);
            var message = laudatoryMessage[laudatorymess];

            var laudatoryStor = rand.Next(laudatoryStories.Length);
            var story = laudatoryStories[laudatoryStor];

            var firstName = rand.Next(FirstName.Length);
            var Name1 = FirstName[firstName];

            var lastName = rand.Next(LastName.Length);
            var Name2 = LastName[lastName];

            var cities = rand.Next(Cities.Length);
            var city = Cities[cities];

            Console.WriteLine($"{message} {story} {Name1} {Name2} {city}");

        }
    }
}
