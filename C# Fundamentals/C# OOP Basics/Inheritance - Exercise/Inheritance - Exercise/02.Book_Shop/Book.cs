using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
    private const int MIN_TITLE_LENGTH = 3;
    private const int MIN_PRICE = 1;

    protected virtual string Type { get; set; } = "Book";
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    protected virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value < MIN_PRICE)
                throw new ArgumentException("Price not valid!");
            price = value;
        }
    }

    protected virtual string Author
    {
        get { return author; }
        set
        {
            ValidateAuthorName(value);
            author = value;
        }
    }

    protected virtual string Title
    {
        get { return title; }
        set
        {
            if (value.Length < MIN_TITLE_LENGTH)
                throw new ArgumentException("Title not valid!");
            title = value;
        }
    }

    private void ValidateAuthorName(string name)
    {
        var nameList = name.Split();

        if (nameList.Length == 2)
        {
            var lastName = nameList[1];

            var firstChar = lastName.First().ToString();
            var isDigit = int.TryParse(firstChar, out int value);

            if (isDigit)
                throw new ArgumentException("Author not valid!");
        }
    }

    public override string ToString()
    {
        return $"Type: {Type}\n" +
               $"Title: {Title}\n" +
               $"Author: {Author}\n" +
               $"Price: {Price:f2}";
    }
}
