using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class Component
    {
        public string Type { get; set; }

        public string Service { get; set; }

        public ServiceLifetime Lifetime { get; set; }

        public List<Parameter> Parameters { get; set; }
    }
}
