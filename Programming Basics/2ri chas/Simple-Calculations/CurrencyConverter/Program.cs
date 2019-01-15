using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Currency: ");
            var value = double.Parse(Console.ReadLine());
            Console.Write("From(bgn, usd, eur, gbp): ");
            string valuta = Console.ReadLine();
            Console.Write("To(bgn, usd, eur, gbp): ");
            string valuta2 = Console.ReadLine();
            Console.Write("Result: ");
            if (valuta == "usd" && valuta2 == "bgn")
                Console.WriteLine(Math.Round(value * 1.79549, 2) + " " + valuta2);
            if (valuta == "usd" && valuta2 == "eur")
                Console.WriteLine(Math.Round(value / 1.08930, 2) + " " + valuta2);
            if (valuta == "usd" && valuta2 == "gbp")
                Console.WriteLine(Math.Round(value / 1.41134, 2) + " " + valuta2);
            if (valuta == "bgn" && valuta2 == "usd")
                Console.WriteLine(Math.Round(value / 1.79549, 2) + " " + valuta2);
            if (valuta == "bgn" && valuta2 == "eur")
                Console.WriteLine(Math.Round(value / 1.95583, 2) + " " + valuta2);
            if (valuta == "bgn" && valuta2 == "gbp")
                Console.WriteLine(Math.Round(value / 2.53405, 2) + " " + valuta2);
            if (valuta == "eur" && valuta2 == "bgn")
                Console.WriteLine(Math.Round(value * 1.79549, 2) + " " + valuta2);
            if (valuta == "eur" && valuta2 == "usd")
                Console.WriteLine(Math.Round(value * 1.08930, 2) + " " + valuta2);
            if (valuta == "eur" && valuta2 == "gbp")
                Console.WriteLine(Math.Round(value / 1.29564, 2) + " " + valuta2);
            if (valuta == "gbp" && valuta2 == "bgn")
                Console.WriteLine(Math.Round(value * 2.53405, 2) + " " + valuta2);
            if (valuta == "gbp" && valuta2 == "usd")
                Console.WriteLine(Math.Round(value * 1.41134, 2) + " " + valuta2);
            if (valuta == "gbp" && valuta2 == "eur")
                Console.WriteLine(Math.Round(value * 1.29564, 2) + " " + valuta2);
        }
    }
}
