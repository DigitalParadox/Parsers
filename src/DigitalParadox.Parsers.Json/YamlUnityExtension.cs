using System.Linq;
using DigitalParadox.Parsers.Serializers;
using Microsoft.Practices.Unity;

namespace DigitalParadox.Parsers.Json
{
    public class JsonUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IJSONParser, JsonParser>();
        }
    }
}
