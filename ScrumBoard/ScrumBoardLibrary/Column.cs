
namespace ScrumBoardLibrary
{
    public class Column : IColumn
    {
        string ExistTask = "You cannot add an existing task";
        public string UnicalID { get; }
        public string ColumnName { get; set; }

        private readonly List<Task> Tasks;

        public Column(string name)
        {
            ColumnName = name;
            UnicalID = Guid.NewGuid().ToString();
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            if(Tasks.Contains(task))
            {
                throw new Exception(ExistTask);
            }

            else
                Tasks.Add(task);
        }

        public bool DeleteTask(string taskUnicalID)
        {
            int tasksListSize = Tasks.Count;

            for (int i = 0; i < tasksListSize; i++)
            {
                if (taskUnicalID == Tasks[i].UnicalID)
                {
                    Tasks.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Task? GetTask(string taskUnicalID)
        {
            int tasksListSize = Tasks.Count;

            for (int i = 0; i < tasksListSize; i++)
            {
                if (taskUnicalID == Tasks[i].UnicalID)
                {
                    return Tasks[i];
                }
            }
            return null;
        }

        public List<Task> LookAllTasks()
        {
            return Tasks;
        }
    }
}
