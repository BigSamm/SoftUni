using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var demonsAndHealth = new SortedDictionary<string, int>();
            var demonsAndDamage = new SortedDictionary<string, double>();

            for (int i = 0; i < demons.Count; i++)
            {
                var name = demons[i];
                var health = GetDemonHealth(name);
                var damage = GetDemonDamage(name);
                demonsAndHealth[name] = health;
                demonsAndDamage[name] = damage;
            }

            foreach (var d in demonsAndHealth.Zip(demonsAndDamage, Tuple.Create))
            {
                Console.WriteLine($"{d.Item1.Key} - {d.Item1.Value} health, {d.Item2.Value:f2} damage");
            }

        }

        static double GetDemonDamage(string name)
        {
            var numsStr = string.Empty;
            var nameArr = name.ToCharArray();
            for (int i = 0; i < nameArr.Length; i++)
            {
                if((nameArr[i] < 48 || nameArr[i] > 57) && nameArr[i] != 46 && nameArr[i] != 45)
                {
                    nameArr[i] = ' ';
                }
            }
            for (int i = 0; i < nameArr.Length; i++)
            {
                if(nameArr[i] == '-')
                {
                    numsStr += ' ';
                }
                numsStr += nameArr[i];
            }
            var numsList = numsStr
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var damage = 0.0;
            for (int i = 0; i < numsList.Count; i++)
            {
                damage += numsList[i];
            }

            nameArr = name.ToCharArray();
            var multiplyCount = 0;
            var divideCount = 0;
            for (int i = 0; i < nameArr.Length; i++)
            {
                if(nameArr[i] == '*')
                {
                    multiplyCount++;
                }
                else if(nameArr[i] == '/')
                {
                    divideCount++;
                }
            }
            for (int i = 0; i < multiplyCount; i++)
            {
                damage *= 2;
            }
            for (int i = 0; i < divideCount; i++)
            {
                damage /= 2;
            }

            return damage;
        }

        static int GetDemonHealth(string name)
        {
            var health = 0;
            var nameInCharArr = name.ToCharArray();
            for (int i = 0; i < nameInCharArr.Length; i++)
            {
                if( (nameInCharArr[i] < 45 || nameInCharArr[i] > 57) &&
                    nameInCharArr[i] != 42 && nameInCharArr[i] != 43 )
                {
                    health += nameInCharArr[i];
                }
            }
            return health;
        }
    }
}
