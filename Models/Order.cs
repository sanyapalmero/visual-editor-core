using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string UserSurname { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string UserPhone { get; set; }

        [Required]
        [Display(Name = "Организация")]
        public string UserOrganization { get; set; }

        public string ImgFolder { get; set; }
    }
}
