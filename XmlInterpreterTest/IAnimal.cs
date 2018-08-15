using System;

namespace XmlExtensions.Test
{
    public interface IAnimal
    {
        void ShowName();
    }

    public class Bird : IAnimal
    {
        public void ShowName()
        {
            Console.WriteLine(nameof(Bird));
        }
    }
}