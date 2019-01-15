using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Book_Library
{
    public class Library : ILibrary
    {
        private List<IAuthor> authors;

        public Library(string name)
        {
            this.Name = name;

            this.authors = new List<IAuthor>();
        }

        public string Name { get; }

        public IReadOnlyCollection<IAuthor> Authors => this.authors.AsReadOnly();

        public void AddAuthor(IAuthor author)
        {
            this.authors.Add(author);
        }
    }
}
