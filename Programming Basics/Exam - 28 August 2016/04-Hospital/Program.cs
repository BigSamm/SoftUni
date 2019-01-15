using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var treatedP = 0;
            var untreatedP = 0;
            var doctors = 7;


            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && untreatedP > treatedP) doctors++;
                
                var patient = int.Parse(Console.ReadLine());
                if (patient <= doctors) 
                {
                    treatedP += patient;
                    untreatedP += 0;
                }
                else 
                {
                    treatedP += doctors;
                    untreatedP += patient - doctors;
                }

                
            }

            Console.WriteLine("Treated patients: {0}.", treatedP);
            Console.WriteLine("Untreated patients: {0}.", untreatedP);

        }
    }
}
