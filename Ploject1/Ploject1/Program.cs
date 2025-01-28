using CarStore.BL.Interfaces;
using CarStore.BL.Services;
using CarStore.DL.Interfaces;
using CarStore.DL.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using FluentValidation;
using CarStore.Models;
using CarStore.Models.Validators;
using Serilog;

namespace Ploject1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddFluentValidation(fv =>fv.RegisterValidatorsFromAssemblyContaining<OwnerValidator>());
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddScoped<ICarRepository, CarRepository>();
            builder.Services.AddControllers();


            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
            builder.Services.AddScoped<IOwnerService, OwnerService>();
            builder.Services.AddHealthChecks();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            builder.Host.UseSerilog();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.MapHealthChecks("/health");
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
     

            app.Run();
        }
    }
}
