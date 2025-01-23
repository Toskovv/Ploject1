using CarStore.BL.Interfaces;
using CarStore.BL.Services;
using CarStore.DL.Interfaces;
using CarStore.DL.Repositories;
using Microsoft.AspNetCore.Builder;

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

            // Add Swagger services
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                app.UseSwagger();
                app.UseSwaggerUI();

            }
            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
