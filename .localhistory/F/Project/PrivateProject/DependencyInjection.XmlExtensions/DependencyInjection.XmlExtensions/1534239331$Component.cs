using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class Component
    {
        public string Type { get; set; }

        /// <summary>
        /// 需要注入的服务类型完全限定名
        /// </summary>
        /// <example>FES.Component.Implemente.ProductC, FES.Component</example>
        public string Service { get; set; }

        public ServiceLifetime Lifetime { get; set; }

        public List<Parameter> Parameters { get; set; }
    }
}
