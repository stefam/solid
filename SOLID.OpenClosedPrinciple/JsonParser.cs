using System;
using System.Text.Json;

namespace SOLID.OpenClosedPrinciple
{
    public class JsonParser : IParser
    {
        public string Parse<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
