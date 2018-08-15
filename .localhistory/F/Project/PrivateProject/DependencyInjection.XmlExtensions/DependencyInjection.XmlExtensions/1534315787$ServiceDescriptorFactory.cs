using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class ServiceDescriptorFactory
    {
        public List<ServiceDescriptor> CreateServiceDescriptors(string filePath)
        {
            var components = new XmlInterpreter(filePath).ProcessFile();

            if (components == null || components.Count <= 0)
            {
                return null;
            }

            if (components.Any(t => string.IsNullOrWhiteSpace(t.Service)))
            {
                throw new Exception("存在service为空的配置");
            }

            foreach (var component in components)
            {

            }

            return null;
        }
    }
}