// See https://aka.ms/new-console-template for more information

using Exo5TODOList;
using Task = Exo5TODOList.Task;

string input;
string choice;
TaskManager allTasks = new TaskManager();


/*
allTasks.AddTask(1, TaskType.family ,"1er Tache","Effectuer travail du jour","Voici les choses a faire...");
allTasks.AddTask(10,TaskType.financial,"2er Tache","Effectuer travail du jour","Voici les choses a faire....");
allTasks.AddTask(15,TaskType.householdChores,"3er Tache","Effectuer travail du jour","Voici les choses a faire...?");
allTasks.AddTask(19,TaskType.health,"4er Tache","Effectuer travail du jour","Voici les choses a faire...!");
*/

do
{
    Console.WriteLine("1.Add a task\n2.Update a task\n3.Check a task\n4.Sort task by Categories\n5.Save Json task\n6.Import Json task");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1": inputTask();
            break;
        case "2": allTasks.UpdateTask();
            break;
        case "3": allTasks.checkTasks();
            break;
        case "4": allTasks.sortByCategory();
            break;
        case "5": allTasks.saveToJson();
            break;
        case "6": allTasks.ImportJson();
            break;
        default: break;
    }
    
    Console.WriteLine("Do you want to quit : y/n");
    input = Console.ReadLine();
} while (!input.Equals('y'));
void inputTask()
{
    int count = 0;
    Console.WriteLine("Put the id of the task : ");
    int taskId = int.Parse(Console.ReadLine());
    Console.WriteLine("Put the number of the category : ");
    foreach (var category in Enum.GetValues(typeof(TaskType)))
    {
        count++;
        Console.WriteLine($"{count}. + {category.ToString()}");
    }
    int taskCategoryIndex = int.Parse(Console.ReadLine());
    TaskType taskCategory = (TaskType)taskCategoryIndex - 1;
    Console.WriteLine("Put the title of the task : ");
    string taskTitle = Console.ReadLine();
    Console.WriteLine("Put the description of the task : ");
    string taskDescription = Console.ReadLine();
    Console.WriteLine("Put the content of the task : ");
    string taskContent = Console.ReadLine();
    Task createTask = new Task(taskId,taskCategory,taskTitle,taskDescription,taskContent);
    allTasks.AddTask(createTask);

}