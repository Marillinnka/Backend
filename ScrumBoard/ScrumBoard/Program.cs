using ScrumBoardLibrary;

Board board = new("Доска дел");
Column columnOne = new("Домашние дела");
Column columnTwo = new("Внеурочная жизнь");
Column columnThree = new("Учёба");
board.AddColumn(columnOne);
board.AddColumn(columnTwo);
board.AddColumn(columnThree);
ScrumBoardLibrary.Task taskOne = new("Убраться в комнате", "Вымыть пол, протереть пыль", Priority.NORMAL);
ScrumBoardLibrary.Task taskTwo = new("Сделать историю", "Написать конспект, выучить определения", Priority.NORMAL);
ScrumBoardLibrary.Task taskThree = new("Сон", "Прекрасно провести 8 часов жизни", Priority.LOW);
ScrumBoardLibrary.Task taskFour = new("Выгулять собаку", "Небольшая прогулка вокруг дома", Priority.LOW);
board.AddTaskIntoColumn(taskOne);
board.AddTaskIntoColumn(taskTwo);
board.AddTaskIntoColumn(taskThree);
board.AddTaskIntoColumn(taskFour);
board.MoveTaskBetweenColumns(columnTwo.UnicalID, taskThree.UnicalID);
board.MoveTaskBetweenColumns(columnThree.UnicalID, taskTwo.UnicalID);
Column column = board.GetColumn(columnTwo.UnicalID);

foreach (ScrumBoardLibrary.Task task in column.LookAllTasks())
{
    System.Console.WriteLine(task.TaskName + "\n");
    System.Console.WriteLine(task.TaskDescription + "\n");
}