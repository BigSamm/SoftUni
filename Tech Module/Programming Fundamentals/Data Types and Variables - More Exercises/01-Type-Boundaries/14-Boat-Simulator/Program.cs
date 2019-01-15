using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var firstBoatMoves = 0;
            var secondBoatMoves = 0;

            for (int i = 1; i <= n; i++)
            {
                var command = Console.ReadLine();

                if (firstBoatMoves >= 50)
                    n = n;
                else if (command == "UPGRADE")
                {
                    var firstBoatInInt = (int)(firstBoat);
                    firstBoatInInt += 3;
                    firstBoat = (char)(firstBoatInInt);

                    var secondBoatInInt = (int)(secondBoat);
                    secondBoatInInt += 3;
                    secondBoat = (char)(secondBoatInInt);
                }
                else if (i % 2 == 1)
                    firstBoatMoves += command.Length;
                else if (i % 2 == 0)
                    secondBoatMoves += command.Length;

                //Console.WriteLine(firstBoatMoves);
                //Console.WriteLine(secondBoatMoves);
            }

            if(firstBoatMoves > secondBoatMoves)
                Console.WriteLine(firstBoat);
            else if(secondBoatMoves > firstBoatMoves)
                Console.WriteLine(secondBoat);




        }
    }
}
