using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DgKMS.Cube.CubeCore
{
    public class EvernoteTag : Entity<int>, IPassivable, IHasCreationTime, IHasModificationTime
    {

        //[Column("id")]
        public  int Id { get; set; }
        //[Column("id")]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public new  ulong? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UpdateSequenceNum { get; set; }

        #region Auditing

        [Column("is_active")]
        public bool IsActive { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("create_time")]
        public DateTime CreationTime { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("modified_time")]
        public DateTime? LastModificationTime { get; set; }
        #endregion


    }
}
