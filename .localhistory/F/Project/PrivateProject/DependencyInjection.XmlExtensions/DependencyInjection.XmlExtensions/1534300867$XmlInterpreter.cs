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
        private const 

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



            return components;
        }
    }
}