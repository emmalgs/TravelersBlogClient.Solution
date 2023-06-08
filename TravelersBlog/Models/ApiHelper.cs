using RestSharp;
using System.Net;

namespace TravelersBlog.Models
{
  public class ApiHelper
  {
    public static async Task<string> RegisterUser(string newUser)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v1/Users/register", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newUser);
      RestResponse response = client.Execute(request);
      if (response.StatusCode == HttpStatusCode.OK)
      {
        await client.PostAsync(request);
        return null;
      }
      else
      {
        return response.Content;
      }
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