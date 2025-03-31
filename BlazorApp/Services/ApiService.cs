using System.Net.Http.Json;

namespace BlazorApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:5000";

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<T>> GetAsync<T>(string endpoint)
        {
            var response =  await _httpClient.GetFromJsonAsync<List<T>>($"{BaseUrl}/{endpoint}");
            if (response == null) 
            { 
                return new List<T>();
            }
            return response;
        }
    }
}
