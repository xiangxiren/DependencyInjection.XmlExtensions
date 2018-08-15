using System.IO;
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
            var provider = new ServiceCollection()
                .AddServiceConfig()
                .BuildServiceProvider();

            var animal = provider.GetService<IAnimal>();

            Assert.NotNull(animal);
            animal.ShowName();
        }

        [Fact]
        public void AddServiceConfig_SetFilePath_Test()
        {
            var provider = new ServiceCollection()
                .AddServiceConfig(() =>
                    {
                        return Path.Combine(Directory.GetCurrentDirectory(), "config", "service1.config");
                    })
                .BuildServiceProvider();

            var animal = provider.GetService<IAnimal>();

            Assert.NotNull(animal);
            animal.ShowName();
        }
    }
}