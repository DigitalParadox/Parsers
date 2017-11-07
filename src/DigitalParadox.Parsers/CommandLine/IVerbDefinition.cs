
namespace DigitalParadox.Parsers
{
    public interface IVerbDefinition 
    {
        bool Verbose { get; set; }
        int Execute();
    }
}