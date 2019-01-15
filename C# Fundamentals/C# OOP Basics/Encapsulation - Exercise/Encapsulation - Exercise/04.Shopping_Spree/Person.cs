using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person() { }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Products = new List<Product>();
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }
    
    public decimal Money
    {
        get { return money; }
        set
        {
            Validations.ValidateMoney(value);
            money = value;
        }
    }
    
    public string Name
    {
        get { return name; }
        set
        {
            Validations.ValidateName(value);
            name = value;
        }
    }

    public void TryBuyProduct(Product product)
    {
        if (Money >= product.Price)
        {
            Products.Add(product);
            Money -= product.Price;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append(Name + " - ");

        if (products.Count == 0)
            result.Append("Nothing bought");
        else
            result.Append(String.Join(", ", products));

        return result.ToString();
    }
}
