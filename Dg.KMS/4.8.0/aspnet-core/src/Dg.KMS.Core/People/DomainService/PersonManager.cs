

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using Dg.KMS;
using Dg.KMS.People;


namespace Dg.KMS.People.DomainService
{
    /// <summary>
    /// Person领域层的业务管理
    ///</summary>
    public class PersonManager :KMSDomainServiceBase, IPersonManager
    {
		
		private readonly IRepository<Person,long> _repository;

		/// <summary>
		/// Person的构造方法
		///</summary>
		public PersonManager(
			IRepository<Person, long> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitPerson()
		{
			//throw new NotImplementedException();
		}

		// TODO:编写领域业务代码

        public  long    Create()
        {
            var entity = new Person
            {
                Name = "c" + DateTime.Now.ToUnixTimestamp() + Guid.NewGuid()
            };
            return _repository.InsertOrUpdateAndGetId(entity);

        }


		 
		  
		 

	}
}
