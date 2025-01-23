using CarStore.BL.Interfaces;
using CarStore.BL.Services;
using CarStore.DL.Interfaces;
using CarStore.DL.Repositories;

namespace Ploject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddScoped<ICarRepository, CarRepository>();

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
