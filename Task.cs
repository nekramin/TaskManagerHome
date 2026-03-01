using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerHome
{
    public class Task
    {
        public static bool isRunning = true;

        public static string title;
        public static string description;
        public static string deadline;
        public static int priority;

        public static bool isDone = false;
        public static int numMenu;

        public static int cntTitleTasks = 0;
        public static int cntDescriptionTasks = 0;
        public static int cntDeadlineTasks = 0;
        public static int cntPriorityTasks = 0;

        public static string[] allTitleTasks = new string[50];
        public static string[] allDescriptionTasks = new string[50];
        public static string[] allDeadlineTasks = new string[50];
        public static string[] allPriorityTasks = new string[50];
    }
}
