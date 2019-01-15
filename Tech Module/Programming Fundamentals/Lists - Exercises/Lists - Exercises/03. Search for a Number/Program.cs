using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var manipulation = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var manipulatedList = new LinkedList<int>();
            for (int i = manipulation[1]; i < manipulation[0]; i++)
            {
                if(nums[i] == manipulation[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
