using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKMS.Cube.Models
{
    [Table("party")]
    public class Party : Entity<long>, IHasCreationTime, IHasModificationTime
    {
        [Column("id")]
        public override long Id { get; set; }

        [MaxLength(60)]
        [Column("title")]
        public string Title { get; set; }

        [Column("member_id")]
        public long MemberId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("end_time")]
        public DateTime EndTime { get; set; }

        [MaxLength(250)]
        [Column("address")]
        public string Address { get; set; }

        [MaxLength(22)]
        [Column("tel")]
        public string Tel { get; set; }

        [MaxLength(250)]
        [Column("place")]
        public string Place { get; set; }

        [Column("cost")]
        public decimal Cost { get; set; }

        [Column("source")]
        public int Source { get; set; }

        [Column("number")]
        public int Number { get; set; }

        [Column("like_level")]
        public decimal LikeLevel { get; set; }

        [Column("like_count")]
        public int LikeCount { get; set; }

        [MaxLength(250)]
        [Column("longitude")]
        public string Longitude { get; set; }

        [MaxLength(250)]
        [Column("latitude")]
        public string Latitude { get; set; }

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