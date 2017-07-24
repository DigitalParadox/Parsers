using System.Collections.Generic;
namespace DigitalParadox.Parsers
{
    public interface ICommandLineParser
    {
        IVerbDefinition Parse(IEnumerable<string> args);
    }
}
