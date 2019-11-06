using System.ComponentModel.DataAnnotations;

namespace Dg.KMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}