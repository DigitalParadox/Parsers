using System.Linq;
using DigitalParadox.Parsers.Serializers;
using Unity.Extension;
using Unity;


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
