using System;

namespace Singleton.AntiPatron.AntiPatronArreglada;

public class Task
{
    public string Description { get; private set; }
    public bool IsCompleted { get; private set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}
