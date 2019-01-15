using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt");

            IEnumerable<string> oddLines = lines.Where((line, index) => index % 2 == 1);

            string outputPath = @"..\..\..\output.txt";
            FileStream f = File.Create(outputPath);
            f.Close();

            File.AppendAllLines(outputPath, oddLines);
        }
    }
}
