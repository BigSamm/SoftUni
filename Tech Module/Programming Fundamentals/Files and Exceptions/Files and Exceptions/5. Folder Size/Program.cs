using System;
using System.IO;

namespace _5._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"..\..\..\TestFolder");

            double size = 0d;
            foreach (var file in files)
            {
                size += new FileInfo(file).Length;
            }

            size = size / 1024 / 1024;
            File.WriteAllText(@"..\..\..\Output.txt", size.ToString());
        }
    }
}
