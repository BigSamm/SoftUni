using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : IComparable<T>
{
    private T element;

    public Box(T element)
    {
        this.element = element;
    }

    public override string ToString()
    {
        var result = typeof(T).FullName + ": " + this.element;
        return result;
    }
}