
using ApplicationLayer.Interfaces;
using ApplicationLayer.UseCases;
using DomainLayer.Repositories;
using InfrastructureLayer.Models;
using InfrastructureLayer.Repositories;

namespace PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

            builder.Services.AddScoped<IMatchRepository, MatchInformationsRepository>();
            builder.Services.AddScoped<IMatchInformationsService, MatchInformationsService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
