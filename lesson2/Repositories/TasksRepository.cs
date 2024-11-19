using lesson2.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson2.Repositories
{
    public class TasksRepository:ITasksRepository
    {
        private readonly TasksDbContext _context;
        public TasksRepository(TasksDbContext context)
        {
            _context = context;
        }
        
        public List<Tasks> GetTasks()
        {
                return _context.Tasks.ToList();

        }



        public bool CreateTask(Tasks Task)
        {
            
            _context.Tasks.Add(Task);

            var P = _context.Product.Where(x => x.id == Task.ProductId);
            //Product p = allProduct.FirstOrDefault(x => x.id == TTask.ProductId);
            if (P.Count() > 0)
            {
                _context.Tasks.Add((Tasks)P);
                _context.SaveChanges();
                return true;//notfound
            }
          

            return false;

        }
        public void UpdateTask(Tasks Task)
        {
            _context.Tasks.Update(Task);
            _context.SaveChanges();

        }
    

    public void DeleteTask(int id)
    {
            Tasks? tasks = _context.Tasks.Find(id);
            if(tasks!=null)
            {
                _context.Tasks.Remove(tasks);
                _context.SaveChanges();
            }
    }


        
    }
}
