using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TravelersBlog.Models;

namespace TravelersBlog.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    public string Email { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    public static void Post(RegisterViewModel user)
    {
      string jsonUser = JsonConvert.SerializeObject(user);
      ApiHelper.RegisterUser(jsonUser);
    }
  }
}