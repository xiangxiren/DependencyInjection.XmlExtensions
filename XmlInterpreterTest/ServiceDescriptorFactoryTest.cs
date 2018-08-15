using DependencyInjection.XmlExtensions;
using Xunit;

namespace XmlExtensions.Test
{
    public class ServiceDescriptorFactoryTest : TestBase
    {
        [Fact]
        public void CreateServiceDescriptors_Test()
        {
            var list = new ServiceDescriptorFactory().CreateServiceDescriptors(FilePath);

            Assert.NotNull(list);
            Assert.True(list.Count > 0);
        }
    }
}