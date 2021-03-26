using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataApp
{
     public enum State
    {
        unknow,
        complete,
        incomplete
    }

    class Task
    {
        [Required]
        public int id;
        [Required]
        public Guid EmployeeId;
        public String TaskName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime? DateOfEffectuation { get; set; }
        public String AdditionalDetails { get; set; }
        public TaskPriority Priority { get; set; }
        public decimal TaskCost { get; set; }
        public State State { get; set; }
        public Task()
        {

        }

        public static void ModifyTask(List<Task> tasks)
        {
            var allTasks = from task in tasks
                           select task;
            int userTaskNumberId = 0;

            PrintTasks(allTasks);

            Console.WriteLine("Select task: ");

            try
            {
                int userTaskNumber = int.Parse(Console.ReadLine()) - 1;
                userTaskNumberId = allTasks.ElementAt(userTaskNumber).id;

                var findIndexOfTaskList = tasks.FindIndex(e => e.id == userTaskNumberId);

                AddTask(out string inputTaskName, out DateTime inputDateOfEffectiation, out string inputAdditionalDetails, out TaskPriority inputTaskPriority, out decimal inputTaskCost, out State inputState);

                tasks[findIndexOfTaskList].TaskName = inputTaskName;
                tasks[findIndexOfTaskList].DateOfEffectuation = inputDateOfEffectiation;
                tasks[findIndexOfTaskList].AdditionalDetails = inputAdditionalDetails;
                tasks[findIndexOfTaskList].Priority = inputTaskPriority;
                tasks[findIndexOfTaskList].TaskCost = inputTaskCost;
                tasks[findIndexOfTaskList].State = inputState;

                Console.WriteLine("Done!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public static void PrintTasks(IEnumerable<Task> allTasks)
        {
            int k = 1;
            foreach (var task in allTasks)
            {
                Console.WriteLine($"{task.id}. Task name: {task.TaskName};  Date of creation: {task.DateOfCreation};  Date of effectuation: {task.DateOfEffectuation};  Aditional details: {task.AdditionalDetails};  Priority: {task.Priority};  Task cost: {task.TaskCost};  State: {task.State}; ");
                k++;
            }
        }
        public static void CompleteEmployeeTask(List<Task> tasks, Guid idUserSelected)
        {
            var incompletTasksList = from task in tasks
                                     where task.EmployeeId == idUserSelected
                                     where task.State != State.complete
                                     select task;
            int k = 1;
            int userTaskNumberId = 0;

            foreach (var task in incompletTasksList)
            {
                Console.WriteLine($"{task.id}. Task name: {task.TaskName};  Date of creation: {task.DateOfCreation};  Date of effectuation: {task.DateOfEffectuation};  Aditional details: {task.AdditionalDetails};  Priority: {task.Priority};  Task cost: {task.TaskCost};  State: {task.State}; ");
                k++;
            }
            Console.WriteLine("Select task: ");

            try
            {
                int userTaskNumber = int.Parse(Console.ReadLine()) - 1;
                userTaskNumberId = incompletTasksList.ElementAt(userTaskNumber).id;

                var findIndexOfTaskList = tasks.FindIndex(e => e.id == userTaskNumberId);

                tasks[findIndexOfTaskList].State = State.complete;
                Console.WriteLine("Done!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public static void ShowAllTasksOfUser(List<Task> tasks, Guid idUserSelected)
        {
            var getAllTasksOfUser = from task in tasks
                                    where task.EmployeeId == idUserSelected
                                    select task;
            int resolvedTasks = 0;
            int k = 1;
            foreach (var task in getAllTasksOfUser)
            {
                Console.WriteLine($"{k}. Task name: {task.TaskName};  Date of creation: {task.DateOfCreation};  Date of effectuation: {task.DateOfEffectuation};  Aditional details: {task.AdditionalDetails};  Priority: {task.Priority};  Task cost: {task.TaskCost};  State: {task.State}; ");
                k++;
                if (task.State == State.complete)
                {
                    resolvedTasks++;
                }
            }
            Console.WriteLine($"Total resolved tasks: {resolvedTasks} ");
        }

        public static void AddTaskIndividualUser(List<Task> tasks, Guid idUserSelected, int idTask)
        {
            try
            {
                AddTask(out string inputTaskName, out DateTime inputDateOfEffectiation, out string inputAdditionalDetails, out TaskPriority inputTaskPriority, out decimal inputTaskCost, out State inputState);

                tasks.Add(new Task() { id = idTask, EmployeeId = idUserSelected, TaskName = inputTaskName, DateOfEffectuation = inputDateOfEffectiation, AdditionalDetails = inputAdditionalDetails, Priority = (TaskPriority)inputTaskPriority, TaskCost = inputTaskCost, State = (State)inputState });
            }
            catch (FormatException)
            {
                Console.WriteLine("incorrect input!");
            }
        }

        public static void AddTask(out string inputTaskName, out DateTime inputDateOfEffectiation, out string inputAdditionalDetails, out TaskPriority inputTaskPriority, out decimal inputTaskCost, out State inputState)
        {
            Console.WriteLine("Task name:");
            inputTaskName = Console.ReadLine();

            Console.WriteLine("Date of effectuation: (ex:10/12/2021)");
            inputDateOfEffectiation = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Additional details:");
            inputAdditionalDetails = Console.ReadLine();

            Console.WriteLine("Task priority:(1.Low,2.Medium,3.Hight)");
            inputTaskPriority = (TaskPriority)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Task cost:");
            inputTaskCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Task state:(1.Complete, 2.incomplete)");
            inputState = (State)Convert.ToInt32(Console.ReadLine());
        }
    }
}
