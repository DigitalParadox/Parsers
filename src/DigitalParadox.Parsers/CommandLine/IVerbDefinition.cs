
namespace DigitalParadox.Parsers.CommandLine
{
    public interface IVerbDefinition 
    {
        bool Verbose { get; set; }
        int Execute();
    }
}