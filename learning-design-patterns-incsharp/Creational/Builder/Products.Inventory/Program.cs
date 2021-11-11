// See https://aka.ms/new-console-template for more information
using Products.Inventory;

Console.WriteLine("Hello, World!");


var product1 = new Product { Id = Guid.NewGuid() };

Console.WriteLine(product1.Id);