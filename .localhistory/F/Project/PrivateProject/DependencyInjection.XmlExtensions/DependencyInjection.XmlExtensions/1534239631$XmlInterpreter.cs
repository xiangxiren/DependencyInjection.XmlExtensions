using System.Collections.Generic;

namespace DependencyInjection.XmlExtensions
{
    public class XmlInterpreter : IFileInterpreter
    {
        private readonly string _filePath;

        public XmlInterpreter(string filePath)
        {
            _filePath = filePath;
        }

        public List<Component> ProcessFile()
        {
            throw new System.NotImplementedException();
        }
    }
}