using System.ComponentModel.DataAnnotations;

namespace ARatsLifeClient.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    [UserName]
    [Display(nameof = "Username")]
    public string UserName { get; set; }


    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}