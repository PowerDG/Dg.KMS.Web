

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using Dg.KMS.People;

namespace Dg.KMS.People.Dtos
{
    public class PersonListDto : EntityDto<long> 
    {

        
		/// <summary>
		/// 姓名
		/// </summary>
		[Required(ErrorMessage="姓名不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreationTime { get; set; }




    }
}