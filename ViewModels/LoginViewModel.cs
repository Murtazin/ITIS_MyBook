using System.ComponentModel.DataAnnotations;

namespace MyBook.ViewModels;

public class LoginViewModel
{
    [Required]
    [Display(Name = "Email")]
    public string Email { get; set; }
         
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; }

    public string? ReturnUrl { get; set; }
}