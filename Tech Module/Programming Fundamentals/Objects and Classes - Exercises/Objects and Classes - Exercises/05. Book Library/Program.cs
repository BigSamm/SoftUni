using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library
{
    class Program
    {
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public long ISBNnumber { get; set; }
            public decimal Price { get; set; }
        }

        static void Main(string[] args)
        {
            List<Book> allBooks = GetAllBooks();
            List<Library> allLibrary = GetAllLibrary(allBooks);
            var result = new Dictionary<string, decimal>();
            foreach (var x in allBooks)
            {
                if (result.ContainsKey(x.Author))
                    result[x.Author] += x.Price;
                else
                    result[x.Author] = x.Price;
            }
            var orderedResult = result.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in orderedResult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        static List<Library> GetAllLibrary(List<Book> allBooks)
        {
            var allLibrary = new List<Library>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                Library library = new Library
                {
                    Name = allBooks[i].Title,
                    Books = allBooks
                };
                allLibrary.Add(library);
            }
            return allLibrary;
        }

        static List<Book> GetAllBooks()
        {
            var n = int.Parse(Console.ReadLine());
            var allBooks = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                Book book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",
                    CultureInfo.InvariantCulture),
                    ISBNnumber = long.Parse(input[4]),
                    Price = decimal.Parse(input[5])
                };
                allBooks.Add(book);
            }
            return allBooks;
        }
    }
}
