using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var word = "";

            for (int i = 0; i < n; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                var letterInInt = (int)(letter);
                letterInInt += key;
                word += (char)(letterInInt);
            }

            Console.WriteLine(word);

        }
    }
}
