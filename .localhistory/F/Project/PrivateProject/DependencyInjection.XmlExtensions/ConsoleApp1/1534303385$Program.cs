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
                var parametersNode = node.SelectSingleNode("//parameters");
            }

            Console.WriteLine("234");
        }
    }
}
