using lesson2.Models;
using lesson2.Repositories;

namespace lesson2.Services
{
    public class UsersServices : IUsersServices
    {

         
        private readonly IUsersRepository _UsersRepository;
       


        public UsersServices(IUsersRepository UsersRepository)
        {
            _UsersRepository = UsersRepository;
        }


        public List<Users> GetUsers()
        {
            var allUsers = _UsersRepository.GetUsers();
            return allUsers;
        }


        public Users CreateUser(Users user)
        {

            //var allTask = _TasksRepository.GetTasks();
            //TTask.id = allTask.Count + 1;
            //allTask.Add(TTask);
            _UsersRepository.CreateUser(user);
            return user;
        }



        public void UpdateUser(Users oneUser)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            //a.status = "done";
            _UsersRepository.UpdateUser(oneUser);
            //return a;
        }
       
        public void DeleteUser(int id)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            _UsersRepository.DeleteUser(id);

        }
        public List<Users> GetUserById(int id)
        {
            var allUsers = _UsersRepository.GetUsers();

            var a = allUsers.FindAll(x => x.id == id);

            return a;
        }


      


        //Tasks ITasksServices.GetTaskById(int id)
        //{

        //    var allTasks = _TasksRepository.GetTasks();

        //    var a = allTasks.FirstOrDefault(x => x.id == id);

        //    return a;

        //}
    }
}
