using System;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class Email
    {
        public void Send(Product product)
        {
            Console.WriteLine("Sending Email...", product.Name, product.Price);
        }
    }
}
