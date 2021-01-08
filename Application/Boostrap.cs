using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Boostrap
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<ITaxService, TaxService>();
            services.AddSingleton<ICalculateTaxService, CalculateTaxService>();

            return services;
        }
    }
}
