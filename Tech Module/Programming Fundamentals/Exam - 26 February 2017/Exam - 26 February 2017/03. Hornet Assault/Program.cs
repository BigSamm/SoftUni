using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                    break;

                long honetsPower = 0;
                for (int h = 0; h < hornets.Count; h++)
                {
                    honetsPower += hornets[h];
                }

                if (beehives[i] < honetsPower)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= honetsPower;
                    hornets.RemoveAt(0);
                }
            }

            if(IsThereLiveBeehives(beehives))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(h => h > 0)));
            }



        }

        static bool IsThereLiveBeehives(List<long> beehives)
        {
            var isTrue = false;
            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] > 0)
                    isTrue = true;
            }
            return isTrue;
        }
    }
}
