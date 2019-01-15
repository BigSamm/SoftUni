using System;
using System.IO;

namespace _4._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oddNums = File.ReadAllLines(@"..\..\..\Input1.txt");
            string[] evenNums = File.ReadAllLines(@"..\..\..\Input2.txt");

            string[] result = new string[oddNums.Length * 2];
            int index = 0;
            for (int i = 0; i < oddNums.Length; i++)
            {
                result[index] = oddNums[i];
                result[index + 1] = evenNums[i];

                index += 2;
            }

            File.WriteAllLines(@"..\..\..\Output.txt", result);
        }
    }
}
