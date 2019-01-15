using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = int.Parse(Console.ReadLine());
            var s2 = int.Parse(Console.ReadLine());
            var s3 = int.Parse(Console.ReadLine());
            
            var sec = s1 + s2 + s3;
            var min = sec / 60;
            sec = sec % 60;
            
         
            Console.WriteLine(min + ":" + sec);
            
        }
    }
}
