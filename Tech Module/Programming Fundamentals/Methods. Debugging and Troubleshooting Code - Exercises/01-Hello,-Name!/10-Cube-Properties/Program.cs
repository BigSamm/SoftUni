using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var element = Console.ReadLine();

            if(element == "face")
            {
                double faceDiagonals = GetFaceDiagonalsOfCube(side);
                Console.WriteLine($"{faceDiagonals:f2}");
            }
            else if (element == "space")
            {
                double spaceDiagonals = GetSpaceDiagonalsOfCube(side);
                Console.WriteLine($"{spaceDiagonals:f2}");
            }
            else if (element == "volume")
            {
                double volume = GetVolumeOfCube(side);
                Console.WriteLine($"{volume:f2}");
            }
            else if (element == "area")
            {
                double area = GetTheAreaOfCube(side);
                Console.WriteLine($"{area:f2}");
            }
        }

        static double GetTheAreaOfCube(double side)
        {
            var area = 6 * Math.Pow(side, 2);
            return area;
        }

        static double GetVolumeOfCube(double side)
        {
            var volume = Math.Pow(side, 3);
            return volume;
        }

        static double GetSpaceDiagonalsOfCube(double side)
        {
            var spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonals;
        }

        static double GetFaceDiagonalsOfCube(double side)
        {
            var faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonals;
        }



    }
}
