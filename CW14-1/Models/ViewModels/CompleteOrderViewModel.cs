using System.ComponentModel.DataAnnotations;

namespace CW14_1.Models.ViewModels
{
    public class CompleteOrderViewModel
    {
        [Required(ErrorMessage = "عدد وارد کنید")]
        [MaxLength(16)]
        public string? CartNumber { get; set; }
        [Required(ErrorMessage = "عدد وارد کنید")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "کد امنیتی ضروریست")]
        [MaxLength(4)]
        [MinLength(4)]
        public string? CapchaCode { get; set; }
    }
}
