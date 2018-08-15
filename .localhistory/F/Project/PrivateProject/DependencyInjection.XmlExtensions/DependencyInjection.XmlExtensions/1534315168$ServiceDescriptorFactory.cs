namespace DependencyInjection.XmlExtensions
{
    public class ServiceDescriptorFactory
    {
        public string CreateServiceDescriptors(string filePath)
        {
            var components = new XmlInterpreter(filePath);


            return string.Empty;
        }
    }
}