using System;
using System.ComponentModel.DataAnnotations;

namespace PartyService.Host.Models.Dtos
{
    public class PartyCreateDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public new long? Id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public long MemberId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Required(ErrorMessage = "开始时间不能为空")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Required(ErrorMessage = "结束时间不能为空")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(250)]
        [Required(ErrorMessage = "地址不能为空")]
        public string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [MaxLength(22)]
        [Required(ErrorMessage = "电话不能为空")]
        public string Tel { get; set; }

        /// <summary>
        /// 场所
        /// </summary>
        [MaxLength(250)]
        [Required(ErrorMessage = "场所不能为空")]
        public string Place { get; set; }

        /// <summary>
        /// 花费
        /// </summary>
        [Required(ErrorMessage = "花费不能为空")]
        [Range(typeof(decimal), "0", "1000000.00", ErrorMessage = "金额超出限定范围")]
        public decimal Cost { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [Required(ErrorMessage = "来源不能为空")]
        public int Source { get; set; }

        /// <summary>
        /// 人数
        /// </summary>
        [Required(ErrorMessage = "人数不能为空")]
        [Range(typeof(int), "1", "10000", ErrorMessage = "人数超出限定范围")]
        public int Number { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public decimal LikeLevel { get; set; }

        /// <summary>
        /// 评分数
        /// </summary>
        public int LikeCount { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Required(ErrorMessage = "经度不能为空")]
        public string Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Required(ErrorMessage = "纬度不能为空")]
        public string Latitude { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(60)]
        [Required(ErrorMessage = "标题不能为空")]
        public string Title { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
    }
}