using System;
using System.Linq;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load("service.config");

            var root = xmlDocument.SelectSingleNode("configuration");

            var componentsNode = root.SelectSingleNode("//components");

            foreach (XmlNode node in componentsNode.ChildNodes)
            {
                if (node.NodeType != XmlNodeType.Element) continue;

                Console.WriteLine(node.Name);

                var type = node.Attributes["type"]?.Value;
                var service = node.Attributes["service"].Value;
                var lifestyle = node.Attributes["lifetime"].Value;

                var parametersNode = node.ChildNodes.SelectSingleNode("//parameters");
            }

            Console.WriteLine("234");
        }
    }
}
