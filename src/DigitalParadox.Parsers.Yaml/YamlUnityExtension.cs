﻿using System.Linq;
using DigitalParadox.Parsers.Serializers;
using SharpYaml.Serialization;
using Unity;
using Unity.Extension;

namespace DigitalParadox.Parsers.Yaml
{
    public class YamlUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterInstance<IObjectFactory>(new LambdaObjectFactory(
                type =>
                {
                    if (Container.Registrations.Any(registration => registration.RegisteredType == type))
                    {
                        return Container.Resolve(type);
                    }
                    else
                    {
                        return null;
                    }
                },
                new DefaultObjectFactory()));

            Container.RegisterInstance(new SerializerSettings()
            {
                ObjectFactory = Container.Resolve<IObjectFactory>()
            });

            Container.RegisterType<Serializer>();
            Container.RegisterType<IYamlParser, SharpYamlParser>();
            
        }
    }
}
