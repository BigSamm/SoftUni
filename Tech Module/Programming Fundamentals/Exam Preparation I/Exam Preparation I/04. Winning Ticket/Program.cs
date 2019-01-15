using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var winningSymbols = new List<char> { '@', '#', '$', '^' };

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Length == 20)
                {
                    var leftHalf = tickets[i].Take(10).ToList();
                    var rightHalf = tickets[i].Skip(10).Take(10).ToList();
                    var symbolAndMaxCountInLeftHalf = GetMaxCountOfWinningSymbol(leftHalf, winningSymbols, i);
                    var symbolAndMaxCountInRightHalf = GetMaxCountOfWinningSymbol(rightHalf, winningSymbols, i);

                    var isWin = false;
                    var isJackpot = false;
                    char symbol = '\0';
                    var count = 0;
                    foreach (var a in symbolAndMaxCountInLeftHalf)
                    {
                        foreach (var b in symbolAndMaxCountInRightHalf)
                        {
                            if (a.Key == b.Key && b.Value >= 6 && a.Value >= 6)
                            {
                                if (b.Value == a.Value && a.Value == 10)
                                {
                                    isJackpot = true;
                                }
                                isWin = true;
                                symbol = a.Key;
                                count = Math.Min(a.Value, b.Value);
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                            }
                        }
                    }

                    if (isWin)
                    {
                        if (isJackpot)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {count}{symbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {count}{symbol}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }




        }

        static Dictionary<char, int> GetMaxCountOfWinningSymbol(List<char> half, List<char> winningSymbols, int i)
        {
            var symbolMaxCount = new Dictionary<char, int>();
            char currentSymbol = '\0';
            var maxSymbolCount = 0;

            var symbolCount = 0;
            for (int h = 0; h < half.Count; h++)
            {
                if (half[h] == winningSymbols[0])
                {
                    symbolCount++;
                    if (symbolCount > maxSymbolCount)
                    {
                        maxSymbolCount = symbolCount;
                        currentSymbol = winningSymbols[0];
                    }
                    if (h != half.Count - 1)
                    {
                        if (half[h + 1] != winningSymbols[0])
                        {
                            break;
                        }
                    }
                }
            }

            symbolCount = 0;
            for (int h = 0; h < half.Count; h++)
            {
                if (half[h] == winningSymbols[1])
                {
                    symbolCount++;
                    if (symbolCount > maxSymbolCount)
                    {
                        maxSymbolCount = symbolCount;
                        currentSymbol = winningSymbols[1];
                    }
                    if (h != half.Count - 1)
                    {
                        if (half[h + 1] != winningSymbols[1])
                        {
                            break;
                        }
                    }
                }
            }

            symbolCount = 0;
            for (int h = 0; h < half.Count; h++)
            {
                if (half[h] == winningSymbols[2])
                {
                    symbolCount++;
                    if (symbolCount > maxSymbolCount)
                    {
                        maxSymbolCount = symbolCount;
                        currentSymbol = winningSymbols[2];
                    }
                    if (h != half.Count - 1)
                    {
                        if (half[h + 1] != winningSymbols[2])
                        {
                            break;
                        }
                    }
                }
            }

            symbolCount = 0;
            for (int h = 0; h < half.Count; h++)
            {
                if (half[h] == winningSymbols[3])
                {
                    symbolCount++;
                    if (symbolCount > maxSymbolCount)
                    {
                        maxSymbolCount = symbolCount;
                        currentSymbol = winningSymbols[3];
                    }
                    if (h != half.Count - 1)
                    {
                        if (half[h + 1] != winningSymbols[3])
                        {
                            break;
                        }
                    }
                }
            }

            symbolMaxCount[currentSymbol] = maxSymbolCount;
            return symbolMaxCount;
        }







    }
}
