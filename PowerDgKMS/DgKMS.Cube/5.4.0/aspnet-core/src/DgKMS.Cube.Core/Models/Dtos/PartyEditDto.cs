using Abp.AutoMapper;
using DgKMS.Cube.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube
{
    [AutoMap(typeof(Party))]
    public class PartyEditDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [Required(ErrorMessage = "操作人不能为空")]
        public int MemberId { get; set; }

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
        /// 来源
        /// </summary>
        [Required(ErrorMessage = "来源不能为空")]
        public int Source { get; set; }

        /// <summary>
        /// 人数
        /// </summary>
        [Required(ErrorMessage = "人数不能为空")]
        public int Number { get; set; }

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
        [MaxLength(250)]
        [Required(ErrorMessage = "标题不能为空")]
        public string Title { get; set; }
    }
}