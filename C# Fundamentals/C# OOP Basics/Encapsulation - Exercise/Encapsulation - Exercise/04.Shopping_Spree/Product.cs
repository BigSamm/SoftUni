using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private decimal price;

    public Product() { }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public decimal Price
    {
        get { return price; }
        private set
        {
            Validations.ValidateMoney(value);
            price = value;
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            Validations.ValidateName(value);
            name = value;
        }
    }

    public override string ToString()
    {
        return Name;
    }
}
