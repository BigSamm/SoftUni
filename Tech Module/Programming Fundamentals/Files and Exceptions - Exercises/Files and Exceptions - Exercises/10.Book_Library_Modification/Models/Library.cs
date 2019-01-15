using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Book_Library
{
    public class Library : ILibrary
    {
        private List<IBook> books;

        public Library(string name)
        {
            this.Name = name;

            this.books = new List<IBook>();
        }

        public string Name { get; }

        public IReadOnlyCollection<IBook> Books => this.books.AsReadOnly();

        public void AddBook(IBook book)
        {
            this.books.Add(book);
        }
    }
}
