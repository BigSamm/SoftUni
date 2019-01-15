using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> items;
    private int currentIndex;
    private T currentItem => this.items[this.currentIndex];

    public ListyIterator()
    {
        this.items = new List<T>();
        this.currentIndex = 0;
    }

    public void Create(List<T> items)
    {
        this.items = items;
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            this.currentIndex++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        if (this.currentIndex == this.items.Count - 1)
            return false;
        else
            return true;
    }

    public T Print()
    {
        if (this.items.Count == 0)
            throw new InvalidOperationException("Invalid Operation!");

        return this.currentItem;
    }

    public string PrintAll()
    {
        var result = String.Join(" ", this.items);
        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.items.Count; i++)
        {
            yield return this.items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}