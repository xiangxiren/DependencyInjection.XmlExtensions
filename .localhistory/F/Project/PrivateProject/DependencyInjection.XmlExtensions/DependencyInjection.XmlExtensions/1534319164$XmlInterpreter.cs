using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace DependencyInjection.XmlExtensions
{
    /// <summary>
    ///   从一个xml文件中读取配置
    ///   <code>
    ///     &lt;configuration&gt;
    ///   
    ///     &lt;components&gt;
    ///     &lt;component id="component1"&gt;
    ///     
    ///     &lt;/component&gt;
    ///     &lt;/components&gt;
    ///     &lt;/configuration&gt;
    ///   </code>
    /// </summary>
    public class XmlInterpreter
    {
        protected static readonly string ComponentsNodeName = "components";
        protected static readonly string ComponentNodeName = "component";
        protected static readonly string TypeAttributeName = "type";
        protected static readonly string ServiceAttributeName = "service";
        protected static readonly string LifetimeAttributeName = "lifetime";

        private readonly string _filePath;

        public XmlInterpreter(string filePath)
        {
            _filePath = filePath;
        }

        public List<Component> ProcessFile()
        {
            var root = ReadServiceConfigFile();

            return ProcessComponentsNode(root);
        }

        private XmlNode ReadServiceConfigFile()
        {
            if (string.IsNullOrWhiteSpace(_filePath))
            {
                throw new ArgumentNullException(nameof(_filePath));
            }

            var xmlDocument = new XmlDocument();
            xmlDocument.Load("service.config");

            if (xmlDocument == null)
            {
                throw new ArgumentException($"从文件{_filePath}中未读取到任何配置");
            }

            var root = xmlDocument.SelectSingleNode("configuration");

            if (root == null)
            {
                throw new ArgumentException($"从文件{_filePath}中未读取到任何配置");
            }

            return root;
        }

        private List<Component> ProcessComponentsNode(XmlNode rootNode)
        {
            var components = new List<Component>();

            var componentsNode = rootNode.SelectSingleNode($"//{ComponentsNodeName}");
            if (componentsNode == null)
            {
                throw new Exception($"从配置文件中未能读取到节点{ComponentsNodeName}");
            }

            foreach (XmlNode componentNode in componentsNode.ChildNodes)
            {
                if (componentNode.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                if (componentNode.Attributes == null)
                {
                    continue;
                }

                var type = componentNode.Attributes[TypeAttributeName]?.Value?.Trim();
                var service = componentNode.Attributes[ServiceAttributeName]?.Value?.Trim();
                var lifetime = componentNode.Attributes[LifetimeAttributeName]?.Value?.Trim();

                var component = new Component
                {
                    Type = type,
                    Service = service,
                    Lifetime = lifetime
                };

                components.Add(component);
            }

            return components;
        }
    }
}