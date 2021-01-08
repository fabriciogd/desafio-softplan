using Application.Helpers;
using Common.IntegrationTest;
using System.Threading.Tasks;
using Xunit;

namespace FirstApi.IntegrationTest
{
    public class FirstApiTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public FirstApiTest(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Call_Tax_ShouldReturn_CorretValue()
        {
            var client = _factory.GetDefaultClient();

            var response = await client.GetAsync("/taxajuros");

            response.EnsureSuccessStatusCode();

            var tax = await HttpResponseMessageHelpers.GetResponseContent<double>(response);
            var correctTax = 0.01;

            Assert.Equal(correctTax, tax);
        }
    }
}
