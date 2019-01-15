using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if(command[0] == "Distinct")
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
                    arr[place] = command[2];
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
