using System;
using CommandLine.Infrastructure;
using Unity;

namespace DigitalParadox.Parsers.CommandLine
{
    public class UnityObjectFactory : IObjectFactory
    {
        public IUnityContainer Container { get; set; }
        public UnityObjectFactory(IUnityContainer container)
        {
            Container = container;
        }
        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return Container.Resolve(type);
        }
    }
}