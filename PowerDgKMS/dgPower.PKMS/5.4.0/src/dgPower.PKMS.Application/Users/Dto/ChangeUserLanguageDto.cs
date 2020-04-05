using System.ComponentModel.DataAnnotations;

namespace dgPower.PKMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}