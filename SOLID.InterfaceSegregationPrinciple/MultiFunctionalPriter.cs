using System;

namespace SOLID.InterfaceSegregationPrinciple
{
    //Before
    public class MultifunctionalPriter : IMultifunctionalPrinter
    {
        public void Fax(string content)
        {
            Console.WriteLine($"Send Fax: {content}");
        }

        public void Print(string content)
        {
            Console.WriteLine($"Print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"Scan: {content}");
        }
    }

    // After
    //public class MultiFunctionalPriter : IPrinter, IScanner, IFax
    //{
    //    public void Fax(string content)
    //    {
    //        Console.WriteLine($"Send Fax: {content}");
    //    }

    //    public void Print(string content)
    //    {
    //        Console.WriteLine($"Print: {content}");
    //    }

    //    public void Scan(string content)
    //    {
    //        Console.WriteLine($"Scan: {content}");
    //    }
    //}
}
