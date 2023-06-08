using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TravelersBlog.Models;

namespace TravelersBlog.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    public string Username { get; set; }


    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public static void Post(LoginViewModel user)
    {
      string jsonUser = JsonConvert.SerializeObject(user);
      ApiHelper.LoginUser(jsonUser);
    }
  }
}