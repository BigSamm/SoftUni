using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToList();
            var wordsInDic = new Dictionary<string, int>();
            var resultForPrint = new List<string>();
            foreach (var element in words)
            {
                if (wordsInDic.ContainsKey(element))
                    wordsInDic[element]++;
                else
                    wordsInDic[element] = 1;
            }

            foreach (var w in wordsInDic)
            {
                if (w.Value % 2 == 1)
                    resultForPrint.Add(w.Key);
            }
            Console.WriteLine(string.Join(", ", resultForPrint));


        }
    }
}
