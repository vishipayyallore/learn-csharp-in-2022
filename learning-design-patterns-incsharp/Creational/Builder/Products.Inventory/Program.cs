// See https://aka.ms/new-console-template for more information
using FooterUtility;
using FooterUtility.Interfaces;
using HeaderUtility;
using HeaderUtility.Interfaces;
using Products.Inventory;

IHeader _header = new Header();
IFooter _footer = new Footer();

Console.WriteLine("Hello, World!");

_header.PrintHeader('*', "Product Inventory");

var product1 = new Product { Id = 1 };
Console.WriteLine(product1.Id);

_footer.PrintFooter('-');