using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (;;)
            {
                var command = Console.ReadLine();
                var commandList = command.Split(' ').ToList();
                if(commandList[0] == "Even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0)
                            Console.Write(nums[i] + " ");
                    }
                    break;
                }
                else if (commandList[0] == "Odd")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 1)
                            Console.Write(nums[i] + " ");
                    }
                    break;
                }
                else if (commandList[0] == "Delete")
                    nums.RemoveAll(x => x == int.Parse(commandList[1]));
                else if (commandList[0] == "Insert")
                    nums.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
            }
        }
    }
}
