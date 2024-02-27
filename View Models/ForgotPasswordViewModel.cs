using System.ComponentModel.DataAnnotations;

namespace OtpTaskFinal.View_Models;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}