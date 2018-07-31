using System.ComponentModel.DataAnnotations;

namespace DotnetAngularDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}