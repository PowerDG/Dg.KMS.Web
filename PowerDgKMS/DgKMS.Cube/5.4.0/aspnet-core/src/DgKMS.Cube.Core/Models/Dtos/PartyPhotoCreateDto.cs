using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKMS.Cube.Models
{
    public class PartyPhotoCreateDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "活动id不能为空")]
        public long PartyId { get; set; }

        [Required(ErrorMessage = "图片不能为空")]
        public string UploadImg { get; set; }

        [MaxLength(60, ErrorMessage = "描述内容太长")]
        [Required(ErrorMessage = "描述不能为空")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Column("modified_time")]
        public DateTime? LastModificationTime { get; set; }
    }
}