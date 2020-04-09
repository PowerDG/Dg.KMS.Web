using DgKMS.Cube.Models;
using System;
using System.Collections.Generic;

namespace DgKMS.Cube
{
    public class PartyListDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        public decimal Cost { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 场所
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public int Source { get; set; }

        /// <summary>
        /// 人数
        /// </summary>
        public int Number { get; set; }

        public decimal LikeLevel { get; set; }

        public int LikeCount { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        public List<PartyCommentDto> PartyCommentDtos { get; set; }

        public List<PartyPhotoDto> PartyPhotoDtos { get; set; }
    }
}