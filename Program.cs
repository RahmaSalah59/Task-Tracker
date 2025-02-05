using System;
using System.Collections.Generic;


namespace TaskTracker
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            List<bool> state = new List<bool>();

            Console.WriteLine("Welcome to Task Tracker application");
            bool exit = false;
            do
            {
                Console.WriteLine(" 1. Add new Task \n 2. View All tasks \n 3. Mark Task Complete \n 4. Remove Task \n 5. Exit");
                Console.WriteLine("Enter Your Choice");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);



                switch (choice)
                {
                    case 1:

                        addTask(tasks, state);
                        break;
                    case 2:
                        show(tasks, state);
                        break;
                    case 3:
                        marktask(tasks, state);
                        break;
                    case 4:
                        removetask(tasks, state);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("wrong Choice\n\n");
                        break;
                }
            }
            while (exit == false);
            
        }

        static void addTask(List<string> tasks, List<bool> state) {
            Console.WriteLine("Enter your Task\n");
            string task = Console.ReadLine();
            tasks.Add(task);
            state.Add(false);
        }

        static void show(List<string> tasks, List<bool> state) 
        {
            if (tasks.Count > 0)
            {
                for (int i = 0; i < tasks?.Count; i++)
                    Console.WriteLine($" Task number: {i + 1} || name: {tasks[i]} || state: {state[i]} ");
            }
            else
                Console.WriteLine("No tasks Exists");
        }

        static void marktask(List<string> tasks, List<bool> state) {
            int i;
            Console.WriteLine("Please Enter Task Number");
            bool check =int.TryParse(Console.ReadLine(), out i);

            if (--i < tasks.Count && check == true) {
                state[i] = true;
                Console.WriteLine("Task state updated !  \n\n");
            }
            else Console.WriteLine("wrong input\n");

        }
        static void removetask(List<string> tasks, List<bool> state)
        {
            int i;
            Console.WriteLine("Please Enter Task Number");
            bool check = int.TryParse(Console.ReadLine(), out i);

            if (--i < tasks.Count && check == true) {
                tasks.RemoveAt(i);
                state.RemoveAt(i);
                Console.WriteLine("Task removed successfully\n\n");
            }
            else Console.WriteLine("wrong input");

        }

    }


}
