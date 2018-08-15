using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class Component
    {
        /// <summary>
        /// 需要注入服务的实现类型的完全限定名
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 需要注入服务类型的完全限定名
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceLifetime Lifetime { get; set; }

        public List<Parameter> Parameters { get; set; }
    }
}
