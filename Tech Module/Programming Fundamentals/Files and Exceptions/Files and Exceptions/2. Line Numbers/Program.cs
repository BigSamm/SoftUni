using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main()
        {
            IEnumerable<string> lines = File.ReadAllLines(@"..\..\..\Input.txt");

            lines = lines.Select((line, index) => $"{index + 1}. " + line);
            
            File.WriteAllLines(@"..\..\..\Output.txt", lines);
        }
    }
}
