namespace DependencyInjection.XmlExtensions
{
    public class ServiceDescriptorFactory
    {
        public string CreateServiceDescriptors(string filePath)
        {
            var components = new XmlInterpreter(filePath).ProcessFile();

            if (components == null || components.Count <= 0)
            {
                return null;
            }


            return string.Empty;
        }
    }
}