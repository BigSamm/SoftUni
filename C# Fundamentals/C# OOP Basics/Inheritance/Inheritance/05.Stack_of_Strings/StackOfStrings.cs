using System;
using System.Collections.Generic;
using System.Text;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        var last = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);

        return last;
    }

    public string Peek()
    {
        var last = data[data.Count - 1];
        return last;
    }

    public bool IsEmpty()
    {
        if (data.Count == 1)
            return true;

        return false;
    }
}
