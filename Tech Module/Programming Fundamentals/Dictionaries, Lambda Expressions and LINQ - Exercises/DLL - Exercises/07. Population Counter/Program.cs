using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new Dictionary<string, string>();
            var city = new Dictionary<string, int>();

            TakeCountryCitiesPopulation(country,city);





        }

        static void TakeCountryCitiesPopulation(Dictionary<string, string> country, Dictionary<string, int> city)
        {
            for (;;)
            {
                var input = Console.ReadLine().Split('|').ToList();

                if (input[0] == "report")
                    break;

                var cityList = new List<string>();
                cityList.Add(input[0]);

                city[input[1]] = int.Parse(input[2]);
            }
            country[]
        }



    }
}
