using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            var serviceDescriptors = new List<ServiceDescriptor>();

            foreach (var component in components)
            {
                var serviceLifetime = EnsureServiceLifetime(component.Lifetime);

                var implementType = EnsureComponentType(component.Type);
                var interfaceType = implementType;

                if (!string.IsNullOrWhiteSpace(component.Service))
                {
                    interfaceType = EnsureComponentService(component.Service);
                }

                serviceDescriptors.Add(new ServiceDescriptor(interfaceType, implementType, serviceLifetime));
            }

            return serviceDescriptors;
        }

        private ServiceLifetime EnsureServiceLifetime(string componentLifetime)
        {
            ServiceLifetime serviceLifetime;

            if (string.IsNullOrWhiteSpace(componentLifetime))
            {
                serviceLifetime = ServiceLifetime.Singleton;
            }
            else
            {
                if (!Enum.TryParse(componentLifetime, out serviceLifetime))
                {
                    throw new Exception($"lifetime为{componentLifetime}不是有效的服务生命周期");
                }
            }

            return serviceLifetime;
        }

        private Type EnsureComponentType(string componentType)
        {
            var implementType = Type.GetType(componentType);

            if (implementType == null)
            {
                throw new Exception($"未能将type为{componentType}转换成有效类型");
            }

            if (!implementType.IsClass)
            {
                throw new Exception($"未能将type为{componentType}转换为类类型");
            }

            if (implementType.IsAbstract)
            {
                throw new Exception($"未能将type为{componentType}转换为类类型");
            }

            var constructors = implementType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

            if (!constructors.Any())
            {
                throw new Exception($"将type为{componentType}转换的类型不具有公共的实例构造函数");
            }

            return implementType;
        }

        private Type EnsureComponentService(string componentService)
        {
            var implementType = Type.GetType(componentService);

            if (implementType == null)
            {
                throw new Exception($"未能将type为{componentService}转换成有效类型");
            }

            if (!implementType.IsInterface)
            {
                throw new Exception($"未能将type为{componentService}转换为接口类型");
            }

            return implementType;
        }
    }
}