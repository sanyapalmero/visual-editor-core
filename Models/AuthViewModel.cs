using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public class AuthViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
