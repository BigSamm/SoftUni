using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lekcii = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var Jelev = 0;
            var RoYal = 0;
            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var other = 0;
            var money = budget / lekcii;

            for (int i = 0; i < lekcii; i++)
            {
                var lektorName = Console.ReadLine();
                if (lektorName == "Jelev") Jelev++;
                else if (lektorName == "RoYaL") RoYal++;
                else if (lektorName == "Roli") Roli++;
                else if (lektorName == "Trofon") Trofon++;
                else if (lektorName == "Sino") Sino++;
                else other++;
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", Jelev * money);
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYal * money);
            Console.WriteLine("Roli salary: {0:f2} lv", Roli * money);
            Console.WriteLine("Trofon salary: {0:f2} lv" , Trofon * money);
            Console.WriteLine("Sino salary: {0:f2} lv" ,Sino * money);
            Console.WriteLine("Others salary: {0:f2} lv", other * money);



        }
    }
}
