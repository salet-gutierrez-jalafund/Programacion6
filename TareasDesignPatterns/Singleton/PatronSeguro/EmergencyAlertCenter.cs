using System;

namespace Singleton.PatronSeguro;

public class EmergencyAlertCenter
{
    // La única instancia de la clase, inicializada perezosamente.
    private static EmergencyAlertCenter _instance;
    private List<string> _alerts;

    // Constructor privado para evitar instanciación directa.
    private EmergencyAlertCenter()
    {
        _alerts = new List<string>();
    }

    // Método público para obtener la instancia única.
    public static EmergencyAlertCenter GetInstance()
    {
        if (_instance == null)
        {
            _instance = new EmergencyAlertCenter();
        }
        return _instance;
    }

    // Método para añadir una alerta al sistema central.
    public void AddAlert(string alert)
    {
        _alerts.Add(alert);
        Console.WriteLine($"Alerta recibida: {alert}");
    }

    // Método para procesar todas las alertas.
    public void ProcessAlerts()
    {
        Console.WriteLine("Procesando todas las alertas:");
        foreach (var alert in _alerts)
        {
            Console.WriteLine($"- {alert}");
        }
        _alerts.Clear(); // Limpia las alertas después de procesarlas.
    }
}
