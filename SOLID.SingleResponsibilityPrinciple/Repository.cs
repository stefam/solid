using System;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class Repository
    {
        public void Save(Product product)
        {
            Console.WriteLine("Saving Product...", product.Name, product.Price);
        }
    }
}
