using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public class ServiceDescriptorFactory
    {
        public IServiceCollection CreateServiceDescriptors(string filePath)
        {
            var components = new XmlInterpreter(filePath).ProcessFile();

            if (components == null || components.Count <= 0)
            {
                return null;
            }


            return null;
        }
    }
}