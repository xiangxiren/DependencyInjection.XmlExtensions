using DependencyInjection.XmlExtensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace XmlExtensions.Test
{
    public class DependencyInjectionTest : TestBase
    {
        [Fact]
        public void AddServiceConfig_Default_Test()
        {
            var service = new ServiceCollection()
                .AddServiceConfig()
                .BuildServiceProvider();
        }
    }
}