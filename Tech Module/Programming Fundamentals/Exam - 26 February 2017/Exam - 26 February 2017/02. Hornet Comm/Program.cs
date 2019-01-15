using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipient = new List<string>();
            var message = new List<string>();
            var frequency = new List<string>();
            var broadcast = new List<string>();
            for (;;)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0] == "Hornet" && input[1] == "is" && input[2] == "Green")
                    break;

                char[] firstQuery = input[0].ToCharArray();
                char[] secondQuery = input[2].ToCharArray();

                if (IsFirstQueryOnlyOfDigits(firstQuery))
                {
                    if (IsQueryOnlyOfLettersOrDigits(secondQuery))
                    {
                        recipient.Add(string.Join("", firstQuery.Reverse()));
                        message.Add(string.Join("", secondQuery));
                    }
                }
                else if (IsFirstQueryAnythingButDigits(firstQuery))
                {
                    if (IsQueryOnlyOfLettersOrDigits(secondQuery))
                    {
                        ReverseUpperAndLowerCase(secondQuery);
                        frequency.Add(string.Join("", secondQuery));
                        broadcast.Add(string.Join("", firstQuery));
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcast.Count; i++)
                {
                    Console.WriteLine($"{frequency[i]} -> {broadcast[i]}");
                }
            }
            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < message.Count; i++)
                {
                    Console.WriteLine($"{recipient[i]} -> {message[i]}");
                }
            }
        }

        static void ReverseUpperAndLowerCase(char[] secondQuery)
        {
            for (int i = 0; i < secondQuery.Length; i++)
            {
                if (secondQuery[i] >= 65 && secondQuery[i] <= 90)
                    secondQuery[i] = Char.ToLower(secondQuery[i]);
                else if (secondQuery[i] >= 97 && secondQuery[i] <= 122)
                    secondQuery[i] = Char.ToUpper(secondQuery[i]);
            }
        }

        static bool IsFirstQueryAnythingButDigits(char[] firstQuery)
        {
            bool isTrue = true;
            for (int i = 0; i < firstQuery.Length; i++)
            {
                if (firstQuery[i] >= 48 && firstQuery[i] <= 57)
                    isTrue = false;
            }
            return isTrue;
        }

        static bool IsQueryOnlyOfLettersOrDigits(char[] secondQuery)
        {
            var isTrue = true;
            for (int i = 0; i < secondQuery.Length; i++)
            {
                if ((secondQuery[i] < 48 || secondQuery[i] > 57) &&
                    (secondQuery[i] < 65 || secondQuery[i] > 90) &&
                    (secondQuery[i] < 97 || secondQuery[i] > 122))
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }

        static bool IsFirstQueryOnlyOfDigits(char[] firstQuery)
        {
            var isTrue = true;
            for (int i = 0; i < firstQuery.Length; i++)
            {
                if (firstQuery[i] < 48 || firstQuery[i] > 57)
                    isTrue = false;
            }
            return isTrue;
        }
    }
}


