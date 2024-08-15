// Cliente: Simulación de varios sistemas que generan alertas.
using Singleton.AntiPatron;
using Singleton.AntiPatron.AntiPatronArreglada;
using Singleton.PatronSeguro;

public class Program
{
    public static void Main(string[] args)
    {
        /// PATRON SEGURO
        // Diferentes sistemas generando alertas.
        Console.WriteLine("--------------Singelton Correcto--------------");
        var fireAlertSystem = EmergencyAlertCenter.GetInstance();
        fireAlertSystem.AddAlert("Incendio en el edificio A");

        var floodAlertSystem = EmergencyAlertCenter.GetInstance();
        floodAlertSystem.AddAlert("Inundación en la zona B");

        var accidentAlertSystem = EmergencyAlertCenter.GetInstance();
        accidentAlertSystem.AddAlert("Accidente de tráfico en la avenida C");

        // Procesar todas las alertas desde la instancia única.
        var centralAlertCenter = EmergencyAlertCenter.GetInstance();
        centralAlertCenter.ProcessAlerts();


        /// ANTI PATRON
        
        Console.WriteLine("--------------Singelton AntiPatron--------------");
        TaskManager taskManager = new TaskManager();
        taskManager.CreateTask("Escribir informe");
        taskManager.CompleteTask("Escribir informe");
        taskManager.GenerateReport();

        /// ANTI PATRON ARREGLADA
        
        Console.WriteLine("--------------Singelton Arreglando Anti Patron--------------");
        TaskService taskService = new TaskService();
        NotificationService notificationService = new NotificationService();
        ReportService reportService = new ReportService();

        taskService.AddTask("Escribir informe");
        notificationService.SendNotification("Nueva tarea creada: Escribir informe");
        
        taskService.CompleteTask("Escribir informe");
        notificationService.SendNotification("Tarea completada: Escribir informe");

        reportService.GenerateReport(taskService.GetTasks());
    }
}