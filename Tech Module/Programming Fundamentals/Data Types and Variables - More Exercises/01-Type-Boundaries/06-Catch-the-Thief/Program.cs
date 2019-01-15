using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            long maxID = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());
                
                if (type == "sbyte")
                {
                    long @sbyte = id;
                    if (@sbyte > maxID && @sbyte <= 127)
                        maxID = @sbyte;
                }
                else if (type == "int")
                {
                    long @int = id;
                    if (@int > maxID && @int <= 2147483647)
                        maxID = @int;
                }
                else if (type == "long")
                {
                    long @long = id;
                    if (@long > maxID && @long <= 9223372036854775807)
                        maxID = @long;
                }
            }

            Console.WriteLine(maxID);


        }
    }
}
