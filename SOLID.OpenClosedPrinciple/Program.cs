using System;

namespace SOLID.OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Bumper", 100);

            // Before
            var json = new Parser().Parse(product, "json");
            Console.WriteLine(json);

            var xml = new Parser().Parse(product, "xml");
            Console.WriteLine(xml);

            // After
            //IParser jsonParser = new JsonParser();
            //var json = jsonParser.Parse(product);

            //IParser xmlParser = new XmlParser();
            //var xml = xmlParser.Parse(product);

            //IParser csvParser = new CsvParser();
            //var csv = csvParser.Parse(product);

            Console.ReadLine();
        }
    }
}
