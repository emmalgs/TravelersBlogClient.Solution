using System.Threading.Tasks;
using RestSharp;
using TravelersBlog.ViewModels;

namespace TravelersBlog.Models
{
  public class ApiHelper
  {
    public static async void RegisterUser(string newUser)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v1/Users/register", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newUser);
      await client.PostAsync(request);
    }
    public static async Task<string> GetAllCountries()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v1/countries", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}