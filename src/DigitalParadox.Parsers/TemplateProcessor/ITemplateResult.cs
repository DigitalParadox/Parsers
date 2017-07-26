using System.Collections.Generic;

namespace DigitalParadox.Parsers.TemplateProcessor
{
    public interface ITemplateResult
    {
        string Result { get; }
        bool HasErrors { get; }
        ICollection<ITemplateError> Errors { get; }

    }
}
