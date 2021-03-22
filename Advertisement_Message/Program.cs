using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pharses = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrase = new Random();
            Random eventts = new Random();
            Random author = new Random();
            Random city = new Random();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int pharseIn = phrase.Next(0, pharses.Length);
                int eventIn = phrase.Next(0, events.Length);
                int auhtorIn = phrase.Next(0, authors.Length);
                int citiesIn = phrase.Next(0, cities.Length);

                Console.WriteLine($"{pharses[pharseIn]} {events[eventIn]} {authors[auhtorIn]} - {cities[citiesIn]}");
            }
        }
    }
}
