using Serilog;

class Program
{
    static void Main(string[] args)
    {
       // Configurar Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(outputTemplate: "{Message:lj}{NewLine}") // Sin hora en la consola, solo el mensaje
            .WriteTo.File("logs/errors.txt",
            rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}") // Con hora en el archivo de log
            .CreateLogger();

        try
        {
            Log.Information("La aplicación ha comenzado.");

            // Generar una excepción intencional
            throw new Exception("¡Error intencional!");
        }
        catch (Exception ex)
        {
            // Registrar el error detallado en el archivo
            Log.Error(ex, "Ocurrió un error inesperado.");

            // Mostrar un mensaje de error simplificado en la consola
            Console.WriteLine("Ha ocurrido un error. Por favor, contacte con soporte.");
        }
        finally
        {
            Log.Information("La aplicación ha terminado.");
            Log.CloseAndFlush();
        }
    }
}
