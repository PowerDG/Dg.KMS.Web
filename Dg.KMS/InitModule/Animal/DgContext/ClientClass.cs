using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DgContext
{
    public class ClientClass
    {
        private IServiceClass _serviceImpl;

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
