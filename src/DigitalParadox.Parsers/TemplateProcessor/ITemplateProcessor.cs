using DigitalParadox.Parsers.TemplateProcessor;
using System.IO;

namespace DigitalParadox.Parsers.TemplateProcessor
{
    public interface ITemplateProcessor
    {
        ITemplateProcessorOptions Options { get; set; }
        void BeforeProcess(string template, object data);
        void Initialize(string template, object data);
        ITemplateResult Process(string template, object data);
        void AfterProcess(string template, object data);
        void InitializeProject(DirectoryInfo target);
    }
}
