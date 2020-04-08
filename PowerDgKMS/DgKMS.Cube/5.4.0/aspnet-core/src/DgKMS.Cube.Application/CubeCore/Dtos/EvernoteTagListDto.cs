

using System;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using DgKMS.Cube.CubeCore;
using System.Collections.ObjectModel;


namespace DgKMS.Cube.CubeCore.Dtos
{	
	/// <summary>
	/// 的编辑DTO
	/// <see cref="EvernoteTag"/>
	/// </summary>
    public class EvernoteTagListDto : EntityDto<ulong>,IPassivable,IHasCreationTime,IHasModificationTime 
    {

        
		/// <summary>
		/// Id
		/// </summary>
		public ulong?? Id { get; set; }



		/// <summary>
		/// Guid
		/// </summary>
		public string Guid { get; set; }



		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// ParentGuid
		/// </summary>
		public string ParentGuid { get; set; }



		/// <summary>
		/// UpdateSequenceNum
		/// </summary>
		public int UpdateSequenceNum { get; set; }



		/// <summary>
		/// IsActive
		/// </summary>
		public bool IsActive { get; set; }



		/// <summary>
		/// CreationTime
		/// </summary>
		public DateTime CreationTime { get; set; }



		/// <summary>
		/// LastModificationTime
		/// </summary>
		public DateTime? LastModificationTime { get; set; }



		
							//// custom codes
									
							

							//// custom codes end
    }
}