namespace DigitalParadox.Parsers.Serializers
{
    public interface IDeserializer
    {
        T Deserialize<T>(string text);
        object Deserialize(string text);
    }
}