using lesson2.Models;

namespace lesson2.Repositories
{
    public interface ITasksRepository
    {
        List<Tasks> GetTasks();



        bool CreateTask(Tasks newTask);

        void UpdateTask(Tasks tasks);

        void DeleteTask(int id);

    }
}
