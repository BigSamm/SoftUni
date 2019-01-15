using System;
using System.Collections.Generic;
using System.Text;

public interface IRemoveCollection
{
    List<string> RemovedResults { get; }
    void Remove();
}