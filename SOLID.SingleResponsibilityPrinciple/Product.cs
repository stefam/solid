using System;
using System.Text.Json;

namespace SOLID.SingleResponsibilityPrinciple
{
    // Before
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void SerializeAndSaveProductToDatabase()
        {
            var serialized = JsonSerializer.Serialize(this);
            Console.WriteLine("Serialized Product: {0}", serialized);
            Console.WriteLine("Saving Product...", this.Name, this.Price);
        }

        public void EmailProduct()
        {
            Console.WriteLine("Sending Email...", this.Name, this.Price);
        }
    }

    // After
    //public class Product
    //{
    //    public string Name { get; set; }

    //    public int Price { get; set; }

    //    public Product(string name, int price)
    //    {
    //        this.Name = name;
    //        this.Price = price;
    //    }
    //}
}
