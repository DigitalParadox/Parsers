using System;

namespace DigitalParadox.Parsers.TemplateProcessor
{
    public interface ITemplateError
    {
        string Description { get; set; }
        string Name { get; set; }
        Exception Exception { get; set; }
    }
}
