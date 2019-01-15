using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstHand = new Queue<string>(Console.ReadLine().Split());
            var secondHand = new Queue<string>(Console.ReadLine().Split());

            int turn;
            for (turn = 1; turn <= 1_000_000; turn++)
            {
                if (firstHand.Count != 0 && secondHand.Count != 0)
                    MakeTurn(firstHand, secondHand, turn);
                else
                {
                    turn--;
                    break;
                }
            }

            if (turn == 1_000_001)
            {
                turn = 1_000_000;
                if (firstHand.Count > secondHand.Count)
                    Console.WriteLine($"First player wins after {turn} turns");
                else if (firstHand.Count < secondHand.Count)
                    Console.WriteLine($"Second player wins after {turn} turns");
                else
                    Console.WriteLine($"Draw after {turn} turns");
            }
            else
            {
                if (firstHand.Count == 0)
                    Console.WriteLine($"Second player wins after {turn} turns");
                else if (secondHand.Count == 0)
                    Console.WriteLine($"First player wins after {turn} turns");
            }

        }

        private static void MakeTurn(Queue<string> firstHand, Queue<string> secondHand, int turn)
        {
            string firstPlayerCard = firstHand.Dequeue();
            int firstPlayerCardNum = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));

            string secondPlayerCard = secondHand.Dequeue();
            int secondPlayerCardNum = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));

            if (firstPlayerCardNum > secondPlayerCardNum)
            {
                firstHand.Enqueue(firstPlayerCard);
                firstHand.Enqueue(secondPlayerCard);
            }
            else if (secondPlayerCardNum > firstPlayerCardNum)
            {
                secondHand.Enqueue(secondPlayerCard);
                secondHand.Enqueue(firstPlayerCard);
            }
            else
            {
                var cardsOnField = new List<string>();
                cardsOnField.Add(firstPlayerCard);
                cardsOnField.Add(secondPlayerCard);
                MakeWar(firstHand, secondHand, cardsOnField, turn);
            }
        }

        public static List<char> alphabet = "0abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();
        private static void MakeWar(Queue<string> firstHand, Queue<string> secondHand, List<string> cardsOnField, int turn)
        {
            if (firstHand.Count >= 3 && secondHand.Count >= 3)
            {
                var firstPlayerFirstCard = firstHand.Dequeue();
                var firstPlayerSecondCard = firstHand.Dequeue();
                var firstPlayerThirdCard = firstHand.Dequeue();

                var secondPlayerFirstCard = secondHand.Dequeue();
                var secondPlayerSecondCard = secondHand.Dequeue();
                var secondPlayerThirdCard = secondHand.Dequeue();

                int firstPlayerLetterSum = alphabet.IndexOf(firstPlayerFirstCard.Last())
                    + alphabet.IndexOf(firstPlayerSecondCard.Last())
                    + alphabet.IndexOf(firstPlayerThirdCard.Last());
                int secondPlayerLetterSum = alphabet.IndexOf(secondPlayerFirstCard.Last())
                    + alphabet.IndexOf(secondPlayerSecondCard.Last())
                    + alphabet.IndexOf(secondPlayerThirdCard.Last());

                cardsOnField.Add(firstPlayerFirstCard);
                cardsOnField.Add(firstPlayerSecondCard);
                cardsOnField.Add(firstPlayerThirdCard);
                cardsOnField.Add(secondPlayerFirstCard);
                cardsOnField.Add(secondPlayerSecondCard);
                cardsOnField.Add(secondPlayerThirdCard);

                cardsOnField = cardsOnField.OrderByDescending(c => int.Parse(c.Substring(0, c.Length - 1))).ThenByDescending(c => c.Last()).ToList();

                if (firstPlayerLetterSum > secondPlayerLetterSum)
                {
                    foreach (var card in cardsOnField)
                    {
                        firstHand.Enqueue(card);
                    }
                }
                else if (secondPlayerLetterSum > firstPlayerLetterSum)
                {
                    foreach (var card in cardsOnField)
                    {
                        secondHand.Enqueue(card);
                    }
                }
                else
                {
                    MakeWar(firstHand, secondHand, cardsOnField, turn);
                }
            }
            else
            {
                Console.WriteLine($"Draw after {turn} turns");
                Environment.Exit(0);
            }
        }
    }
}