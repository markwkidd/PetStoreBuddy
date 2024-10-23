using System;

namespace PetStore
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public Product()
        {
            Price = 0;
            Quantity = 0;
            Description = string.Empty;
            Name = string.Empty;
        }
    }
}
