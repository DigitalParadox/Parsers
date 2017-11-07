using System.Collections.Generic;

namespace DigitalParadox.Parsers
{
    public interface IVerbResolver
    {
        IVerbDefinition Resolve(IEnumerable<string> args);
    }
}