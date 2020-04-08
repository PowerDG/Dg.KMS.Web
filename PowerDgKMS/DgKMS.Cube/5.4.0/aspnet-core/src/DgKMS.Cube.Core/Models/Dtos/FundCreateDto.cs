using System;
using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube
{
    public class FundCreateDto
    {
        public long Id { get; set; }

        /// <summary>
        /// 入账日期
        /// </summary>
        [Required(ErrorMessage = "入账日期不能为空")]
        public DateTime InsertTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(60, ErrorMessage = "标题超出最大长度")]
        [MinLength(1, ErrorMessage = "标题小于最小长度")]
        [Required(ErrorMessage = "标题不能为空")]
        public string ItemName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Required(ErrorMessage = "金额不能为空")]
        [Range(typeof(decimal), "-1000000.00", "1000000.00", ErrorMessage = "金额超出限定范围")]
        public decimal OperateMoney { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(250, ErrorMessage = "描述超出最大长度")]
        [MinLength(0, ErrorMessage = "描述小于最小长度")]
        [Required(ErrorMessage = "描述不能为空")]
        public string Description { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        //        [Required(ErrorMessage = "创建时间不能为空")]
        //        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        //        [Required(ErrorMessage = "修改时间不能为空")]
        //        public DateTime ModifiedTime { get; set; }
    }
}