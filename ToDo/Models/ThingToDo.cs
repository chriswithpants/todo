namespace ToDo.Models
{
    public class ThingToDo
    {
        public string Description { get; set; }
        public bool Completed { get; set; }

        public ThingToDo(string description, bool completed)
        {
            Description = description;
            Completed = completed;
        }
    }
}