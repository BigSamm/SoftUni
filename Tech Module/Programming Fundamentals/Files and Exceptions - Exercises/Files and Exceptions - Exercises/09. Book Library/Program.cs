using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Book_Library
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            ILibrary library = InitializeLibrary(count, "Library1");

            IEnumerable<IAuthor> orderedAuthors = library.Authors
                .OrderBy(a => -a.TotalBooksPrice)
                .ThenBy(a => a.Name);

            foreach (IAuthor author in orderedAuthors)
            {
                Console.WriteLine(author.Name + " -> " + author.TotalBooksPrice);
            }
        }

        private static ILibrary InitializeLibrary(int count, string libraryName)
        {
            ILibrary library = new Library(libraryName);

            for (int i = 0; i < count; i++)
            {
                string[] args = Console.ReadLine().Split();

                string bookTitle = args[0];
                string authorName = args[1];
                string publisher = args[2];
                DateTime releaseDate = DateTime.Parse(args[3]);
                string bookIsbn = args[4];
                decimal bookPrice = decimal.Parse(args[5]);

                IBook book = new Book(bookTitle, authorName, publisher, releaseDate, bookIsbn, bookPrice);
                IAuthor author = library.Authors.FirstOrDefault(a => a.Name == authorName);

                if (author == null)
                {
                    IAuthor newAuthor = new Author(authorName);
                    newAuthor.AddBook(book);
                    library.AddAuthor(newAuthor);
                }
                else
                {
                    author.AddBook(book);
                }
            }

            return library;
        }
    }
}
