using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        class Legion
        {
            public int LastActivity { get; set; }
            public string LegionName { get; set; }
            public string SoldierType  { get; set; }
            public int SoldierCount { get; set; }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var allLegions = GetAllLegions(n);
            var legions = GetLegions(allLegions);


        }

        static object GetLegions(List<Legion> allLegions)
        {
            var legNameActivity = new Dictionary<string, int>();
            var soldTypeCount = new Dictionary<string, int>();
            foreach (var x in allLegions)
            {
                if(x.LegionName.Contains(legions))
                {

                }
            }
        }

        static List<Legion> GetAllLegions(int n)
        {
            var allLegions = new List<Legion>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                        .Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var currentLegion = new Legion()
                {
                    LastActivity = int.Parse(input[0]),
                    LegionName = input[1],
                    SoldierType = input[2],
                    SoldierCount = int.Parse(input[3])
                };
                allLegions.Add(currentLegion);
            }
            return allLegions;
        }



    }
}
