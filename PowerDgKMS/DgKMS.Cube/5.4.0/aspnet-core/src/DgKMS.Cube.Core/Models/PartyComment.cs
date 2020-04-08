using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKMS.Cube.Models
{
    [Table("party_comment")]
    public class PartyComment : Entity<long>, IHasCreationTime
    {
        [Column("id")]
        public override long Id { get; set; }

        [Column("party_id")]
        public long PartyId { get; set; }

        [MaxLength(250)]
        [Column("content")]
        public string Content { get; set; }

        [Column("member_id")]
        public long MemberId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("create_time")]
        public DateTime CreationTime { get; set; }
    }
}