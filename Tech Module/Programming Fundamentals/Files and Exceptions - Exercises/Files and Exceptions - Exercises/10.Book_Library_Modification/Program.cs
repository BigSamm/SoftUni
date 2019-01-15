using _09._Book_Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Book_Library_Modification
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            ILibrary library = InitializeLibrary(count, "Library1");

            DateTime validateDate = DateTime.Parse(Console.ReadLine());

            IEnumerable<IBook> validBooks = library.Books.Where(b => b.ReleaseDate > validateDate)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title);

            foreach (IBook book in validBooks)
            {
                string date = $"{book.ReleaseDate.Day}.{book.ReleaseDate.Month:d2}.{book.ReleaseDate.Year}";
                Console.WriteLine(book.Title + " -> " + date);
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
                library.AddBook(book);
            }

            return library;
        }
    }
}
