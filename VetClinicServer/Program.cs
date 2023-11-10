
using Microsoft.AspNetCore.Diagnostics;
using VetClinicServer.Filters;
using VetClinicServer.Models;
using VetClinicServer.Services;

namespace VetClinicServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<VetClinicContext>();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddControllers(c =>
            {
                c.Filters.Add<CustomExceptionFilter>();
            });

            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IPatientService, PatientService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }
            app.UseExceptionHandler(a => a.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature.Error;

                await context.Response.WriteAsJsonAsync(new { error = exception.Message });
            }));

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}