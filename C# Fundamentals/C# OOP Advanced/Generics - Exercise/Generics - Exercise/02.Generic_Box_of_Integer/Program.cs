using System;

namespace _02.Generic_Box_of_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var num = int.Parse(Console.ReadLine());
                var box = new Box<int>(num);
                Console.WriteLine(box);
            }
        }
    }
}
