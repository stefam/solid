using System.IO;
using System.Xml.Serialization;

namespace SOLID.OpenClosedPrinciple
{
    public class XmlParser : IParser
    {
        public string Parse<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }
    }
}
