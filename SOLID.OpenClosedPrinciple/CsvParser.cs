namespace SOLID.OpenClosedPrinciple
{
    public class CsvParser : IParser
    {
        public string Parse<T>(T obj)
        {
            var csv = " Object parsed to Csv ";

            return csv;
        }
    }
}
