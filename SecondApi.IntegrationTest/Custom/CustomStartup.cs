using CrossCutting.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SecondApi.IntegrationTest.Custom
{
    public class CustomStartup : Startup
    {
        public CustomStartup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void AddExternalApiService(IServiceCollection services)
        {
            services.AddScoped<IExternalApiService, CustomExternalApiService>();
        }
    }
}
