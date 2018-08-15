## DependencyInjection.XmlExtensions

### 1. 简介

DependencyInjection.XmlExtensions是对dotnet core内置的DI框架DependencyInjection的一个扩展。

源于Castle Windsor和Spring.net中使用配置文件对需要注册的服务进行配置。

使用此扩展也可以使用配置文件的形式注册服务

### 2. 示例

2.1 使用默认配置文件

```

public void ConfigureServices(IServiceCollection services)
{
    services.AddMvcCore()
            .AddServiceConfig();
}

```

此用户会从当前应用程序根目录下的`service.config`文件中读取服务配置,例如当前应用程序根目录为`F:\Sample`，那么配置文件路径为`F:\Sample\service.config`

2.2 使用自定义路径

```

public void ConfigureServices(IServiceCollection services)
{
    services.AddMvcCore()
            .AddServiceConfig(() => Path.Combine(Directory.GetCurrentDirectory(), "config", "service1.config"));
}

```

### 3. 服务配置文件示例

```

<?xml version="1.0" encoding="utf-8" ?>

<configuration>
  <components>
    <component type="XmlExtensions.Test.Bird, XmlExtensions.Test" service="XmlExtensions.Test.IAnimal, XmlExtensions.Test" lifetime="Scoped" />
  </components>
</configuration>

```

- `type`为实现类类型完全限定名
- `service`为接口类型完全限定名
- `lifetime`为服务生命周期，值包括`Singleton`、`Scoped`、`Transient`
