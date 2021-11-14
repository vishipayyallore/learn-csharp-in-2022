// See https://aka.ms/new-console-template for more information
using Products.Inventory;
using Products.Inventory.Interfaces;



IProductReportBuilder productReportBuilder = new ProductReportBuilder();

productReportBuilder
    .AddHeader("Product Inventory")
    .AddProductDetails(GetProducts())
    .AddFooter("Thank you for your business!")
    .AddLogisticsDetails("SriVaru");


static IEnumerable<Product> GetProducts()
{
    return new List<Product>
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "iPhone",
            Description = "Apple's latest phone",
            Price = 1000,
            Quantity = 5,
            IsAvailable = true,
            Code = "A1",
            ReleaseDate = DateTime.Now,
            Rating = 4.5M,
            ImageUrl = "https://www.someaddress.com/iphone/",
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "MSFT",
            Description = "MSFT's latest phone",
            Price = 1002,
            Quantity = 4,
            IsAvailable = true,
            Code = "A2",
            ReleaseDate = DateTime.Now,
            Rating = 4.5M,
            ImageUrl = "https://www.someaddress.com/msftphone/",
        },
    };
}



// IHeader _header = new Header();
// IFooter _footer = new Footer();

// const int _patternLength = 170;

// _header.PrintHeader('*', "Product Inventory", _patternLength);

// var product1 = new Product
// {
//     Id = Guid.NewGuid(),
//     Name = "iPhone",
//     Description = "Apple's latest phone",
//     Price = 1000,
//     Quantity = 5,
//     IsAvailable = true,
//     Code = "A1",
//     ReleaseDate = DateTime.Now,
//     Rating = 4.5M,
//     ImageUrl = "https://www.someaddress.com/iphone/",
// };

// Console.WriteLine($"{product1}");

// _footer.PrintFooter('-', _patternLength);
