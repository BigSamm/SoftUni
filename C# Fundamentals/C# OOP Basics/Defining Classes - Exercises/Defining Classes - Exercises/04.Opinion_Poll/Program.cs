using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var members = new Family();
        for (int i = 0; i < n; i++)
        {
            var inputList = Console.ReadLine().Split();
            var name = inputList[0];
            var age = int.Parse(inputList[1]);

            var member = new Person(name, age);
            members.AddMember(member);
        }

        var result = members.GetMembersMoreThan30Years();
        result.ForEach(m => Console.WriteLine(m.Name + " - " + m.Age));
    }
}
