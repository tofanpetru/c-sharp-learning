using System;
using System.Collections.Generic;
using static DataApp.Menu;
using static DataApp.Employee;
using static DataApp.Task;
namespace DataApp
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<Employee> employees = new();//all employees
            List<Task> tasks = new();//all tasks

            //default Employee
            Employee defaultEmployee = new("Ion", "Baron", "IBaron");

            CopyEmployeeToList(employees, defaultEmployee);
            
            int choice = 0;
            int subChoice = 0;

            bool menuAllNotDone = true;

            var idState = new AutoIncrement();//auto increment task id

            while (menuAllNotDone)
            {
                Menu.PrincipalMenu();//menu display

                choice = InputValidInt(choice);

                UserMenu userChoice = MenuChoice(choice);

                switch (userChoice)
                {
                    case UserMenu.addUser:
                        MenuTextResult("Add user");

                        AddEmployee(employees);

                        break;
                    case UserMenu.showAllUsers:
                        MenuTextResult("All users:");

                        PrintEmployees(employees);
                        break;
                    case UserMenu.choiceUser:
                        try
                        {
                            Guid idUserSelected = ChoiceEmployee(employees);

                            Menu.SubMenuUserChoice();//sub menu display

                            subChoice = InputValidInt(subChoice);
                            UserChoice subUserChoice = SubMenuChoice(subChoice);

                            switch (subUserChoice)
                            {
                                case UserChoice.showAllTaskOfUser:
                                    MenuTextResult("All tasks of selected user");

                                    ShowAllTasksOfUser(tasks, idUserSelected);

                                    Console.ReadKey();
                                    break;
                                case UserChoice.addTaskUser:
                                    MenuTextResult("Add task");

                                    AddTaskIndividualUser(tasks, idUserSelected, idState.GenerateId());

                                    break;
                                case UserChoice.completeUserTask:
                                    MenuTextResult("Complete task");

                                    CompleteEmployeeTask(tasks, idUserSelected);

                                    break;
                                default:
                                    MenuTextResult("Error ! invalid choice");
                                    break;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Invalid range!");
                            break;
                        }
                        break;
                    case UserMenu.modifyUser:
                        MenuTextResult("Modify user");

                        PrintEmployees(employees);

                        Console.WriteLine("Select user: ");

                        ModifyEmployee(employees);
                        
                        break;
                    case UserMenu.modifyTask:
                        MenuTextResult("Modify task");

                        ModifyTask(tasks);
                        break;
                    case UserMenu.exit:
                        menuAllNotDone = false;

                        break;
                    default:
                        MenuTextResult("Error ! invalid choice");
                        break;
                }
            }

        }

        private static int InputValidInt(int choice)
        {
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("An int will be entered!");
            }
            return choice;
        }

        

    }
}
