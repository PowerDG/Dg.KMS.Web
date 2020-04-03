using System.ComponentModel.DataAnnotations;

namespace dgPower.KMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}