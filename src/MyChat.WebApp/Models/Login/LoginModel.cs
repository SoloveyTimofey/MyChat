using System.ComponentModel.DataAnnotations;

namespace MyChat.WebApp.Models.Login;

public class LoginModel
{
    [Required]
    [Display(Name = "UserName")]
    public required string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public required string Password { get; set; }
}