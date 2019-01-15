using System;

namespace _07._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors = 
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random phraseIndex = new Random();
            Random eventIndex = new Random();
            Random authorIndex = new Random();
            Random cityIndex = new Random();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string phrase = phrases[phraseIndex.Next(0, phrases.Length - 1)];
                string @event = events[eventIndex.Next(0, events.Length - 1)];
                string author = authors[authorIndex.Next(0, authors.Length - 1)];
                string city = cities[cityIndex.Next(0, cities.Length - 1)];

                string ad = $"{phrase} {@event} {author} - {city}";
                Console.WriteLine(ad);
            }
        }
    }
}