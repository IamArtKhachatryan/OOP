using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Phone", Price = 1200 },
            new Product { Name = "Mouse", Price = 800 },
            new Product { Name = "Keyboard", Price = 950 },
            new Product { Name = "Monitor", Price = 2000 }
        };

        var cheapProducts = products.Where(p => p.Price < 1000);

        Console.WriteLine("Products with price < 1000:");
        foreach (var p in cheapProducts)
            Console.WriteLine($"{p.Name} - {p.Price} AMD");
    }
}
