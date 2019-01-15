using System;

namespace _09.Linked_List_Traversal
{
    class Program
    {
        static void Main()
        {
            var linkedList = new LinekdList();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split();
                var command = args[0];
                var num = int.Parse(args[1]);

                switch (command)
                {
                    case "Add":
                        linkedList.Add(num);
                        break;
                    case "Remove":
                        linkedList.Remove(num);
                        break;
                }
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(String.Join(" ", linkedList));
        }
    }
}
