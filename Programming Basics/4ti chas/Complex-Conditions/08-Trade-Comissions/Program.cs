using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var s = double.Parse(Console.ReadLine());
            double kom = -1;

            if (s >= 0 && s <= 500)
            {
                switch (city)
                {
                    case "Sofia": kom = s * 0.05; break;
                    case "Varna": kom = s * 0.045; break;
                    case "Plovdiv": kom = s * 0.055; break;
                }
            }

            if (s > 500 && s <= 1000)
            {
                switch (city)
                {
                    case "Sofia": kom = s * 0.07; break;
                    case "Varna": kom = s * 0.075; break;
                    case "Plovdiv": kom = s * 0.08; break;
                }
            }

            if (s > 1000 && s <= 10000)
            {
                switch (city)
                {
                    case "Sofia": kom = s * 0.08; break;
                    case "Varna": kom = s * 0.1; break;
                    case "Plovdiv": kom = s * 0.12; break;
                }
            }

            if (s > 10000)
            {
                switch (city)
                {
                    case "Sofia": kom = s * 0.12; break;
                    case "Varna": kom = s * 0.13; break;
                    case "Plovdiv": kom = s * 0.145; break;
                }
            }

            if (kom > 0) Console.WriteLine("{0:f2}", Math.Round(kom, 2));
            else if (kom < 0) Console.WriteLine("error");
        }
    }
}
