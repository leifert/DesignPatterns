namespace SimpleAdapter
{
    // Adaptee -> The interface that is incompatible with the Target interface
    public interface IXmlParser<T>
    {
        T Parse(string xml);
        string ConvertToXml(Task obj);
    }
}
