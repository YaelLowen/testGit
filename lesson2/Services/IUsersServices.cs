using lesson2.Models;

namespace lesson2.Services
{
    public interface IUsersServices
    {
        List<Users> GetUsers();

        List<Users> GetUserById(int id);

        Users CreateUser(Users newUser);
        void UpdateUser(Users oneUser);

        void DeleteUser(int id);
    }
}
