using System;

namespace Singleton.AntiPatron.AntiPatronArreglada;

public class TaskService
{
    private List<Task> _tasks = new List<Task>();

    public void AddTask(string description)
    {
        _tasks.Add(new Task(description));
        Console.WriteLine($"Tarea '{description}' creada.");
    }

    public void CompleteTask(string description)
    {
        var task = _tasks.Find(t => t.Description == description);
        if (task != null)
        {
            task.Complete();
            Console.WriteLine($"Tarea '{description}' completada.");
        }
    }

    public IEnumerable<Task> GetTasks() => _tasks;
}
