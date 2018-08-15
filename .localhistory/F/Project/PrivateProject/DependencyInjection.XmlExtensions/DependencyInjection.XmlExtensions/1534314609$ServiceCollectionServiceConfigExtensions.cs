using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public static class ServiceCollectionServiceConfigExtensions
    {
        private static readonly string DefaultFileName = "service.config";

        /// <summary>
        /// 从应用程序运行目录下的service.config文件中读取服务注册配置并添加到服务集合中
        /// </summary>
        /// <param name="services">添加服务的集合</param>
        /// <returns>添加完成后的服务集合</returns>
        public static IServiceCollection AddServiceConfig(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), DefaultFileName);

            return services.AddServiceConfig(filePath);
        }

        /// <summary>
        /// 从应用程序运行目录下的指定配置文件名的文件中读取服务注册配置并添加到服务集合中
        /// </summary>
        /// <param name="services">添加服务的集合</param>
        /// <param name="filePath">配置文件名称</param>
        /// <returns>添加完成后的服务集合</returns>
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, Func<string> filePath)
        {


            return services;
        }

        /// <summary>
        /// 从应用程序运行目录下的指定配置文件名的文件中读取服务注册配置并添加到服务集合中
        /// </summary>
        /// <param name="services">添加服务的集合</param>
        /// <param name="fileName">配置文件名称</param>
        /// <returns>添加完成后的服务集合</returns>
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);


            return services;
        }

    }
}