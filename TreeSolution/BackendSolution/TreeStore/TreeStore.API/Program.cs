using TreeStore.API.Repositories;
using TreeStore.API.Repositories.Interfaces;
using TreeStore.API.Services;
using TreeStore.API.Services.Interfaces;

namespace TreeStore.API;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddScoped<ITreeRepository, TreeRepository>();
        builder.Services.AddScoped<ITreeService, TreeService>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("corspolicy",
                              builder =>
                              {
                                  builder
                                  .WithOrigins("http://localhost:4200")
                                  .WithMethods("GET") 
                                  .AllowAnyHeader();
                              });
        });

        builder.Services.AddControllers();
        

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        //app.UseHttpsRedirection();

        app.UseCors("corspolicy");

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
