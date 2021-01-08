using Application.Helpers;
using CrossCutting.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrossCutting.Services
{
    public class ExternalApiService : IExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetExternalResponseAsync<T>(string path)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(path);

            return await HttpResponseMessageHelpers.GetResponseContent<T>(response);
        }
    }
}
