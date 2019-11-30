using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DgContext
{
    public class BaseServiceClass
    {
    }
    public class ServiceClassA : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是ServceClassA";
        }
    }
    public class ServiceClassB : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是ServceClassB";
        }
    }
}
