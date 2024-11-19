
using lesson2.Models;
using lesson2.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;

namespace lesson2.Services
{
    public class TasksServices : ITasksServices
    {
        private readonly ITasksRepository _TasksRepository;
        private readonly IUsersRepository _UsersRepository;
      //  private readonly IProductRepository _ProductRepository;
        public TasksServices(ITasksRepository TasksRepository,IUsersRepository usersRepository)
        {
            _TasksRepository = TasksRepository;
            _UsersRepository = usersRepository;
        }


        public List<Tasks> GetTasks()
        {
            var allTasks = _TasksRepository.GetTasks();
            return allTasks;
        }


        public bool CreateTask(Tasks TTask)
        {
            var allUser = _UsersRepository.GetUsers();
            Users a = allUser.FirstOrDefault(x => x.id.Equals(TTask.userId));
            if (a == null)
            {
                return false;//notfound
            }



            //var allProduct = _ProductRepository.GetProducts();
            //Product p=allProduct.FirstOrDefault(x => x.id == TTask.ProductId);
            //if (p == null)
            //{
            //    return NotFound();//notfound
            //}
            //var allTask = _TasksRepository.GetTasks();
            //TTask.id = allTask.Count + 1;
            //allTask.Add(TTask);
            _TasksRepository.CreateTask(TTask);

            return true;
        }

       

        public void UpdateTask(Tasks oneTask)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            //a.status = "done";
            _TasksRepository.UpdateTask(oneTask);
            //return a;
        }
        public void DeleteTask(int id)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            _TasksRepository.DeleteTask(id);
           
        }
        public List<Tasks> getTaskByName(int id)
        {
                var allTasks = _TasksRepository.GetTasks();

               var a = allTasks.FindAll(x => x.id == id);

                return a;
        }
        //?????????????????????????????????????

        public List<Tasks> GetTaskByName(int id)
        {
            throw new NotImplementedException();
        }


        //Tasks ITasksServices.GetTaskById(int id)
        //{

        //    var allTasks = _TasksRepository.GetTasks();

        //    var a = allTasks.FirstOrDefault(x => x.id == id);

        //    return a;

        //}
    }
}
