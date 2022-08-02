using System.Text.Json;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class Serializer
    {
        public string Serialize(Product obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
