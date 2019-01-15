using System;

namespace _07.Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();

            string inputLine;
            while((inputLine = Console.ReadLine()) != "END")
            {
                var inputList = inputLine.Split();
                var command = inputList[0];

                switch (command)
                {
                    case "Add":
                        var element = inputList[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(inputList[1]);
                        customList.Remove(index);
                        break;
                    case "Contains":
                        element = inputList[1];
                        Console.WriteLine(customList.Contains(element));
                        break;
                    case "Swap":
                        var firstIndex = int.Parse(inputList[1]);
                        var secondIndex = int.Parse(inputList[2]);
                        customList.Swap(firstIndex, secondIndex);
                        break;
                    case "Greater":
                        element = inputList[1];
                        Console.WriteLine(customList.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(customList.Print());
                        break;
                    case "Sort":
                        Sorter.Sort(customList);
                        break;
                }
            }
        }
    }
}
