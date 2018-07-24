using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace CoreEditor.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [NotMapped]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { set { PasswordHash = HashPassword(value); } }

        [Required]
        [Display(Name = "Пароль")]
        public string PasswordHash { get; set; }

        public static string HashPassword(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var sha = SHA256Managed.Create();
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
