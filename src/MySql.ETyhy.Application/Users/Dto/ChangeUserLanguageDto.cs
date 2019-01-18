using System.ComponentModel.DataAnnotations;

namespace MySql.ETyhy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}