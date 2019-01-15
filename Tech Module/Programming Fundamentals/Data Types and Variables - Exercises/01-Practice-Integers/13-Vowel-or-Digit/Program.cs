using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = char.Parse(Console.ReadLine());
            
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
                Console.WriteLine("vowel");
            else if (n == '0' || n == '1' || n == '2' || n == '3' || n == '4' || n == '5' || n == '6' || n == '7' || n == '8' || n == '9')
                Console.WriteLine("digit");
            else
                Console.WriteLine("other");
                
        }
    }
}
