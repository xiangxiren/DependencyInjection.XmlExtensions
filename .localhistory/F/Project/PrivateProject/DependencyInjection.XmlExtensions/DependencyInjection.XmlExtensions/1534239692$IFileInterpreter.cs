using System.Collections.Generic;

namespace DependencyInjection.XmlExtensions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileInterpreter
    {
        List<Component> ProcessFile(string filePath);
    }
}