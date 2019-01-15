using System;
using System.Collections.Generic;
using System.Text;

public class MyList : IAddCollection, IRemoveCollection
{
    public MyList()
    {
        this.Collection = new List<string>();
        this.AddedResults = new List<int>();
        this.RemovedResults = new List<string>();
    }

    public List<string> Collection { get; private set; }
    public List<int> AddedResults { get; private set; }
    public List<string> RemovedResults { get; private set; }

    public void Add(string item)
    {
        this.Collection.Insert(0, item);

        this.AddedResults.Add(0);
    }

    public void Remove()
    {
        var removed = this.Collection[0];
        this.Collection.RemoveAt(0);

        this.RemovedResults.Add(removed);
    }

    public int Used()
    {
        var count = this.Collection.Count;
        return count;
    }
}