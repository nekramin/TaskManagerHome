using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerHome
{
    public class Task : Program
    {
        public static void ShowInfo(string Title, string Description, bool isDone, string Deadline)
        {
            Console.Write($"Имя задачи: {Title}\nОписание задачи: {Description}\nСтатус задачи: ");
            checkStatus(isDone);
            Console.Write($"Дедлайн: ");
            WorkTask.ShowDeadline(Deadline);
        }
    }
}
