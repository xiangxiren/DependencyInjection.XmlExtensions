using System.IO;

namespace XmlExtensions.Test
{
    public class TestBase
    {
        protected readonly string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "service.config");
    }
}