using System;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var lake = new Lake(stones);
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
