using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace SOLID.OpenClosedPrinciple
{
    public class Parser
    {
        public string Parse<T>(T obj, string type)
        {
            if ("json".Equals(type))
            {
                return JsonSerializer.Serialize(obj);
            }
            else if ("xml".Equals(type))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, obj);
                    return textWriter.ToString();
                }
            }
            else if ("csv".Equals(type))
            {
                // Parsing to csv
            }

            return string.Empty;
        }
    }
}
