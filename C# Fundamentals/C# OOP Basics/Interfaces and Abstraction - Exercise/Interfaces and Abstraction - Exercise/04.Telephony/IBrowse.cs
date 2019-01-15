using System;
using System.Collections.Generic;
using System.Text;

public interface IBrowse
{
    List<string> Browsers { get; }

    void TryAddBrowser(string browser);
}
