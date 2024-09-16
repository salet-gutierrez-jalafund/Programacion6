using Microsoft.OpenApi.Models;
using System.Reflection;

public static class SwaggerConfig
{
    public static void AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "API de Ejemplo",
                Version = "v1",
                Description = "Una API de ejemplo con documentación Swagger",
                Contact = new OpenApiContact
                {
                    Name = "Salet",
                    Url = new Uri("https://www.rafaelacosta.net/Blog/2019/7/16/swagger-documentando-un-web-api-2-de-aspnet-framework")
                }
            });

            // Incluye comentarios XML si están habilitados
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
            c.IncludeXmlComments(xmlPath);
        });
    }

    public static void UseSwaggerDocumentation(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Ejemplo v1");
        });
    }
}
