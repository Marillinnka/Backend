
namespace ScrumBoardLibrary
{
    public interface IColumn
    {
        public string ColumnName { get; set; }
        public string UnicalID { get; }
        public void AddTask(Task task);
        public bool DeleteTask(string taskUnicalID);
        public Task? GetTask(string taskUnicalID);
        public List<Task> LookAllTasks();
    }
}
