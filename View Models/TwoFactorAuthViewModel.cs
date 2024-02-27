using System.ComponentModel.DataAnnotations;

namespace OtpTaskFinal.View_Models;

public class TwoFactorAuthViewModel
{
    [Required]
    public string Token { get; set; }
    [Required]
    public string Code { get; set; }

    public string QRCodeUrl { get; set; }
}