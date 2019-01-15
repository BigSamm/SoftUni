using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        public static Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();
        public static long gold = 0;
        public static long gems = 0;
        public static long money = 0;

        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            ParseAllItems(safe, bagCapacity);

            PrintBag();
        }

        private static void ParseAllItems(string[] safe, long bagCapacity)
        {
            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);

                string item = TakeCurrentItem(name);

                if (item == "")
                    continue;
                else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                    continue;

                bool isSuccess = ProcessingItem(item, count);
                if (!isSuccess)
                    continue;

                if (!bag.ContainsKey(item))
                    bag[item] = new Dictionary<string, long>();

                if (!bag[item].ContainsKey(name))
                    bag[item][name] = 0;

                bag[item][name] += count;
                if (item == "Gold")
                    gold += count;
                else if (item == "Gem")
                    gems += count;
                else if (item == "Cash")
                    money += count;
            }
        }

        private static void PrintBag()
        {
            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }

        private static bool ProcessingItem(string item, long count)
        {
            switch (item)
            {
                case "Gem":
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (count > bag["Gold"].Values.Sum())
                                return false;
                        }
                        else
                            return false;
                    }
                    else if (bag[item].Values.Sum() + count > bag["Gold"].Values.Sum())
                    {
                        return false;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (count > bag["Gem"].Values.Sum())
                                return false;
                        }
                        else
                            return false;
                    }
                    else if (bag[item].Values.Sum() + count > bag["Gem"].Values.Sum())
                    {
                        return false;
                    }
                    break;
            }

            return true;
        }

        private static string TakeCurrentItem(string name)
        {
            string item = string.Empty;

            if (name.Length == 3)
                item = "Cash";
            else if (name.ToLower().EndsWith("gem"))
                item = "Gem";
            else if (name.ToLower() == "gold")
                item = "Gold";

            return item;
        }
    }
}