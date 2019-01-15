using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Greedy_Times
{
    class Program
    {
        public static Dictionary<string, long> gems = new Dictionary<string, long>();
        public static Dictionary<string, long> cash = new Dictionary<string, long>();
        public static Dictionary<string, long> gold = new Dictionary<string, long>();
        public static long totalAmount = 0;

        static void Main(string[] args)
        {
            var bagCapacity = long.Parse(Console.ReadLine());
            var itemsInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            for (int index = 0; index < itemsInput.Count; index += 2)
            {
                var currentItem = itemsInput[index];
                var currentAmount = long.Parse(itemsInput[index + 1]);

                AddCurrentItem(currentItem, index, currentAmount, bagCapacity);
            }

            PrintItems();
        }

        private static void PrintItems()
        {
            if (gold.Count > 0)
            {
                long goldTotalAmount = GetCurrentItemTotalAmount(gold);

                Console.WriteLine($"<Gold> ${goldTotalAmount}");
                Console.WriteLine($"##Gold - {goldTotalAmount}");
            }

            if (gems.Count > 0)
            {
                long gemTotalAmount = GetCurrentItemTotalAmount(gems);

                gems = gems.OrderByDescending(gem => gem.Key).ThenBy(gem => gem.Value).ToDictionary(g => g.Key, g => g.Value);

                Console.WriteLine($"<Gem> ${gemTotalAmount}");
                foreach (var gem in gems)
                {
                    Console.WriteLine($"##{gem.Key} - {gem.Value}");
                }
            }

            if (cash.Count > 0)
            {
                long cashTotalAmount = GetCurrentItemTotalAmount(cash);

                cash = cash.OrderByDescending(c => c.Key).ThenBy(c => c.Value).ToDictionary(c => c.Key, c => c.Value);

                Console.WriteLine($"<Cash> ${cashTotalAmount}");
                foreach (var item in cash)
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }

        private static void AddCurrentItem(string item, int index, long currentAmount, long bagCapacity)
        {
            if (totalAmount + currentAmount > bagCapacity)
                return;

            var caseInsensitiveItem = item.ToLower();

            if (caseInsensitiveItem == "gold")
            {
                if (gold.ContainsKey(item))
                    gold[item] += currentAmount;
                else
                    gold[item] = currentAmount;

                totalAmount += currentAmount;
            }
            else if (caseInsensitiveItem.EndsWith("gem") && item.Length >= 4)
            {
                var gemsTotalAmount = GetCurrentItemTotalAmount(gems);
                var goldTotalAmount = GetCurrentItemTotalAmount(gold);

                if (gemsTotalAmount + currentAmount <= goldTotalAmount)
                {
                    if (gems.ContainsKey(item))
                        gems[item] += currentAmount;
                    else
                        gems[item] = currentAmount;

                    totalAmount += currentAmount;
                }
            }
            else if (item.Length == 3)
            {
                var cashTotalAmount = GetCurrentItemTotalAmount(cash);
                var gemsTotalAmount = GetCurrentItemTotalAmount(gems);

                if (cashTotalAmount + currentAmount <= gemsTotalAmount)
                {
                    if (cash.ContainsKey(item))
                        cash[item] += currentAmount;
                    else
                        cash[item] = currentAmount;

                    totalAmount += currentAmount;
                }
            }
        }

        private static long GetCurrentItemTotalAmount(Dictionary<string, long> items)
        {
            long totalAmount = 0;

            foreach (var item in items)
            {
                totalAmount += item.Value;
            }

            return totalAmount;
        }
    }
}