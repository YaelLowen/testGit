namespace lesson2.Models
{
    public class Tasks
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public int? dueDate { get; set; }
        public int? priority { get; set; }
        public int userId { get; set; }
        public int ProductId { get; set; }

         public virtual Users? users { get; set; }
         public virtual Product? product { get; set; }
    }
    public class Users
    {

        public int id { get; set; }
        public string? Name { get; set; }
        //public ICollection<Tasks> tasks { get; set; } = new List<Tasks>();
    }
    public class Product
    {
      public int id { get; set; }
        public string? name { get; set; }
        public int? price { get; set; }
        //public ICollection<Tasks> tasks { get; set; } = new List<Tasks>();

    }
}
