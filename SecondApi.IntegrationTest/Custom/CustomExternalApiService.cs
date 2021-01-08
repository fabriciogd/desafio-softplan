using CrossCutting.Interfaces;
using System.Threading.Tasks;

namespace SecondApi.IntegrationTest.Custom
{
    public class CustomExternalApiService : IExternalApiService
    {
        public Task<T> GetExternalResponseAsync<T>(string path)
        {
            return Task.FromResult(0.01) as Task<T>;
        }
    }
}
