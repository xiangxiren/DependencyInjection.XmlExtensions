using System.Collections.Generic;

namespace DependencyInjection.XmlExtensions
{
    public class Component
    {
        public string Type { get; set; }

        public string Service { get; set; }

        public string Lifetime { get; set; }
    }
}
