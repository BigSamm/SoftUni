using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 15:30
namespace _01_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            var time1 = double.Parse(Console.ReadLine());
            var time2 = double.Parse(Console.ReadLine());
            var time3 = double.Parse(Console.ReadLine());

            var time11 = (time1 / 60);
            var time22 = (time2 / 60);
            var time33 = (time3 / 60); 

            var speed2 = speed + (speed * 0.1);
            var speed3 = speed2 - (speed2 * 0.05);

            var km1 = speed * time11;
            var km2 = speed2 * time22;                                                                                                                                                    
            var km3 = speed3 * time33;

            var result = (km1 + km2 + km3);
            Console.WriteLine("{0:f2}",result);
            //Console.WriteLine(speed3);
            //Console.WriteLine(km3);
            //Console.WriteLine("{0:f2}",result);

            // 46 min
           
        }
    }
}
