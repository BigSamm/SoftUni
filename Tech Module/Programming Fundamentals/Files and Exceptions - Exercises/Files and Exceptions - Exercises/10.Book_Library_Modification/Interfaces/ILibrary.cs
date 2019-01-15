using System.Collections.Generic;

namespace _09._Book_Library
{
    public interface ILibrary
    {
        string Name { get; }

        IReadOnlyCollection<IBook> Books { get; }

        void AddBook(IBook book);
    }
}
