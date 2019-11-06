
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Dg.KMS.People;

namespace  Dg.KMS.People.Dtos
{
    public class PersonEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
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