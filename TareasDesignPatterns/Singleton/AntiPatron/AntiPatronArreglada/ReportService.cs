using System;

namespace Singleton.AntiPatron.AntiPatronArreglada;

public class ReportService
{
    public void GenerateReport(IEnumerable<Task> tasks)
    {
        Console.WriteLine("Reporte de Tareas:");
        foreach (var task in tasks)
        {
            string status = task.IsCompleted ? "Completada" : "Pendiente";
            Console.WriteLine($"- {task.Description} ({status})");
        }
    }
}
