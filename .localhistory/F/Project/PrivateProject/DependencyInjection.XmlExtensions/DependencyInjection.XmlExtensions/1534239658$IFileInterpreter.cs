using System.Collections.Generic;

namespace DependencyInjection.XmlExtensions
{
    public interface IFileInterpreter
    {
        List<Component> ProcessFile(string filePath);
    }
}