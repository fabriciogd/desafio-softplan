using System.Threading.Tasks;

namespace CrossCutting.Interfaces
{
    public interface IExternalApiService
    {
        public Task<T> GetExternalResponseAsync<T>(string path);
    }
}
