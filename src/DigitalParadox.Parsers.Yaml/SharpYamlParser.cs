using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpYaml.Serialization;

namespace DigitalParadox.Parsers.Yaml
{
    public class SharpYamlParser : ISerializer, IDeserializer, IYamlParser
    {
        private readonly Serializer _serializer;

        public SharpYamlParser(Serializer serializer)
        {
            _serializer = serializer;
        }

        public string Serialize(object data)
        {
            var yaml = _serializer.Serialize(data);
            return yaml;
        }

        public T Deserialize<T>(string yaml)
        {
            var obj = _serializer.Deserialize<T>(yaml);
            return obj;
        }

        public object Deserialize(string yaml)
        {
            var obj = _serializer.Deserialize(yaml);
            return obj;
        }
    }
}
