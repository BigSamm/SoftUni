using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Iterator_Test
{
    public interface IListIterator
    {
        List<string> Items { get; }

        int CurrentIndex { get; }

        string CurrentItem { get; }

        void Create(List<string> items);

        bool Move();

        bool HasNext();

        string Print();
    }
}
