namespace TaskManagerHome
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите имя задачи: ");
            Title = Console.ReadLine();

            Console.WriteLine("Задача получила автоматический статус \"Невыполненная\"");
            Console.Write("\nВведите описание: ");
            Description = Console.ReadLine();

            Console.Write("Введите дату окончания задачи: ");
            Deadline = Console.ReadLine();

            showTask(Title, Description, isDone, Deadline);

        }

        public static bool isDone = false;
        public static string Description;
        public static string Title;
        public static string Deadline;

        public static void completeTask(bool isDone)
        {
            if (isDone == false)
            {
                isDone = true;
                Console.WriteLine("Отмечена как выполненая");
            }

            else
            {
                Console.WriteLine("Уже выполнена");
            }
        }

        public static void checkStatus(bool isDone)
        {
            if (isDone == false)
            {
                Console.WriteLine("Невыполненная");
            }

            else
            {
                Console.WriteLine("Выполненная");
            }
        }

        public static void showTask(string Title, string Description, bool isDone, string Deadline)
        {
            Console.Write($"Имя задачи: {Title}\nОписание задачи: {Description}\nСтатус задачи: ");
            checkStatus(isDone);
            Console.Write($"Дедлайн: ");
            WorkTask.ShowDeadline(Deadline);

            if (isDone == true)
            {
                Console.WriteLine("\nВыполнена");
            }

            else
            {
                Console.Write("\nНе выполнена, выполнить? (да/нет): ");
                string yesNo = Console.ReadLine().ToLower();

                if (yesNo == "да")
                {
                    completeTask(isDone);
                }

                else
                {
                    Console.WriteLine("\nЗадача остается в статусе невыполненная");
                }

                showTask(Title, Description, isDone, Deadline);
            }
        }
    }
}