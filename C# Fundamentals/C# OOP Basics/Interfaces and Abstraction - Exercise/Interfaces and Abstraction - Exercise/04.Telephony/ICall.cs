using System;
using System.Collections.Generic;
using System.Text;

public interface ICall
{
    List<string> Numbers { get; }

    void TryAddNumber(string number);
}
