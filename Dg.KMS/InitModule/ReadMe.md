

Autofac.Configuration��
Autofac.Extensions.DependencyInjection 


ASP.NET Core��ʹ��IOC������
https://blog.csdn.net/weixin_34234823/article/details/86256439


 ���󹤳�ģʽ��autofac��ʹ���ܽ�
 https://www.cnblogs.com/JaggerMan/p/4732964.html
  ���󹤳�ģʽ������ע���ʹ��Ŀ�Ķ��ǽ��Ͷ���ֱ��������Ϲ�ϵ��Ӧ��˵����ע���ǳ��󹤳�ģʽ��һ�����������ܸ�ǿ��

  ����ע��ؼ�demo���룺

  ContainerBuilder builder = new ContainerBuilder();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("ClassLibrary")).ToArray();
            builder.RegisterAssemblyTypes(assemblies).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
