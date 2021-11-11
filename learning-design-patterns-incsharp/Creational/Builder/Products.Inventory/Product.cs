﻿namespace Products.Inventory
{
    internal class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Code { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public decimal StarRating { get; set; }
    }

}
