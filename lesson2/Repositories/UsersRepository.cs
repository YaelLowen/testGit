using lesson2.Models;

namespace lesson2.Repositories
{
    public class UsersRepository: IUsersRepository
    {


        private readonly TasksDbContext _context;
        public UsersRepository(TasksDbContext context)
        {
            _context = context;
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();

        }



        public void CreateUser(Users user1)
        {
            _context.Users.Add(user1);

            _context.SaveChanges();

        }
        public void UpdateUser(Users user)
        {

            _context.Users.Update(user);
            _context.SaveChanges();

        }


        public void DeleteUser(int id)
        {
            Users? user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
