using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public class Material
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Название материала")]
        public string MaterialName { get; set; }

        [Display(Name = "Размер")]
        public string MaterialSize { get; set; }

        [Display(Name = "Цена")]
        public int? MaterialPrice { get; set; }
    }
}
