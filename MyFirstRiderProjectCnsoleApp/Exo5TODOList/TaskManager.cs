using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Sources;

namespace Exo5TODOList;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(int id,TaskType taskType,string title,string description,string body)
    {
        Task task = new Task(id,taskType,title, description, body);
        tasks.Add(task);
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void UpdateTask()
    {
        Task found;
        int count = 0;
        string input;
        Console.WriteLine("What task do u want to change : ");
        foreach (Task task in this.tasks)
        {
            count++;
            Console.WriteLine($"{count}. id: {task.getId()}, " +
                              $"category: {task.getTaskType()}, " +
                              $"title: {task.getTitle()}, " +
                              $"description: {task.getDescription()}"+
                              $"content: {task.getBody()}"+
                              $"checked: {task.showCompleted()}");
        }
        Console.WriteLine("Type number of task u want to change : ");
        input = Console.ReadLine();
        Int32.TryParse(input, out int index);
        found = tasks.ElementAt(index- 1);
        Console.WriteLine("What do you want to change");
        Console.WriteLine("1.Id\n2.Title\n3.Description\n4.Content\n5.Set task completed/uncompleted");
        input = Console.ReadLine();
        Int32.TryParse(input, out int choice);
        switch (choice)
        {
            case 1:
                Console.WriteLine("Type new id : ");
                input = Console.ReadLine();
                Int32.TryParse(input, out int n_id);
                found.SetId(n_id);
                break;
            case 2:
                Console.WriteLine("Type new tittle : ");
                input = Console.ReadLine();
                found.SeTitle(input);
                break;
            case 3:
                Console.WriteLine("Type new description : ");
                input = Console.ReadLine();
                found.SetDescription(input);
                break;
            case 4:
                Console.WriteLine("Type new body : ");
                input = Console.ReadLine();
                found.SetBody(input);
                break;
            case 5:
                Console.WriteLine("Set true/false : ");
                string check = Console.ReadLine();
                if (check.ToLower().Equals("true"))
                {
                    found.setCompleted(true);
                }

                else if (check.ToLower().Equals("false"))
                {
                    found.setCompleted(false);
                }
                else
                {
                    found.setCompleted(false);
                }
                break;
        }
    }

    public void checkTasks()
    {
        int count = 0;
        string input;
        Task found;
        foreach (Task task in this.tasks)
        {
            count++;
            Console.WriteLine($"{count}. id: {task.getId()}, " +
                              $"category: {task.getTaskType()}, " +
                              $"title: {task.getTitle()}, " +
                              $"description: {task.getDescription()}"+
                              $"content: {task.getBody()}"+
                              $"checked: {task.showCompleted()}");
        }
        Console.WriteLine("Type number of task u want to check/uncheck : ");
        input = Console.ReadLine();
        Int32.TryParse(input, out int index);
        found = tasks.ElementAt(index- 1);
        if(found.showCompleted() == true)
        found.setCompleted(false);
        else
        {
            found.setCompleted(true);
        }
    }

    public void sortByCategory()
    {
        int count = 0;   
        Console.WriteLine("Before sorting : ");
        foreach (Task task in this.tasks)
        {
            count++;
            Console.WriteLine($"{count}. id: {task.getId()}, " +
                              $"category: {task.getTaskType()}, " +
                              $"title: {task.getTitle()}, " +
                              $"description: {task.getDescription()}"+
                              $"content: {task.getBody()}"+
                              $"checked: {task.showCompleted()}");
        }
        
        this.tasks = this.tasks.OrderBy(t => t.getTaskType()).ToList();
        Console.WriteLine("After sorting : ");
        foreach (Task task in this.tasks)
        {
            count++;
            Console.WriteLine($"{count}. id: {task.getId()}, " +
                              $"category: {task.getTaskType()}, " +
                              $"title: {task.getTitle()}, " +
                              $"description: {task.getDescription()}"+
                              $"content: {task.getBody()}"+
                              $"checked: {task.showCompleted()}");
        }
    }

    public void saveToJson()
    {
        string json = JsonSerializer.Serialize(this.tasks);
        Console.WriteLine(json);
        JsonInFile(json);
    }

    public void JsonInFile(string json)
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Tasks.json")))
        {
            outputFile.WriteLine(json);
        }
    }

    public void ImportJson()
    {
        var tasks = new List<Task>();
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        using (StreamReader outputFile = new StreamReader(Path.Combine(docPath, "Tasks.json")))
        {
            var data = outputFile.ReadLine();
            tasks = JsonSerializer.Deserialize<List<Task>>(data);
        }

        this.tasks = tasks;
    }
}