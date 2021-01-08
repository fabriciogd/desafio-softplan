using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public static class HttpResponseMessageHelpers
    {
        public static async Task<T> GetResponseContent<T>(HttpResponseMessage response)
        {
            var stringResponse = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<T>(stringResponse);

            return result;
        }
    }
}
