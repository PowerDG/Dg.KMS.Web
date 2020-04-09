
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using System.Collections.ObjectModel;
using DgKMS.Cube.CubeCore;


namespace  DgKMS.Cube.CubeCore.Dtos
{
	/// <summary>
	/// 的列表DTO
	/// <see cref="EvernoteTag"/>
	/// </summary>
    public class EvernoteTagEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong? Id { get; set; }         


          
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



		
							//// custom codes
									
							

							//// custom codes end
    }
}