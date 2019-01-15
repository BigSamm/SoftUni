using System;
using System.Collections.Generic;
using System.Text;

public class AddRemoveCollection : IAddCollection, IRemoveCollection
{
    public AddRemoveCollection()
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
        var lastIndex = this.Collection.Count - 1;
        var removed = this.Collection[lastIndex];
        this.Collection.RemoveAt(lastIndex);

        this.RemovedResults.Add(removed);
    }
}