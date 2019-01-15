using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonNameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
            result = Char.ToLower(x.Name.First()).CompareTo(Char.ToLower(y.Name.First()));

        return result;
    }
}