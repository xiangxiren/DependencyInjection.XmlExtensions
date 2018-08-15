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
                Console.WriteLine(node.NodeType);


            }

            Console.WriteLine("234");
        }
    }
}
