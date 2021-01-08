using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;

namespace Common.IntegrationTest
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                              .ConfigureWebHostDefaults(x =>
                              {
                                  x.UseStartup<TStartup>().UseTestServer();
                              });
            return builder;
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder
                .ConfigureServices((ctx, services) =>
                {
                    // Create a new service provider.
                    var serviceCollection = new ServiceCollection();


                    var serviceProvider = serviceCollection.BuildServiceProvider();
                    var sp = services.BuildServiceProvider();
                })
                .UseEnvironment("Test");
        }

        public HttpClient GetDefaultClient()
        {
            HttpClient client = CreateClient();
            return client;
        }
    }
}
