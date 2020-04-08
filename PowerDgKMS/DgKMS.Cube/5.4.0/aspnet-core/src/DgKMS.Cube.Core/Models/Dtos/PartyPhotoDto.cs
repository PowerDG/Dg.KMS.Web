using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKMS.Cube.Models
{
    public class PartyPhotoDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "活动id不能为空")]
        public long PartyId { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "图片路径不能为空")]
        public string Url { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "图片缩略图路径不能为空")]
        public string UrlPart { get; set; }

        [MaxLength(60)]
        [Required(ErrorMessage = "描述不能为空")]
        public string Description { get; set; }

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