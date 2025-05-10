using System.ComponentModel.DataAnnotations;

namespace MyChat.WebApp.Models.Register;

public class RegisterModel
{
    [Required]
    [Display(Name = "Username")]
    public required string UserName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public required string EmailAddress { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public required string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public required string ConfirmPassword { get; set; }
}