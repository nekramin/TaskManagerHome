using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace TaskManagerHome
{
    public class PersonalTask : Task
    {
        public static void mainMenu()
        {
            Console.WriteLine("---      Главное меню      ---\n");
            Console.WriteLine("--- 1. Просмотр всех задач ---");
            Console.WriteLine("--- 2. Создать задачу      ---");
            Console.WriteLine("--- 3. Удалить задачу      ---");
            Console.WriteLine("--- 4. Изменить задачу     ---");
            Console.WriteLine("--- 5. Выход               ---\n");
            Console.Write("Введите номер пункта: ");

            numMenu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public static void showTask()
        {
            Console.WriteLine("--- Список всех задач ---\n");

            if (cntTitleTasks > 0)
            {
                for (int i = 1; i <= cntTitleTasks; i++)
                {
                    Console.WriteLine($"- Задача №{i} -\nНазвание задачи: {allTitleTasks[i]}\nОписание задачи: {allDescriptionTasks[i]}\nДата окончания задачи: {allDeadlineTasks[i]}\nПриоритет задачи: {allPriorityTasks[i]}\n");
                }
                Console.WriteLine();
            }

            else
            {
                Console.Write("--- Список задач пуст ---\n\n");
            }
        }

        public static void createTask()
        {
            Console.Write("--- Создание задачи ---\nНазвание задачи: ");
            cntTitleTasks += 1;
            allTitleTasks[cntTitleTasks] = Console.ReadLine();

            Console.Write("Описание задачи: ");
            cntDescriptionTasks += 1;
            allDescriptionTasks[cntDescriptionTasks] = Console.ReadLine();

            Console.Write("Дата окончания задачи: ");
            cntDeadlineTasks += 1;
            allDeadlineTasks[cntDeadlineTasks] = Console.ReadLine();

            Console.Write("Приоритет задачи: ");
            cntPriorityTasks += 1;
            allPriorityTasks[cntPriorityTasks] = Console.ReadLine();

            Console.WriteLine("\n\nЗадача успешно создана!\n\n");
        }

        public static void Exit()
        {
            isRunning = false;
            Console.Write("Успешное завершение программы.");
        }
    }
}
