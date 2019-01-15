using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Book_Library
{
    public interface IAuthor
    {
        string Name { get; }

        IReadOnlyCollection<IBook> Books { get; }

        decimal TotalBooksPrice { get; }

        void AddBook(IBook book);
    }
}
