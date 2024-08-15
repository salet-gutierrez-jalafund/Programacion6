namespace Singleton.AntiPatron;

using System.Collections.Generic;

// Antipatrón: God Object
public class TaskManager
{
    private List<string> _tasks = new List<string>();
    private List<string> _completedTasks = new List<string>();
    private List<string> _notifications = new List<string>();

    // Método para crear una nueva tarea.
    public void CreateTask(string task)
    {
        _tasks.Add(task);
        Console.WriteLine($"Tarea '{task}' creada.");
        SendNotification("Nueva tarea creada: " + task);
    }

    // Método para completar una tarea.
    public void CompleteTask(string task)
    {
        if (_tasks.Contains(task))
        {
            _tasks.Remove(task);
            _completedTasks.Add(task);
            Console.WriteLine($"Tarea '{task}' completada.");
            SendNotification("Tarea completada: " + task);
        }
    }

    // Método para enviar notificaciones.
    public void SendNotification(string message)
    {
        _notifications.Add(message);
        Console.WriteLine($"Notificación enviada: {message}");
    }

    // Método para generar un reporte de tareas.
    public void GenerateReport()
    {
        Console.WriteLine("Reporte de Tareas:");
        Console.WriteLine("Tareas pendientes:");
        foreach (var task in _tasks)
        {
            Console.WriteLine("- " + task);
        }

        Console.WriteLine("Tareas completadas:");
        foreach (var task in _completedTasks)
        {
            Console.WriteLine("- " + task);
        }
    }
}