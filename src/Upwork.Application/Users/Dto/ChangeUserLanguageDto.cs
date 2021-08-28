using System.ComponentModel.DataAnnotations;

namespace Upwork.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}