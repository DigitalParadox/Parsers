using System.IO;

namespace DigitalParadox.Parsers.TemplateProcessor
{
    public interface ITemplateProcessorOptions
    {
        DirectoryInfo BaseDirectory { get; set; }
    }
}
