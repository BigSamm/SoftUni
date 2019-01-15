using System;
using System.Collections.Generic;
using System.Text;

public class AddCollection : IAddCollection
{
    public AddCollection()
    {
        this.Collection = new List<string>();
        this.AddedResults = new List<int>();
    }

    public List<string> Collection { get; private set; }
    public List<int> AddedResults { get; private set; }

    public void Add(string item)
    {
        this.Collection.Add(item);
        
        this.AddedResults.Add(Collection.Count - 1);
    }
}