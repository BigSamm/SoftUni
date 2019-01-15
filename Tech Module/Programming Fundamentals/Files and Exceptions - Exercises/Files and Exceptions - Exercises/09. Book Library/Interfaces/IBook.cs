using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Book_Library
{
    public interface IBook
    {
        string Title { get; }

        string Author { get; }

        string Publisher { get; }

        DateTime ReleaseDate { get; }

        string ISBN { get; }

        decimal Price { get; }
    }
}
