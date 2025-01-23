using CarStore.BL.Interfaces;
using CarStore.BL.Services;
using CarStore.DL.Interfaces;
using CarStore.DL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            return services;
        }

        public static IServiceCollection RegisterDataLayer(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();
            return services;
        }
    }
}
