using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKMS.Cube.Models
{
    [Table("party_photo")]
    public class PartyPhoto : Entity<long>, IHasCreationTime, IHasModificationTime
    {
        [Column("id")]
        public override long Id { get; set; }

        [Column("party_id")]
        public long PartyId { get; set; }

        [MaxLength(250)]
        [Column("url")]
        public string Url { get; set; }

        [MaxLength(250)]
        [Column("url_part")]
        public string UrlPart { get; set; }

        [MaxLength(60)]
        [Column("description")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("create_time")]
        public DateTime CreationTime { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("modified_time")]
        public DateTime? LastModificationTime { get; set; }
    }
}