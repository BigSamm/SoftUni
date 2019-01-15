using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            var invalidInputsCount = 0;

            for (;;)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }

                else if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }

                else if (command[0] == "Replace")
                {
                    var place = int.Parse(command[1]);
                    if (place >= 0 && place <= arr.Length - 1)
                        arr[place] = command[2];
                    else
                        invalidInputsCount++;
                }

                else if (command[0] == "END")
                    break;

                else
                    invalidInputsCount++;
            }

            for (int i = 0; i < invalidInputsCount; i++)
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
