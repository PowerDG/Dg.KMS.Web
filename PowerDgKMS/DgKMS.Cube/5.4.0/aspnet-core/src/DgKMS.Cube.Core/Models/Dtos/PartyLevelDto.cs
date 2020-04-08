using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube
{
    public class PartyLevelDto
    {
        [Required(ErrorMessage = "活动id不能为空")]
        public long Id { get; set; }

        [Range(1, 5, ErrorMessage = "评分不在范围内")]
        [Required(ErrorMessage = "评分不能为空")]
        public int Score { get; set; }
    }
}