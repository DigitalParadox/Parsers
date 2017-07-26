using System.Collections.Generic;

namespace DigitalParadox.Parsers.CommandLine
{
    public interface IVerbResolver
    {
        IVerbDefinition Resolve(IEnumerable<string> args);
    }
}