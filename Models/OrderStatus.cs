using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public enum OrderStatus
    {
        [Display(Name = "В ожидании")]
        Await,

        [Display(Name = "В процессе")]
        Process,

        [Display(Name = "Завершен")]
        Complete
    }
}
