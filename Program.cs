using static TaskManagerHome.PersonalTask;
using static TaskManagerHome.Task;

namespace TaskManagerHome
{
    public class Program
    {
        public static void Main()
        {
            while (isRunning)
            {
                mainMenu();

                if (Task.numMenu == 1)
                {
                    showTask();
                }

                if (Task.numMenu == 2)
                {
                    createTask();
                }

                if (Task.numMenu == 5)
                {
                    Exit();
                }
            }
        }
    }
}