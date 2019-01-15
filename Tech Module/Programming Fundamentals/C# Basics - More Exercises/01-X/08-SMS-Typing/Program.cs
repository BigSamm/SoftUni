using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var word = "";

            for (int i = 0; i < num; i++)
            {
                var letter = int.Parse(Console.ReadLine());

                if (letter == 2) word += "a";
                else if (letter == 22) word += "b";
                else if (letter == 222) word += "c";
                else if (letter == 3) word += "d";
                else if (letter == 33) word += "e";
                else if (letter == 333) word += "f";
                else if (letter == 4) word += "g";
                else if (letter == 44) word += "h";
                else if (letter == 444) word += "i";
                else if (letter == 5) word += "j";
                else if (letter == 55) word += "k";
                else if (letter == 555) word += "l";
                else if (letter == 6) word += "m";
                else if (letter == 66) word += "n";
                else if (letter == 666) word += "o";
                else if (letter == 7) word += "p";
                else if (letter == 77) word += "q";
                else if (letter == 777) word += "r";
                else if (letter == 7777) word += "s";
                else if (letter == 8) word += "t";
                else if (letter == 88) word += "u";
                else if (letter == 888) word += "v";
                else if (letter == 9) word += "w";
                else if (letter == 99) word += "x";
                else if (letter == 999) word += "y";
                else if (letter == 9999) word += "z";
                else if (letter == 0) word += " ";
            }

            Console.WriteLine(word);

        }
    }
}
