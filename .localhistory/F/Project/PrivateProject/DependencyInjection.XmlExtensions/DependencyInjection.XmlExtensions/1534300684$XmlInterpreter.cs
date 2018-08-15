using System;
using System.Collections.Generic;
using System.Xml;

namespace DependencyInjection.XmlExtensions
{
    /// <summary>
    /// Xml文件解析器
    /// </summary>
    public class XmlInterpreter : IFileInterpreter
    {
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
            return string.Empty;
        }
    }
}