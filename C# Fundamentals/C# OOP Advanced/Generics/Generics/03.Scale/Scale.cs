using System;
using System.Collections.Generic;
using System.Text;

public class Scale<T>
    where T : IComparable<T>
{ 
    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T Left { get; }
    public T Right { get; }

    public T GetHeavier()
    {
        var compareNum = this.Left.CompareTo(this.Right);

        if (compareNum > 0)
            return this.Left;
        else if (compareNum < 0)
            return this.Right;
        else
            return default(T);
    }
}