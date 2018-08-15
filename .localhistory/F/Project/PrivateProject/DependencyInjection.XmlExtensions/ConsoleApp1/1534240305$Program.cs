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

            XmlNode root = xmlDoc.SelectSingleNode("configuration");

            Console.ReadKey();
        }
    }
}
