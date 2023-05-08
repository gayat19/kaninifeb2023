using ConsumeService.Interfaces;
using ConsumeService.Models;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Net.Http.Headers;

namespace ConsumeService.Services
{
    public class ManageProduct : IManageProduct
    {
        HttpClient _httpClient;
        string token;
        public ManageProduct()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
        public async Task<ICollection<Product>> GetAll()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("http://localhost:5045/api/Product");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<ICollection<Product>>();
                return data;
            }
            return null;
        }

        public void SetToken(string token)
        {
            this.token = token;
        }
    }
}
