using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMS.Eleven
{
    public class OperationTest
    {
        var services = new ServiceCollection();
        // 默认构造
        services.AddSingleton<IOperationSingleton, Operation>();
// 自定义传入Guid空值
services.AddSingleton<IOperationSingleton>(
  new Operation(Guid.Empty));
// 自定义传入一个New的Guid
services.AddSingleton<IOperationSingleton>(
  new Operation(Guid.NewGuid()));
 
var provider = services.BuildServiceProvider();

        // 输出singletone1的Guid
        var singletone1 = provider.GetService<IOperationSingleton>();
        Console.WriteLine($"signletone1: {singletone1.OperationId}");
 
// 输出singletone2的Guid
var singletone2 = provider.GetService<IOperationSingleton>();
        Console.WriteLine($"signletone2: {singletone2.OperationId}");
Console.WriteLine($"singletone1 == singletone2 ? : { singletone1 == singletone2 }");
    }


    public interface IServiceCollection : IList<ServiceDescriptor>
    {
        private static IServiceCollection Add(
  IServiceCollection collection,
  Type serviceType,
  Type implementationType,
  ServiceLifetime lifetime)
        {
            var descriptor =
            new ServiceDescriptor(serviceType, implementationType, lifetime);
            collection.Add(descriptor);
            return collection;
        }
    }
}
