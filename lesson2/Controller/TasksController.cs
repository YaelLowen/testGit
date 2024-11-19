using lesson2.Models;
using lesson2.Services;
using Microsoft.AspNetCore.Mvc;

namespace lesson2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {


       
        private readonly ITasksServices _TasksServices;
        public TasksController(ITasksServices TasksServices)
        {
            _TasksServices = TasksServices;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Tasks>> GetTasks()
        {
            return _TasksServices.GetTasks();
        }

        [HttpGet("{id}")]

        public ActionResult<IEnumerable<Tasks>> GetTaskByName(int id)
        {
            var task = _TasksServices.GetTaskByName(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<Tasks> CreateTask(Tasks newTask)
        {
            if( _TasksServices.CreateTask(newTask))
            {
                return CreatedAtAction(nameof(GetTasks), new { id = newTask.id }, newTask);

            }
            return NotFound();

        }
        [HttpPut("{id}")]
        public ActionResult<Tasks> UpdateTask(int id,Tasks onetask)
        {
            _TasksServices.UpdateTask(onetask);
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
        public ActionResult<Tasks> DeleteTask(int id)
        {
             _TasksServices.DeleteTask(id);
            return NoContent();
        }



    } 
}
