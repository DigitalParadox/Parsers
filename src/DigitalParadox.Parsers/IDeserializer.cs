namespace DigitalParadox.Parsers
{
    public interface IDeserializer
    {
        T Deserialize<T>(string yaml);
        object Deserialize(string yaml);
    }
}