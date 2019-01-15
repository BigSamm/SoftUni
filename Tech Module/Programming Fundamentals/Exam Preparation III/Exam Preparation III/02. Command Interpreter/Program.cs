using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < 20; i++)
            {
                var command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if(command[0] == "end")
                {
                    break;
                }

                if( (command[0] == "reverse" || command[0] == "sort") && ((int.Parse(command[2]) < 0 || int.Parse(command[2]) >= input.Length) || (int.Parse(command[4]) < 0) ||
                        int.Parse(command[2]) + int.Parse(command[4]) - 1 >= input.Length) )
                {
                        Console.WriteLine("Invalid input parameters.");
                }

                else if( (command[0] == "rollLeft" || command[0] == "rollRight") && (int.Parse(command[1]) < 0) )
                {
                        Console.WriteLine("Invalid input parameters.");
                }

                else if (command[0] == "reverse")
                {
                    CompleteReverseCommand(command, input);
                }

                else if(command[0] == "sort")
                {
                    CompleteSortCommand(command, input);
                }

                else if(command[0] == "rollLeft")
                {
                    CompleteRollLeftCommand(command, input);
                }

                else if(command[0] == "rollRight")
                {
                    CompleteRollRightCommand(command, input);
                }
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        static void CompleteRollRightCommand(string[] command, string[] input)
        {
            var count = int.Parse(command[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            var result = new string[input.Length];
            for (int oldIndex = 0; oldIndex < input.Length; oldIndex++)
            {
                var newIndex = oldIndex + count;
                newIndex %= input.Length;
                if(newIndex < 0)
                {
                    newIndex += input.Length;
                }
                result[newIndex] = input[oldIndex]; 
            }
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = result[i];
            }
        }

        static void CompleteRollLeftCommand(string[] command, string[] input)
        {
            var count = int.Parse(command[1]);

            var result = new string[input.Length];
            for (int oldIndex = 0; oldIndex < input.Length; oldIndex++)
            {
                var newIndex = oldIndex - count;
                while(newIndex < 0)
                {
                    newIndex += input.Length;
                }
                result[newIndex] = input[oldIndex];
            }
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = result[i];
            }
        }

        static void CompleteSortCommand(string[] command, string[] input)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);
            
            Array.Sort(input, start, count);
        }

        static void CompleteReverseCommand(string[] command, string[] input)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);

            Array.Reverse(input, start, count);
        }
    }
}
