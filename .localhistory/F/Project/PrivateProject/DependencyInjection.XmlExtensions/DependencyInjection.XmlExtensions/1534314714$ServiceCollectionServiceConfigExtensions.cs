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

            return services.AddServiceConfig(() => Path.Combine(Directory.GetCurrentDirectory(), DefaultFileName));
        }

        /// <summary>
        /// 从指定配置文件中读取服务注册配置并添加到服务集合中
        /// </summary>
        /// <param name="services">添加服务的集合</param>
        /// <param name="filePathFactory">用于构建配置文件路径的工厂</param>
        /// <returns>添加完成后的服务集合</returns>
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, Func<string> filePathFactory)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }


            return services;
        }
    }
}