using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var skip = nums[0];
            var take = nums[1];

            var text = Console.ReadLine();
            var regex = @"\|<[\w\d\-]+";
            var cameras = Regex.Matches(text, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToList();

            var result = new List<string>();
            for (int i = 0; i < cameras.Count; i++)
            {
                var cam = String.Join("", cameras[i].Skip(2).Take(cameras[i].Length - 2));
                var neededCam = String.Join("", cam.Skip(skip).Take(take));
                result.Add(neededCam);
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
