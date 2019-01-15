using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            if (l == 1) l = 'a';
            else if (l == 2) l = 'b';
            else if (l == 3) l = 'c';
            else if (l == 4) l = 'd';
            else if (l == 5) l = 'e';
            else if (l == 6) l = 'f';
            else if (l == 7) l = 'g';
            else if (l == 8) l = 'h';
            else if (l == 9) l = 'i';

            var i = 1;
            var j = 'a';
            for (i = 1; i < n; i++)
            {
                Console.Write(i + " ");
                for (i = 1; i < n; i++)
                {
                    Console.Write(i + " ");
                    for (j = 'a'; j <= l; j++)
                    {
                        Console.Write(j + " ");
                        for (j = 'a'; j <= l; j++)
                        {
                            Console.WriteLine(j + " ");
                            break;
                        }
                        break;
                    }
                    break;
                }
            }











            //var i = 1;
            //var j = 'a';

            //for (i = 1; i < 10; i++)
            //{
            //    while (i < n)
            //    {
            //        Console.Write(i);
            //        break;
            //    }
            //    while (i < n)
            //    {
            //        Console.Write(i);
            //        i++;
            //        break;
            //    }
            //    while (j < l)
            //    {
            //        Console.Write(j);
            //        break;
            //    }
            //    while (j < l)
            //    {
            //        Console.Write(j);
            //        j++;
            //        break;
            //    }
            //    while (i <= n)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}





        }
    }
}
