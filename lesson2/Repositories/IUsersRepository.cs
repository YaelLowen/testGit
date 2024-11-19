using lesson2.Models;

namespace lesson2.Repositories
{
    public interface IUsersRepository
    {
        List<Users> GetUsers();



     void CreateUser(Users newUser);

        void UpdateUser(Users users);

        void DeleteUser(int id);
    }
}
