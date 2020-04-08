using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube
{
    public class FundEditDto
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "Id不能为空")]
        public long Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(20, ErrorMessage = "标题超出最大长度")]
        [MinLength(1, ErrorMessage = "标题小于最小长度")]
        [Required(ErrorMessage = "标题不能为空")]
        public string ItemName { get; set; }

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
        public long MemberId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        //        [Required(ErrorMessage = "修改时间不能为空")]
        //        public DateTime ModifiedTime { get; set; }
    }
}