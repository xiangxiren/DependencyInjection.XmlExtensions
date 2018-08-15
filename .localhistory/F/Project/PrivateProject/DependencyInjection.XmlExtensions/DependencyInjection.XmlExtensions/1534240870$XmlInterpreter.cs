using System;
using System.Collections.Generic;

namespace DependencyInjection.XmlExtensions
{
    /// <summary>
    /// Xml文件解析器
    /// </summary>
    public class XmlInterpreter : IFileInterpreter
    {
        public List<Component> ProcessFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            throw new System.NotImplementedException();
        }
    }
}