using CrossCutting.Interfaces;
using CrossCutting.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrossCutting
{
    public static class Boostrap
    {
        public static IServiceCollection AddCrossCutting(this IServiceCollection services)
        {
            services.AddHttpClient<IExternalApiService, ExternalApiService>(c =>
            {
                c.BaseAddress = new Uri("http://firstapi:80/");
            });

            return services;
        }
    }
}
