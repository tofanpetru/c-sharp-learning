using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
     public enum State
    {
        complete,
        incomplete
    }

    public class Task
    {
        public String TaskName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime? DateOfEffectuation { get; set; }
        public String AdditionalDetails { get; set; }
        public TaskPriority Priority { get; set; }
        public decimal TaskCost { get; set; }
        public State State { get; set; }
        
        public Task(string taskName, DateTime dateOfEffectuation, string additionalDetails, TaskPriority priority, decimal taskCost, State state)
        {
            
            TaskName = taskName;
            DateOfCreation = DateTime.Now;
            DateOfEffectuation = dateOfEffectuation;
            AdditionalDetails = additionalDetails;
            Priority = priority;
            TaskCost = taskCost;
            State = state;
        }
    }
}
