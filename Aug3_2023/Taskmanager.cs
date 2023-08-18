using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


public enum TaskCategory
{
    Personal,
    Work,
    Errands,
    other

}



public class TodoTask
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public TaskCategory Category { get; set; }
    public bool IsCompleted { get; set; }
}




public class Taskmanager
{
    private List<TodoTask> tasks = new List<TodoTask>();
    private readonly string dataFilePath = "tasks.csv";

    public Taskmanager()
    {
        LoadTasksFromFileAsync(dataFilePath).Wait();

    }

    public async Task AddTaskAsync(string name, string description, TaskCategory category)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Invalid input. Name and description cannot be empty.");
            return;
        }

        TodoTask newTask = new TodoTask
        {
            Name = name,
            Description = description,
            Category = category,
            IsCompleted = false
        };

        tasks.Add(newTask);
        await SaveTasksToFileAsync(dataFilePath);
    }


    public void ViewAllTasks()
    {
        Console.WriteLine("All Tasks:");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("|   Name   |   Description   |   Category   |   IsCompleted   |");
        Console.WriteLine("---------------------------------------------------");

        foreach (var task in tasks)
        {
            Console.WriteLine($" {task.Name,-8}  {task.Description,-15}  {task.Category,-11}  {task.IsCompleted,-14} ");
        }

        Console.WriteLine();

    }

    public List<TodoTask> GetTasksByCategory(TaskCategory category)
    {
        return tasks.Where(t => t.Category == category).ToList();
    }


    public async Task SaveTasksToFileAsync(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var task in tasks)
                {
                    await writer.WriteLineAsync($"{task.Name},{task.Description},{task.Category},{task.IsCompleted}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving tasks to file: {ex.Message}");
        }
    }

    public async Task LoadTasksFromFileAsync(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                tasks.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            TodoTask task = new TodoTask
                            {
                                Name = parts[0],
                                Description = parts[1],
                                Category = (TaskCategory)Enum.Parse(typeof(TaskCategory), parts[2]),
                                IsCompleted = bool.Parse(parts[3])
                            };
                            tasks.Add(task);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading tasks from file: {ex.Message}");
        }
    }
}
