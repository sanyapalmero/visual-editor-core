using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public class AdvType
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Вид рекламы")]
        public string TypeName { get; set; }

        [Display(Name = "Размер")]
        public string TypeSize { get; set; }

        [Display(Name = "Цена")]
        public int? TypePrice { get; set; }
    }
}
