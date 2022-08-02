using System;

namespace SOLID.InterfaceSegregationPrinciple
{
    // Before
    public class SimplePrinter : IMultifunctionalPrinter
    {
        public void Fax(string content)
        {
            throw new NotImplementedException();
        }

        public void Print(string content)
        {
            Console.WriteLine($"Print: {content}");
        }

        public void Scan(string content)
        {
            throw new NotImplementedException();
        }
    }

    // After
    //public class SimplePrinter : IPrinter
    //{
    //    public void Print(string content)
    //    {
    //        Console.WriteLine($"Print: {content}");
    //    }
    //}
}
