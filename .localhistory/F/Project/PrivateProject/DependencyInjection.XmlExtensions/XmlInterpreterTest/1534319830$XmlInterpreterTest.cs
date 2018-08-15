using System.IO;
using DependencyInjection.XmlExtensions;
using Xunit;

namespace XmlExtensions.Test
{
    public class XmlInterpreterTest : TestBase
    {
        [Fact]
        public void ProcessFile_Test()
        {
            var components =
                new XmlInterpreter(FilePath).ProcessFile();

            Assert.NotNull(components);
            Assert.True(components.Count > 0);
        }
    }
}
