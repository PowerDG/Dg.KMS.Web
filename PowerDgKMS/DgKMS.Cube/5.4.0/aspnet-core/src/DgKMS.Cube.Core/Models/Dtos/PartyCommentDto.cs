using System;
using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube.Models
{
    public class PartyCommentDto
    {
        public long? Id { get; set; }

        [Required(ErrorMessage = "活动id不能为空")]
        public long PartyId { get; set; }

        [MaxLength(10, ErrorMessage = "评论超出最大长度")]
        [Required(ErrorMessage = "评论不能为空")]
        public string Content { get; set; }

        public int MemberId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? CreationTime { get; set; }
    }
}