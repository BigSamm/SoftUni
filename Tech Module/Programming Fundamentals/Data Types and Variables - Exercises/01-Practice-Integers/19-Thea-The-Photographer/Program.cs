using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picNums = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            long timeToFilter = picNums * filterTime;
            long usefulPics = (long)Math.Ceiling(picNums * filterFactor / 100.0);
            long timeToUpload = usefulPics * uploadTime;
            long allTime = timeToFilter + timeToUpload;

            long sec = (allTime % 60);
            allTime = (allTime - (allTime % 60)) / 60;
            long mins = (allTime % 60);
            allTime = (allTime - (allTime % 60)) / 60;
            long hours = (allTime % 24);
            long days = ((allTime - (allTime % 24)) / 24);

            Console.WriteLine($"{days}:{hours:d2}:{mins:d2}:{sec:d2}");
        }
    }
}
