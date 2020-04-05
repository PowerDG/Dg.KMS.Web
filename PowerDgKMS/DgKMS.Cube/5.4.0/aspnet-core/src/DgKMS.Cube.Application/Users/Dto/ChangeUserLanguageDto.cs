using System.ComponentModel.DataAnnotations;

namespace DgKMS.Cube.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}