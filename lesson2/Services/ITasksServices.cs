using lesson2.Models;

namespace lesson2.Services
{
    public interface ITasksServices
    {
        List<Tasks> GetTasks();

        List<Tasks> GetTaskByName(int id);

        bool CreateTask(Tasks newTask);
        void UpdateTask(Tasks oneTask);

        void DeleteTask(int id);
    }
}
