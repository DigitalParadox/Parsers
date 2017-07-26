using System.Collections.Generic;

namespace DigitalParadox.Parsers.CommandLine
{
    public interface ICommandLineParser
    {
        IVerbDefinition Parse(IEnumerable<string> args);
    }
}
