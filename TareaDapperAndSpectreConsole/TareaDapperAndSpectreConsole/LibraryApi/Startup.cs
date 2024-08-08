using LibraryApi.api.Repositories.Concrets;
using LibraryApi.api.Repositories.Interfaces;
using Microsoft.OpenApi.Models;

namespace LibraryApi;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        services.AddTransient<IBookRepository, BookRepository>();
        services.AddSwaggerGen();

        // Configuración de CORS si es necesario
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        });
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryApi v1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        // Use CORS policy
        app.UseCors("AllowAllOrigins");

        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
