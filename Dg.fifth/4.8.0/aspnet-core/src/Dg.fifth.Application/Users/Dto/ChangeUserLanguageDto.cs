using System.ComponentModel.DataAnnotations;

namespace Dg.fifth.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}