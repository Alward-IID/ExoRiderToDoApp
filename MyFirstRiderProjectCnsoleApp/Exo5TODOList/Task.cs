using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Exo5TODOList;

public class Task
{
    public Task(int id, TaskType taskType, string title, string description,string body){
        this.id = id;
        this.taskType = taskType;
        this.title = title;
        this.description = description;
        this.body = body;
        isCompleted = false;
    }
    
    [JsonInclude]
    private int id;
    [JsonInclude]
    private TaskType taskType;
    [JsonInclude]
    private string title;
    [JsonInclude]
    private string description;
    [JsonInclude]
    private string body;
    [JsonInclude]
    private bool isCompleted;
    
    public void SetId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return id;
    }
    
    public void SetTaskType(TaskType taskType)
    {
        this.taskType = taskType;
    }

    public TaskType getTaskType()
    {
        return this.taskType;
    }
    
    public void SeTitle(string tittle)
    {
        this.title = tittle;
    }

    public string getTitle()
    {
        return title;
    }
    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string getDescription()
    {
        return description;
    }
    public void SetBody(string body)
    {
        this.body = body;
    }

    public string getBody()
    {
        return body;
    }
    public void setCompleted(bool isCompleted)
    {
        this.isCompleted = isCompleted;
    }

    public bool showCompleted()
    {
        return isCompleted;
    }
}