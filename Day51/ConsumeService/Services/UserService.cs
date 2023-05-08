using ConsumeService.Interfaces;
using ConsumeService.Models;
using System.Net.Http.Headers;


namespace ConsumeService.Services
{
    public class UserService : IUser
    {
       HttpClient _httpClient;

        public UserService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<User> Login(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5087/api/User/Login", user);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<User>();
                return data;
            }
            return null;
        }
    }
}
