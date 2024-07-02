using System.Xml.Serialization;

namespace SimpleAdapter
{
    public class XmlParser<T> : IXmlParser<T>
    {
        private readonly XmlSerializer _serializer;
        public XmlParser()
        {
            _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(typeof(T).Name.ToLower()));
        }
        public T Parse(string xml)
        {
            using TextReader reader = new StringReader(xml);
            return (T)_serializer.Deserialize(reader);
        }
        public string ConvertToXml(Task obj)
        {
            using StringWriter textWriter = new();
            _serializer.Serialize(textWriter, obj);

            return textWriter.ToString();
        }

    }
}
