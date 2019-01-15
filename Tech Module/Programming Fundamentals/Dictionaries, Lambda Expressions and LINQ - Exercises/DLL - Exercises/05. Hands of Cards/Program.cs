using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, string>();
            var result = new Dictionary<string, int>();
            List<string> power = new List<string> {
                    "0", "0", "2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            List<string> type = new List<string> { "0", "C", "D", "H", "S" };

            AddingPeoplesHands(people);

            foreach (var item in people)
            {
                var allCards = item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var cards = allCards.Distinct().ToList();
                for (int i = 0; i < cards.Count; i++)
                {
                    string first;
                    string second;
                    if (cards[i].Length > 2)
                    {
                        first = string.Join("", cards[i].Take(2));
                        second = string.Join(" ", cards[i].Skip(2).Take(1));
                    }
                    else
                    {
                        first = string.Join(" ", cards[i].First());
                        second = string.Join(" ", cards[i].Skip(1).Take(1));
                    }
                    if (result.ContainsKey(item.Key))
                        result[item.Key] += power.IndexOf(first) * type.IndexOf(second);
                    else
                        result[item.Key] = power.IndexOf(first) * type.IndexOf(second);
                }
            }
            foreach (var item in result)
                Console.WriteLine(item.Key + ": " + item.Value);
        }

        static void AddingPeoplesHands(Dictionary<string, string> people)
        {
            for (;;)
            {
                var currentHand = Console.ReadLine().Split(':').ToList();

                if (currentHand[0] == "JOKER")
                    return;

                if (people.ContainsKey(currentHand[0]))
                    people[currentHand[0]] += currentHand[1];
                else
                    people[currentHand[0]] = currentHand[1];
            }
        }



    }
}

