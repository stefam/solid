using System;

namespace SOLID.SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Bumpers", 100);

            // Before
            product.SerializeAndSaveProductToDatabase();
            product.EmailProduct();

            // After
            //var serialized = new Serializer().Serialize(product);
            //Console.WriteLine($"Serialized product {serialized}");

            //new Repository().Save(product);
            //new Email().Send(product);

            //Console.ReadLine();
        }
    }
}
