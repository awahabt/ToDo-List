using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Program
    {
        enum UserChoice
        {
            AddTask = 1,
            DeleteTask,
            Exit
        }
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                if (toDoList.Count > 0)
                {
                    Console.WriteLine("---------------\nTo-Do-List: \n---------------\n");
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine(" > " + toDoList[i]);
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("You Currently have no task in your To-Do list.");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                }

                Console.WriteLine("-------------");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Exit");
                Console.WriteLine("_____________\n");

                int choice = int.Parse(Console.ReadLine());

                if(choice == (int)UserChoice.AddTask)
                {
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("Enter Task: ");
                    Console.WriteLine("-------------");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added Successfully!");
                }
                else if(choice == (int)UserChoice.DeleteTask)
                {
                    if(toDoList.Count > 0)
                    {
                        Console.WriteLine("Enter the number of the task you want to Delete: ");
                        for(int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ")" + toDoList[i]);
                        }
                    }
                    int taskNum = int.Parse(Console.ReadLine());
                    taskNum--;

                    if(taskNum >= 0 && taskNum < toDoList.Count) 
                    {
                        toDoList.RemoveAt(taskNum);
                        Console.Clear();
                        Console.WriteLine("Task Deleted Successfully!\n");
                    }
                    else
                    {
                        Console.Clear() ;
                        Console.WriteLine("Invalid Task Number. \n");
                    }
                }
                else if(choice == (int)UserChoice.Exit)
                {
                    break;
                }
            }

            //Console.ReadLine();
        }

    }
}