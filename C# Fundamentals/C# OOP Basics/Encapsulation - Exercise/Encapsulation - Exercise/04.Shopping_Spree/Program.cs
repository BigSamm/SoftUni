using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = ParseAllPersons();
        List<Product> products = ParseAllProducts();

        string command;
        while((command = Console.ReadLine()) != "END")
        {
            var inputList = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var personName = inputList[0];
            var productName = inputList[1];

            var person = persons.Find(p => p.Name == personName);
            var product = products.Find(p => p.Name == productName);

            person.TryBuyProduct(product);
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
    }

    private static List<Product> ParseAllProducts()
    {
        var products = new List<Product>();

        var productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (var currentProduct in productsInput)
        {
            var productList = currentProduct.Split('=', StringSplitOptions.RemoveEmptyEntries);
            var productName = productList[0];
            var productPrice = decimal.Parse(productList[1]);

            var product = new Product();
            try
            {
                product = new Product(productName, productPrice);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            products.Add(product);
        }

        return products;
    }

    private static List<Person> ParseAllPersons()
    {
        var persons = new List<Person>();

        var personsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (var currentPerson in personsInput)
        {
            var personList = currentPerson.Split('=', StringSplitOptions.RemoveEmptyEntries);
            var personName = personList[0];
            var personMoney = decimal.Parse(personList[1]);

            var person = new Person();
            try
            {
                person = new Person(personName, personMoney);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            persons.Add(person);
        }

        return persons;
    }
}
