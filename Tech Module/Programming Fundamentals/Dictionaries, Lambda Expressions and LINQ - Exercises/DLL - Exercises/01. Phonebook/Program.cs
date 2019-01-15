using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            for (;;)
            {
                var command = Console.ReadLine().Split().ToList();

                if (command[0] == "A")
                    phonebook[command[1]] = command[2];

                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                        Console.WriteLine(command[1] + " -> " + phonebook[command[1]]);
                    else
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                }

                else if (command[0] == "END")
                    break;

            }




        }
    }
}
