using System;
using System.Collections.Generic;
using System.Text;

public static class Sorter
{
    public static void Sort<T>(CustomList<T> customList)
        where T : IComparable<T>
    {
        customList.Sort();
    }
}