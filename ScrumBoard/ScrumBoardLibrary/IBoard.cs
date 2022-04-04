
namespace ScrumBoardLibrary
{
    internal interface IBoard
    {
        public string BoardName { get; }
        public void AddTaskIntoColumn(Task task, int columnNum = 0);
        public void MoveTaskBetweenColumns(string columnUnicalID, string  taskUnicalID);
        public Task GetTask(string taskUnicalID);
        public void DeleteTask(string unicalID);

        public void AddColumn(Column column);
        public Column GetColumn(string columnUnicalID);
        public List<Column> LookAllColumn();


    }
}
