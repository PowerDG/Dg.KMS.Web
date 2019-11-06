

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Dg.KMS.People;


namespace Dg.KMS.People.DomainService
{
    public interface IPersonManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitPerson();



		 
      
         

    }
}
