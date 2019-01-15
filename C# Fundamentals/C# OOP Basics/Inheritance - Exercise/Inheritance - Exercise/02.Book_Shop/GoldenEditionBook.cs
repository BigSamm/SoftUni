using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price) { }

    protected override decimal Price
    {
        get
        {
            return base.Price * (decimal)1.3;
        }
    }

    protected override string Type { get; set; } = "GoldenEditionBook";

    public override string ToString()
    {
        return base.ToString();
    }
}
