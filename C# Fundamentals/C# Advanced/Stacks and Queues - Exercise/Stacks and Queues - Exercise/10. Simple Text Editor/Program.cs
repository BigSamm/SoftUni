using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();
            var commands = new Stack<int>();
            var removedText = new Stack<string>();
            var addedChars = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var commandName = int.Parse(command[0]);

                if (commandName == 1)
                {
                    commands.Push(1);

                    var textToAppend = command[1];
                    text.Append(textToAppend);
                    
                    addedChars.Push(textToAppend.Length);
                }
                else if (commandName == 2)
                {
                    commands.Push(2);

                    var countToRemove = int.Parse(command[1]);
                    var currentRemovedText = text.ToString().Substring(text.Length - countToRemove, countToRemove);
                    removedText.Push(currentRemovedText);

                    text.Remove(text.Length - countToRemove, countToRemove);
                }
                else if (commandName == 3)
                {
                    var index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (commandName == 4)
                {
                    if(commands.Pop() == 1)
                    {
                        var countToRemove = addedChars.Pop();
                        text.Remove(text.Length - countToRemove, countToRemove);
                    }
                    else
                    {
                        var textToAppend = removedText.Pop();
                        text.Append(textToAppend);
                    }
                }
            }
        }
    }
}