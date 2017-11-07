using System.Collections.Generic;
using DigitalParadox.Parsers;

namespace DigitalParadox.Parsers.CommandLine
{
    public class CommandLineParser : ICommandLineParser
    {
        private readonly IVerbResolver _resolver;

        public CommandLineParser(IVerbResolver resolver)
        {
            _resolver = resolver;
        }


        public IVerbDefinition Parse(IEnumerable<string> args)
        {
            return _resolver.Resolve(args);
            
        }
    }
}
