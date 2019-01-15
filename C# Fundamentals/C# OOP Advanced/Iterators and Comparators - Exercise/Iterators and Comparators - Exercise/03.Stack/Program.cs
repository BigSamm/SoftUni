using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack<string>();            

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var args = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var command = args[0];

                try
                {
                    switch (command)
                    {
                        case "Push":
                            var items = args.Skip(1).ToArray();
                            stack.Push(items);
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
