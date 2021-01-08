using Application.Helpers;
using Common.IntegrationTest;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using SecondApi.IntegrationTest.Custom;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SecondApi.IntegrationTest
{
    public class SecondApiTest : IClassFixture<CustomWebApplicationFactory<CustomStartup>>
    {
        private readonly WebApplicationFactory<CustomStartup> _factory;

        public SecondApiTest(CustomWebApplicationFactory<CustomStartup> factory)
        {
            _factory = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddMvc().AddApplicationPart(typeof(Startup).Assembly);
                });
            });
        }

        [Fact]
        public async Task Call_Calculate_Tax_ShouldReturn_CorrectValue()
        {
            var client = _factory.CreateClient();

            var initialValue = 100;
            var months = 5;

            var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/calculajuros?valorinicial={initialValue}&meses={months}", content);

            response.EnsureSuccessStatusCode();

            var value = await HttpResponseMessageHelpers.GetResponseContent<double>(response);
            var correctValue = 105.1;

            Assert.Equal(correctValue, value);
        }

        [Fact]
        public async Task Call_Calculate_Tax_ShouldReturn_IncorrectValue()
        {
            var client = _factory.CreateClient();

            var initialValue = 150;
            var months = 5;

            var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/calculajuros?valorinicial={initialValue}&meses={months}", content);

            response.EnsureSuccessStatusCode();

            var value = await HttpResponseMessageHelpers.GetResponseContent<double>(response);
            var correctValue = 105.1;

            Assert.NotEqual(correctValue, value);
        }
    }
}
