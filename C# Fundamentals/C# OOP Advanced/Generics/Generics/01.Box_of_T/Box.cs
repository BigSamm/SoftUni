using System;
using System.Collections.Generic;
using System.Text;
 
public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public int Count => this.data.Count;

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove()
    {
        var lastIndex = data.Count - 1;
        var removedElement = data[lastIndex];
        data.RemoveAt(lastIndex);

        return removedElement;
    }
}