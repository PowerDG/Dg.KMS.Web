using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DgContext
{
    public class ConstructorInjection
    {
    }
    public  class ClientClass
    {
        public IServiceClass _serviceImpl { get; set; }

        public ClientClass()
        {
        }
        public ClientClass(IServiceClass serviceImpl)
        {
            this._serviceImpl = serviceImpl;
        }
        public void Set_ServiceImpl(IServiceClass serviceImpl)
        {
            this._serviceImpl = serviceImpl;
        }

        public void ShowInfo()
        {
            Console.WriteLine(_serviceImpl.ServiceInfo());
        }
    }
}
