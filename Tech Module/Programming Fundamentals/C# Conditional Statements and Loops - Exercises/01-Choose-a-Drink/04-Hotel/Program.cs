using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0;
            var @double = 0.0;
            var suite = 0.0;
            var price = 0.0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                @double = 65;
                suite = 75;
            }

            else if (month == "June" || month == "September")
            {
                studio = 60;
                @double = 72;
                suite = 82;
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                @double = 77;
                suite = 89;
            }

            if ((month == "September" || month == "October") && nights > 7)
            {
                nights--;
                studio *= nights;
                nights++;
            }
            else
                studio *= nights;

            @double *= nights;
            suite *= nights;

            if ((month == "May" || month == "October") && nights > 7)
                studio -= studio * .05;
            if ((month == "June" || month == "September") && nights > 14)
                @double -= @double * .1;
            if ((month == "July" || month == "August" || month == "December") && nights > 14)
                suite -= suite * .15;

            Console.WriteLine("Studio: {0:f2} lv.", studio);
            Console.WriteLine("Double: {0:f2} lv.", @double);
            Console.WriteLine("Suite: {0:f2} lv.", suite);




        }
    }
}
