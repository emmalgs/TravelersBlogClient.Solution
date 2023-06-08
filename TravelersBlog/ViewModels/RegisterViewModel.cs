using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TravelersBlog.Models;

namespace TravelersBlog.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    public string Username { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public static string Post(RegisterViewModel user)
    {
      string jsonUser = JsonConvert.SerializeObject(user);
      #nullable enable
      var registerAttempt = ApiHelper.RegisterUser(jsonUser);
      #nullable disable
      if (registerAttempt != null)
      {
        return JsonConvert.DeserializeObject<string>(registerAttempt.ToString());
      }
      else
      {
        return null;
      }
    }
  }
}