using System;
using System.Collections.Generic;
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
    public class XmlInterpreter : IFileInterpreter
    {
        protected static readonly string ComponentsNodeName = "components";
        protected static readonly string ComponentNodeName = "component";
        protected static readonly string ParametersNodeName = "parameters";
        protected static readonly string ParameterNodeName = "parameter";

        public List<Component> ProcessFile(string filePath)
        {
            var root = GetXmlDocument(filePath);



            throw new System.NotImplementedException();
        }

        private XmlNode GetXmlDocument(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            var xmlDocument = new XmlDocument();
            xmlDocument.Load("service.config");

            if (xmlDocument == null)
            {
                throw new ArgumentException($"从文件{filePath}中未读取到任何配置");
            }

            var root = xmlDocument.SelectSingleNode("configuration");

            if (root == null)
            {
                throw new ArgumentException($"从文件{filePath}中未读取到任何配置");
            }

            return root;
        }

        private List<Component> MyFunction(XmlNode rootNode)
        {
            var components = new List<Component>();

            var componentsNode = rootNode.SelectSingleNode($"//{ComponentsNodeName}");
            if (componentsNode == null)
            {
                throw new Exception($"从配置文件中未能读取到节点{ComponentsNodeName}");
            }

            foreach (XmlNode node in componentsNode.ChildNodes)
            {
                if (node.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                if (node.Attributes == null)
                {
                    continue;
                }

                var type = node.Attributes["type"];
                var service = node.Attributes["service"];
                var lifestyle = node.Attributes["lifestyle"];



                var component = new Component
                {

                };
                Console.WriteLine(node.Name);


            }


            return components;
        }
    }
}