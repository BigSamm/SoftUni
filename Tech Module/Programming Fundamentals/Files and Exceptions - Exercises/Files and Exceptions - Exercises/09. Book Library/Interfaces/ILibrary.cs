using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Book_Library
{
    public interface ILibrary
    {
        string Name { get; }

        IReadOnlyCollection<IAuthor> Authors { get; }

        void AddAuthor(IAuthor author);
    }
}
