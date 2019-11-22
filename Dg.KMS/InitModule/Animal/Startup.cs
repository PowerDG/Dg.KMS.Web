using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Mammal;
using Autofac;
using Autofac.Features.Indexed;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Animal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //RegisterContainer();
            RegisterContainer2();





        }

        public void RegisterContainer2()
        {
            var builder = new ContainerBuilder();//准备容器

            builder.RegisterType<Person>().UsingConstructor(typeof(string));

            var container = builder.Build();//创建容器完毕
            //var doge = container.Resolve<Person>();//通过IOC容器创建对象
            //doge.SayHello();
            
            List<NamedParameter> pars = new List<NamedParameter>()
            { new NamedParameter("Age", 20), new NamedParameter("Name", "张三") };
            builder.RegisterType<Person>().WithParameters(pars);　

        }


        public void RegisterContainer()
        {
            var builder = new ContainerBuilder();//准备容器
            builder.RegisterType<Doge>();//注册对象


            builder.RegisterInstance(new Doge());//实例注入

            //builder.RegisterInstance(Singleton.GetInstance()).ExternallyOwned();//将单例对象托管到IOC容器


            //builder.Register(c => new Person() { Name = "张三", Age = 20 });//Lambda表达式创建
            //Person p1 = container.Resolve<Person>();
            //builder.Register(c => new Person() { Name = "张三", Age = 20 });//Lambda表达式创建
            //Person p2 = container.Resolve<Person>();

            builder.RegisterGeneric(typeof(List<>));


            //var builder = new ContainerBuilder();//准备容器
            builder.RegisterType<Doge>().As<IAnimal>();//映射对象
            //如果一个类型被多次注册,以最后注册的为准。
            ////var container = builder.Build();//创建容器完毕

            builder.RegisterType<Doge>().Named<IAnimal>("doge");//映射对象
            builder.RegisterType<Pig>().Named<IAnimal>("pig");//映射对象
            builder.RegisterType<Cat>().As<IAnimal>().PreserveExistingDefaults();//指定Cat为非默认值

            builder.RegisterType<Doge>().Keyed<IAnimal>(AnumalType.Doge);//映射对象
            builder.RegisterType<Pig>().Keyed<IAnimal>(AnumalType.Pig);//映射对象

            builder.RegisterType<Cat>().Keyed<IAnimal>(AnumalType.Cat);//映射对象

            //通过使用PreserveExistingDefaults() 修饰符，可以指定某个注册为非默认值。

            //不过这种方式是不推荐使用的，因为autofac容器会被当作Service Locator使用，
            //    推荐的做法是通过索引类型来实现，
            //Autofac.Features.Indexed.IIndex<K, V> 是Autofac自动实现的一个关联类型。
            //    使用IIndex<K, V> 作为参数的构造函数从基于键的服务中选择需要的实现：

            var container = builder.Build();//创建容器完毕


            List<string> list = container.Resolve<List<string>>();


            var adog = container.Resolve<IAnimal>();//通过IOC容器创建对象
            adog.SayHello();
            var doge = container.Resolve<Doge>();//通过IOC容器创建对象
            doge.SayHello();
            var dog = container.ResolveNamed<IAnimal>("pig");//通过IOC容器创建对象
            dog.SayHello();
            var dogAble = container.ResolveKeyed<IAnimal>(AnumalType.Cat);//通过IOC容器创建对象
            dogAble.SayHello();

            var animal = container.Resolve<IIndex<AnumalType, IAnimal>>();
            var cat = animal[AnumalType.Cat];
            cat.SayHello();
        }

        public enum AnumalType
        {
            Doge, Pig, Cat
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
