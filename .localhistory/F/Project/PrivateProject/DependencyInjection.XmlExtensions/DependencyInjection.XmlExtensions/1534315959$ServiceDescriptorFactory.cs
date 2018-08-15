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

            if (components.Any(t => string.IsNullOrWhiteSpace(t.Type)))
            {
                throw new Exception("存在type为空的配置");
            }

            foreach (var component in components)
            {
                var implementType = Type.GetType(component.Type);

                if (implementType == null)
                {
                    throw new Exception($"未能将{component.Type}转换成有效类型");
                }

                if (implementType.IsClass)
                {

                }

            }

            return null;
        }
    }
}