using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var n = inputList[0];

        var rectangles = new List<Rectangle>();
        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Rectangle rect = CreateRectangle(inputLine);
            rectangles.Add(rect);
        }

        var m = inputList[1];
        for (int i = 0; i < m; i++)
        {
            var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var firstRectId = inputLine[0];
            var secondRectId = inputLine[1];

            var firstRect = rectangles.Find(rect => rect.Id == firstRectId);
            var secondRect = rectangles.Find(rect => rect.Id == secondRectId);

            var isIntersect = Rectangle.IsIntersect(firstRect, secondRect);      
            
            if (isIntersect)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }

    private static Rectangle CreateRectangle(List<string> inputLine)
    {
        var id = inputLine[0];
        var width = double.Parse(inputLine[1]);
        var height = double.Parse(inputLine[2]);
        var x = double.Parse(inputLine[3]);
        var y = double.Parse(inputLine[4]);

        var rect = new Rectangle(id, width, height, x , y);

        return rect;
    }
}

