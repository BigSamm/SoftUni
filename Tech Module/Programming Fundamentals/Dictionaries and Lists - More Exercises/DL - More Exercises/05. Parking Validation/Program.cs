using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToList();
                var username = command[1];
                if(command[0] == "register")
                {
                    var licensePlateNumber = command[2];

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    
                    else if (licensePlateNumber.Length != 8 || !IsUppercaseLetters(licensePlateNumber)
                        || !IsDigitsInMiddle(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }

                    else if (parking.ContainsValue(licensePlateNumber))
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");

                    else
                    {
                        parking[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if(command[0] == "unregister")
                {
                    if(parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: user {username} not found");
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }



        }

        static bool IsDigitsInMiddle(string licensePlateNumber)
        {
            var middle = licensePlateNumber.Skip(2).Take(4).ToList();
            var isTrue = true;
            for (int i = 0; i < middle.Count; i++)
            {
                if (middle[i] < 48 || middle[i] > 57)
                    isTrue = false;
            }
            return isTrue;
        }

        static bool IsUppercaseLetters(string licensePlateNumber)
        {
            var firstLetters = licensePlateNumber.Take(2).ToList();
            var lastLetters = licensePlateNumber.Reverse().Take(2).ToList();
            var allLetters = new List<char>();
            foreach (var item in firstLetters)
                allLetters.Add(item);
            foreach (var item in lastLetters)
                allLetters.Add(item);

            var isTrue = true;
            for (int i = 0; i < allLetters.Count; i++)
            {
                if (allLetters[i] < 65 || allLetters[i] > 90)
                    isTrue = false;
            }
            return isTrue;
        }



    }
}
