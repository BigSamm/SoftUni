using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sentence_the_Thief
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
                        if (@sbyte > maxID && @sbyte <= sbyte.MaxValue)
                            maxID = @sbyte;
                    }
                    else if (type == "int")
                    {
                        long @int = id;
                        if (@int > maxID && @int <= int.MaxValue)
                            maxID = @int;
                    }
                    else if (type == "long")
                    {
                        long @long = id;
                        if (@long > maxID && @long <= long.MaxValue)
                            maxID = @long;
                    }
                }

                var sentence = 0.0;
                if (maxID > 0)
                    sentence = Math.Ceiling(maxID / (double)sbyte.MaxValue);
                else if (maxID < 0)
                        sentence = Math.Ceiling(maxID / (double)sbyte.MinValue);

                if (sentence == 1)
                    Console.WriteLine($"Prisoner with id {maxID} is sentenced to {sentence} year");
                else
                    Console.WriteLine($"Prisoner with id {maxID} is sentenced to {sentence} years");

            

        }
    }
}
