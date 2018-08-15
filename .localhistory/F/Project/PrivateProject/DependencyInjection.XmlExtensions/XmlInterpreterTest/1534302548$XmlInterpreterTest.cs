using System.IO;
using DependencyInjection.XmlExtensions;
using Xunit;

namespace XmlExtensions.Test
{
    public class XmlInterpreterTest
    {
        [Fact]
        public void ProcessFile_Test()
        {
            var components =
                new XmlInterpreter().ProcessFile(Path.Combine(Directory.GetCurrentDirectory(), "service.config"));

        }
    }
}
