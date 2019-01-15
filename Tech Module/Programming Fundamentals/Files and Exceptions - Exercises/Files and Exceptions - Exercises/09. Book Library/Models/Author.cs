using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Book_Library
{
    public class Author : IAuthor
    {
        private List<IBook> books;

        public Author(string name)
        {
            this.Name = name;

            this.books = new List<IBook>();
        }

        public string Name { get; }

        public IReadOnlyCollection<IBook> Books => this.books.AsReadOnly();

        public decimal TotalBooksPrice => this.books.Sum(b => b.Price);

        public void AddBook(IBook book)
        {
            this.books.Add(book);
        }
    }
}
