using System;
using System.Linq;

namespace ToDo_List;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the to do list application !");
        Console.WriteLine("********************************************************************************************");
        List<string> taskList = new List<string>();
        string option = "";

        while (option != "e")
        {
            Console.WriteLine("What will you like to do today?");
            Console.WriteLine("Enter 1 to adda task to the list");
            Console.WriteLine("Enter 2 to remove a task from the list");
            Console.WriteLine("Enter 3 to view the list");
            Console.WriteLine("Enter e to exit the list");

            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Please enter the task you want to add to the list");
                string task = Console.ReadLine();
                taskList.Add(task);
                 Console.WriteLine("Task added successfully!");
                Console.WriteLine("************************************");
                Console.WriteLine("****************************************************************************************************************");




            }
            else if (option == "2")
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine(i + " : " + taskList[i]);
                }
                Console.WriteLine("Enter the number of the task you want to remove ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                taskList.RemoveAt(taskNumber);

                    // Console.WriteLine("please enter the task you want to remove");
                    // string.task =Console.ReadLine();
                    // taskList.Remove(task);
                    // console.WriteLine("Task is removed from the list!")
                }
            else if (option == "3")
            {
                System.Console.WriteLine("Current task in the list: ");

                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine(taskList[i]);
                    }

                Console.WriteLine("***********************************************************************");

            }
            else if (option == "e")
            {
                Console.WriteLine("Exiting the program ");
                Console.WriteLine("****************************************************************************************************************");
                

            }
            else
            {
                Console.WriteLine(" Invalid option please try again");
            }
        }
        Console.WriteLine("****************************************************************************************************************");
        System.Console.WriteLine("Thank you for using the application!");
    }
}

