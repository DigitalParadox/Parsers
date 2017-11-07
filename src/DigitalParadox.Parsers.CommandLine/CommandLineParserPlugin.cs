using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;
using DigitalParadox.Utilities.AssemblyLoader;
using Parsers.CommandLine;
using Unity;
using Unity.Extension;
using Unity.Injection;
using Unity.Lifetime;

namespace DigitalParadox.Parsers.CommandLine
{


    
    public  class CommandLineParserPlugin : UnityContainerExtension
    {
        protected override void Initialize()
        {

            var verbs = AssemblyLoader.GetAssemblies<IVerbDefinition>(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory))
                .GetTypes<IVerbDefinition>().Where(q => !q.IsInterface).ToList();
            
            verbs.ForEach(q =>
            {
                Container.RegisterType(typeof(IVerbDefinition), q, q.AssemblyQualifiedName, new ExternallyControlledLifetimeManager());
            });

            Container.RegisterType<IEnumerable<IVerbDefinition>>(
                new InjectionFactory(inject => Container.ResolveAll<IVerbDefinition>()));

            Container.RegisterInstance(new Parser(settings => Container.Resolve<ParserSettings>()));

            ParserSettings.ObjectFactory = new UnityObjectFactory(Container);

            Container.RegisterType<IVerbResolver, VerbResolver>();

            Container.RegisterType<IVerbDefinition>(new InjectionFactory(inject =>
            {
                var resolver = inject.Resolve<IVerbResolver>();
                return resolver.Resolve(Environment.GetCommandLineArgs());
            }));


            Container.RegisterInstance(new Parser(settings => Container.Resolve<ParserSettings>()));
            
            ParserSettings.ObjectFactory  = new UnityObjectFactory(Container);

            Container.RegisterInstance(
                new ParserSettings()
                {
                    CaseInsensitiveEnumValues = true,
                    EnableDashDash = true,
                    CaseSensitive = false
                });
        }


    }
}
