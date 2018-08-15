using System;
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

            foreach (XmlNode node in root.ChildNodes)
            {
                Console.WriteLine(node.NodeType);
            }

            Console.WriteLine("234");;
        }
    }
}
