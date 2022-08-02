using System;

namespace SOLID.InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IMultifunctionalPrinter mPrinter = new MultifunctionalPriter();
            mPrinter.Print("Hello World!");
            mPrinter.Scan("Hello World!");
            mPrinter.Fax("Hello World!");

            // Before
            IMultifunctionalPrinter sPrinter = new SimplePrinter();
            sPrinter.Print("Hello World!");
            sPrinter.Scan("Hello World!");
            sPrinter.Fax("Hello World!");

            // After
            //IMultifunctionalPrinter sPrinter = new SimplePrinter();
            //sPrinter.Print("Hello World!");
            //sPrinter.Scan("Hello World!");

            Console.ReadLine();
        }
    }
}
