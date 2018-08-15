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

            throw new System.NotImplementedException();
        }

        private string GetXmlDocument(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            var xmlDocument = new XmlDocument();
            xmlDocument.Load("service.config");

            XmlNode root = xmlDocument.SelectSingleNode("configuration");

            return string.Empty;
        }
    }
}