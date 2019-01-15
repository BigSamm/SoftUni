using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            try
            {
                var @sbyte = sbyte.Parse(n);
                Console.WriteLine("Sunny");
            }
            catch
            {
                try
                {
                    var @int = int.Parse(n);
                    Console.WriteLine("Cloudy");
                }
                catch
                {
                    try
                    {
                        var @long = long.Parse(n);
                        Console.WriteLine("Windy");
                    }
                    catch
                    {
                        try
                        {
                            var @double = double.Parse(n);
                            Console.WriteLine("Rainy");
                        }
                        catch
                        {
                        }
                    }
                }
            }



        }
    }
}
