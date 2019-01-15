using System;
using System.Linq;

namespace _03.Iterator_Test
{
    class Program
    {
        static void Main()
        {
            var listIterator = new ListIterator();

            var inputLine = Console.ReadLine().Split();
            var args = inputLine.Skip(1).ToList();
            listIterator.Create(args);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(listIterator.Move());
                            break;
                        case "Print":
                            Console.WriteLine(listIterator.Print());
                            break;
                        case "HasNext":
                            Console.WriteLine(listIterator.HasNext());
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
