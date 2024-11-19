using lesson2.Models;
using lesson2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersServices _UsersServices;
        public UsersController(IUsersServices UsersServices)
        {
            _UsersServices = UsersServices;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return _UsersServices.GetUsers();
        }

        [HttpGet("{id}")]

        public ActionResult<IEnumerable<Users>> GetUserById(int id)
        {
            var user = _UsersServices.GetUserById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<Users> CreateUser(Users newUser)
        {
            _UsersServices.CreateUser(newUser);

            return CreatedAtAction(nameof(GetUsers), new { id = newUser.id }, newUser);

        }
        [HttpPut("{id}")]
        public ActionResult<Users> UpdateUser(int id, Users oneUser)
        {
            _UsersServices.UpdateUser(oneUser);
            //Tasks task = tasks.FirstOrDefault(X => X.statuse == statuse);
            //if (task == null)
            //    return NotFound();
            //task.statuse = task.statuse;
            //task.dueDate = task.dueDate + 14;
            //task.priority = task.priority;
            //task.name = task.name;
            //task.id = task.id;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Users> DeleteUser(int id)
        {
            _UsersServices.DeleteUser(id);
            return NoContent();
        }

    }
}
