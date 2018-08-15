using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class Component
    {
        /// <summary>
        /// 需要注册服务的实现类型的完全限定名
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 需要注册服务类型的完全限定名
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 服务的生命周期
        /// </summary>
        /// <see cref="ServiceLifetime"/>
        public ServiceLifetime Lifetime { get; set; }

        /// <summary>
        /// 服务实现的构造函数的参数，仅支持基础类型
        /// </summary>
        public List<Parameter> Parameters { get; set; }
    }
}
