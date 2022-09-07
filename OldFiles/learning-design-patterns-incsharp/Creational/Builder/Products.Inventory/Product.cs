namespace Products.Inventory
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsAvailable { get; set; }

        public string Code { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public decimal Rating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Id} - {Name} - {Description} - {Price} - {Quantity} - {IsAvailable} - {Code} - {ReleaseDate} - {Rating} - {ImageUrl}";
        }

    }

}
