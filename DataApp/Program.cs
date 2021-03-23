using System;
using System.Collections.Generic;
using System.Linq;

namespace DataApp
{
    class Program
    {
        enum Menu
        {
            addUser=1,
            showAllUsers=2,
            choiceUser=3,
            modifyUser=4,
            modifyTask=5,
            exit = 6
        }

        enum UserChoice
        {
            showAllTaskOfUser=1,
            addTaskUser=2,
            completeUserTask=3,
            exit=4
        }

        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();
            
            Employees defaultEmployee1 = new Employees("Ion","Avsg","IoN");
            Task defaultTaskList1 = new Task("Micro task1", new DateTime(2021, 12, 25), "none", TaskPriority.Hight, 111, State.incomplete);
            Task defaultTaskList2 = new Task("Micro task2", new DateTime(2022, 12, 25), "none", TaskPriority.Medium, 191997, State.complete);
            //defaultEmployee1.AddEmployee("Ionel", "White", "IoNeL");
            defaultEmployee1.AllTasks.Add(defaultTaskList1);
            defaultEmployee1.AllTasks.Add(defaultTaskList2);
            //defaultEmployee1.printEmployee();
            if (defaultEmployee1 != null)
            {
                int j = 0;
                foreach (Employees emp in defaultEmployee1)
                {
                    Console.WriteLine($"{j}. Name: {emp.Name} Surname: {emp.Surname} Nickname: {emp.NickName}  All resolved tasks: {emp.AllTasks.Count} ");
                    j++;
                    
                }
            }
            Console.WriteLine();
            if (defaultTaskList1 != null)
            {
                int k = 0;
                foreach (var emp in defaultEmployee1.AllTasks)
                {
                    Console.WriteLine($"{k}. Task name:{emp.TaskName}  Date of creation:{emp.DateOfCreation}  Date of effectuation:{emp.DateOfEffectuation}  Aditional details:{emp.AdditionalDetails}  Priority:{emp.Priority}  Task cost:{emp.TaskCost}  State:{emp.State} ");
                    k++;

                }
            }


            Console.WriteLine(
                        "1. Add user\n" +
                        "2. Show all users\n" +
                        "3. Choice user\n" +
                        "4. Modify user\n" +
                        "5. Modify task\n" +
                        "6. Exit from application\n");

            int choice = Convert.ToInt32(Console.ReadLine());
            int subChoice = Convert.ToInt32(Console.ReadLine());

            
            Menu userChoice = new Menu();
            userChoice = (Menu)choice;

            UserChoice subUserChoice = new UserChoice();
            subUserChoice = (UserChoice)subChoice;

            Employees employee = new Employees();

            switch (userChoice)
            {
                case Menu.addUser:
                    Console.WriteLine("Add user");
                    break;
                case Menu.showAllUsers:
                    Console.WriteLine("All users");
                    break;
                case Menu.choiceUser:
                    Console.WriteLine("Select a user:");

                    Console.WriteLine(
                        "1. All tasks\n" +
                        "2. Add task\n" +
                        "3. Complete task\n");

                    switch (subUserChoice)
                    {
                        case UserChoice.showAllTaskOfUser:
                            Console.WriteLine("All task of user");
                            if (defaultEmployee1 != null)
                            {
                                int k = 1;
                                foreach (var emp in defaultEmployee1.AllTasks)
                                {
                                    Console.WriteLine($"{k}. Task name: {emp.TaskName}  Date of creation: {emp.DateOfCreation}  Date of effectuation: {emp.DateOfEffectuation}  Aditional details: {emp.AdditionalDetails}  Priority: {emp.Priority}  Task cost: {emp.TaskCost}  State: {emp.State} ");
                                    k++;

                                }
                            }
                            break;
                        case UserChoice.addTaskUser:
                            Console.WriteLine("Add task");
                            break;
                        case UserChoice.completeUserTask:
                            Console.WriteLine("Complete tasks");
                            break;
                        case UserChoice.exit:
                            break;
                        
                        default:
                            Console.WriteLine("Error ! invalid choice");
                            break;
                    }
                    break;
                case Menu.modifyUser:
                    Console.WriteLine("Modify user");
                    break;
                case Menu.modifyTask:
                    Console.WriteLine("Modify task");
                    break;
                case Menu.exit:
                    break;
                
                default:
                    Console.WriteLine("Error ! invalid choice");
                    break;
            }
        }
    }
}
