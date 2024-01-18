using System;

namespace Vetores
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product (string nome, double price)
        {
            Name = nome;
            Price = price;
        }
    }
}
