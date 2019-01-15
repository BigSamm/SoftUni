using System;
using System.Collections.Generic;
using System.Text;

public interface IAddCollection
{
    List<string> Collection { get; }
    List<int> AddedResults { get; }
    void Add(string item);
}