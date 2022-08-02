using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosedPrinciple
{
    public class Product
    {
        public Product() { }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
