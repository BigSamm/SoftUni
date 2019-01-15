using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var allNums = Console.ReadLine().Split('|').ToList();
            var result = new List<int>();
            for (int i = allNums.Count - 1; i >= 0; i--)
            {
                var part = allNums[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                for (int h = 0; h < part.Count; h++)
                {
                    result.Add(part[h]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
