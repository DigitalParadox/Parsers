using System;
using System.Collections.Generic;
using System.Text;
using DigitalParadox.Parsers.Serializers;
using Newtonsoft.Json;
namespace DigitalParadox.Parsers.Json
{
    public class JsonParser : IJSONParser
    {
        private readonly JsonSerializerSettings _settings;

        public JsonParser(JsonSerializerSettings settings)
        {
            _settings = settings;
        }

        public JsonParser()
        {
            _settings = new JsonSerializerSettings();
        }
        
        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text, _settings);
        }

        public object Deserialize(string text)
        {
            return JsonConvert.DeserializeObject(text, _settings);
        }
    }
}
