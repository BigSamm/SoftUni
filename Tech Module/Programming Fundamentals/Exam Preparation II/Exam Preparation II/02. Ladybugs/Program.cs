using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            var ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .Where(x => x >= 0 && x < size)
                .ToList();
            for (int i = 0; i < ladybugIndexes.Count; i++)
            {
                field[ladybugIndexes[i]] = 1;
            }

            for (;;)
            {
                var command = Console.ReadLine().Split().ToList();
                if(command[0] == "end")
                {
                    break;
                }
                var index = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if(index < field.Length && index >= 0)
                {
                    if(field[index] == 1)
                    {
                        field[index] = 0;
                        if(direction == "right")
                        {
                            try
                            {
                                index += flyLength;
                                while (field[index] != 0)
                                {
                                    index += flyLength;
                                }
                                field[index] = 1;
                            }
                            catch{ }
                        }
                        else if(direction == "left")
                        {
                            try
                            {
                                index -= flyLength;
                                while (field[index] != 0)
                                {
                                    index -= flyLength;
                                }
                                field[index] = 1;
                            }
                            catch { }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
