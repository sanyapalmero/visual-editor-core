using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string FileName { get; set; }

        public string FilePath { get; set; }

        [Display(Name = "Статус заказа")]
        public OrderStatus Status { get; set; }

        [ForeignKey("Material")]
        [Display(Name = "Материал")]
        public int? MaterialId { get; set; }

        [Display(Name = "Материал")]
        public Material Material { get; set; }

        [ForeignKey("AdvType")]
        [Display(Name = "Вид рекламы")]
        public int? AdvTypeId { get; set; }

        [Display(Name = "Вид рекламы")]
        public AdvType AdvType { get; set; }

        public int? FinalPrice { get; set; }
    }
}
