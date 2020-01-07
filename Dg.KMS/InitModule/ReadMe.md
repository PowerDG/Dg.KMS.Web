

Autofac.Configuration，
Autofac.Extensions.DependencyInjection 


ASP.NET Core中使用IOC三部曲
https://blog.csdn.net/weixin_34234823/article/details/86256439


 抽象工厂模式和autofac的使用总结
 https://www.cnblogs.com/JaggerMan/p/4732964.html
  抽象工厂模式和依赖注入的使用目的都是降低对象直接依赖耦合关系，应该说依赖注入是抽象工厂模式的一种升华，功能更强大。

  关于注入关键demo代码：

  ContainerBuilder builder = new ContainerBuilder();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("ClassLibrary")).ToArray();
            builder.RegisterAssemblyTypes(assemblies).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
