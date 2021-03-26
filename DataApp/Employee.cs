using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static DataApp.Menu;
namespace DataApp
{
    public class Employee : IEnumerable
    {
        
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(36)] 
        public String Name { get; set; }
        [Required]
        [MaxLength(36)]
        public String Surname { get; set; }
        public String NickName { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string surname, string nickName)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            NickName = nickName;
        }

        public Employee(Employee[] list)
        {
            employeeList = list;
        }

        public static void ModifyEmployee(List<Employee> employees)
        {
            Guid userNumberId = new();
            try
            {
                int userTaskNumber = int.Parse(Console.ReadLine()) - 1;
                userNumberId = employees.ElementAt(userTaskNumber).Id;

                var findIndexOfUser = employees.FindIndex(e => e.Id == userNumberId);

                Console.WriteLine("Enter Name:");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter Surname:");
                string userSurname = Console.ReadLine();

                Console.WriteLine("Enter Nickname:");
                string userNickname = Console.ReadLine();

                employees[findIndexOfUser].Name = userName;
                employees[findIndexOfUser].Surname = userSurname;
                employees[findIndexOfUser].NickName = userNickname;

                Console.WriteLine("Done!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid range!");
            }
        }

        public static Guid ChoiceEmployee(List<Employee> employees)
        {
            MenuTextResult("Select a user(ex: 1)");

            PrintEmployees(employees);
            Console.WriteLine("Your imput:");

            Guid userChoiceEmployeeId = new();

            try
            {
                int userSelectedEmployee = int.Parse(Console.ReadLine());
                userChoiceEmployeeId = employees.ElementAt(userSelectedEmployee - 1).Id;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            return userChoiceEmployeeId;
        }

        public static void AddEmployee(List<Employee> employees)
        {
            try
            {
                Console.WriteLine("Enter Name:");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter Surname:");
                string userSurname = Console.ReadLine();

                Console.WriteLine("Enter Nickname:");
                string userNickname = Console.ReadLine();

                employees.Add(new Employee() { Id = Guid.NewGuid(), Name = userName, Surname = userSurname, NickName = userNickname });
            }
            catch (FormatException)
            {
                Console.WriteLine("Error!");
            }
            Console.Clear();
        }

        public static void CopyEmployeeToList(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            if (employees != null)
            {
                int j = 1;
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{j}. Name: {employee.Name}; Surname: {employee.Surname}; Nickname: {employee.NickName};");
                    j++;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please add an employee!");
            }
        }
    }

}
