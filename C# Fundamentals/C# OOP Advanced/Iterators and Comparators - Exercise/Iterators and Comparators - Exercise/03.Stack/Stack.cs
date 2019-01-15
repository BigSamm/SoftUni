using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private List<T> items;

    public Stack()
    {
        this.items = new List<T>();
    }

    public void Push(T[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            this.items.Add(items[i]);
        }
    }

    public T Pop()
    {
        if (this.items.Count == 0)
            throw new InvalidOperationException("No elements");

        var lastIndex = this.items.Count - 1;
        var removedItem = this.items[lastIndex];
        this.items.RemoveAt(lastIndex);

        return removedItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.items.Count - 1; i >= 0; i--)
        {
            yield return this.items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}