using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyService.Host.Models
{
    [Table("fund")]
    public class FundModel : Entity<long>, IHasCreationTime, IHasModificationTime
    {
        [Column("id")]
        public override long Id { get; set; }

        [MaxLength(250)]
        [Column("description")]
        public string Description { get; set; }

        [MaxLength(60)]
        [Column("item_name")]
        public string ItemName { get; set; }

        [Column("member_id")]
        public long MemberId { get; set; }

        [Column("operate_money")]
        public decimal OperateMoney { get; set; }

        [Column("remain_money")]
        public decimal RemainMoney { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("insert_time")]
        public DateTime InsertTime { get; set; }

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