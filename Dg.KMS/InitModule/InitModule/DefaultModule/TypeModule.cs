using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace InitModule.DefaultModule
{
    public class TypeModule : Autofac.Module
    {
        public object MySingleton { get; private set; }

        protected override void Load(ContainerBuilder builder)
        {
            #region NamingAssembly

            //注册当前程序集中以“Ser”结尾的类,暴漏类实现的所有接口，生命周期为PerLifetimeScope
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Ser"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
            //注册所有"MyApp.Repository"程序集中的类
            //builder.RegisterAssemblyTypes(GetAssembly("MyApp.Repository")).AsImplementedInterfaces();

            #endregion

            #region 类型创建RegisterType
            builder.RegisterType<AutoFacManager>();
            builder.RegisterType<Worker>().As<IPerson>();
            //AutoFac能够通过反射检查一个类型,选择一个合适的构造函数,创造这个对象的实例。
            //主要通过RegisterType<T>() 和 RegisterType(Type) 两个方法以这种方式建立。

            //ContainerBuilder使用 As() 方法将Component封装成了服务使用。
            #endregion

            #region 2、实例创建
            builder.RegisterInstance<AutoFacManager>(new AutoFacManager(new Worker()));

            //单例

            //提供示例的方式，还有一个功能，就是不影响系统中原有的单例：
            //builder.RegisterInstance(MySingleton.GetInstance()).ExternallyOwned();  
            ////将自己系统中原有的单例注册为容器托管的单例

            //这种方法会确保系统中的单例实例最终转化为由容器托管的单例实例。
            #endregion
            #region 3、Lambda表达式创建
            //Lambda的方式也是Autofac通过反射的方式实现

   
                builder.Register(c => new AutoFacManager(c.Resolve<IPerson>()));
            builder.RegisterType<Worker>().As<IPerson>();


            #endregion


            #region  4、程序集创建

            //程序集的创建主要通过RegisterAssemblyTypes()方法实现，
            //Autofac会自动在程序集中查找匹配的类型用于创建实例。

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()); //在当前正在运行的程序集中找
            builder.RegisterType<Worker>().As<IPerson>();




            #endregion



            #region  4、程序集创建

            //程序集的创建主要通过RegisterAssemblyTypes()方法实现，
            //Autofac会自动在程序集中查找匹配的类型用于创建实例。

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()); //在当前正在运行的程序集中找
            builder.RegisterType<Worker>().As<IPerson>();




            #endregion




            #region 　5、泛型注册

            //泛型注册通过RegisterGeneric() 这个方法实现，在容易中可以创建出泛型的具体对象。

    //泛型注册,可以通过容器返回List<T> 如:List<string>,List<int>等等
    builder.RegisterGeneric(typeof(List<>)).As(typeof(IList<>)).InstancePerLifetimeScope();
            using (IContainer container = builder.Build())
            {
                IList<string> ListString = container.Resolve<IList<string>>();
            }




            #endregion


        }


        public static Assembly GetAssembly(string assemblyName)
        {
            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(AppContext.BaseDirectory + $"{assemblyName}.dll");
            return assembly;
        }

        //————————————————
        //版权声明：本文为CSDN博主「qq_39628933」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
        //原文链接：https://blog.csdn.net/qq_39628933/article/details/84964960
    }
}
