using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();

        var inputList = Console.ReadLine().Split();
        foreach (var item in inputList)
        {
            addCollection.Add(item);
            addRemoveCollection.Add(item);
            myList.Add(item);
        }

        var removeCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < removeCount; i++)
        {
            addRemoveCollection.Remove();
            myList.Remove();
        }

        Console.WriteLine(String.Join(" ", addCollection.AddedResults));
        Console.WriteLine(String.Join(" ", addRemoveCollection.AddedResults));
        Console.WriteLine(String.Join(" ", myList.AddedResults));

        Console.WriteLine(String.Join(" ", addRemoveCollection.RemovedResults));
        Console.WriteLine(String.Join(" ", myList.RemovedResults));
    }
}