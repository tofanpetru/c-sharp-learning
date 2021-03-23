using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class Employee
    {
        public Employee()
        {
            AllTasks = new List<Task>();
        }
       

        public String Name { get; set; }
        public String Surname { get; set; }
        public String NickName { get; set; }
        public List<Task> AllTasks { get; set; }
        public decimal AllResolvedTaskConst { get; set; }
        
    }
    
    public class Employees : Employee
    {
        public Employees(string name, string surname, string nickName)
        {
            Name = name;
            Surname = surname;
            NickName = nickName;
            AllResolvedTaskConst = AllTasks.Count;
        }
        public Employees()
        {

        }
        public IEnumerator Enumerator { get; set; }

        public IEnumerator GetEnumerator()
        {
            return Enumerator;
        }

        List<Employee> lstEmployee = new List<Employee>();
        public void AddEmployee(string name, string surname, string nickName)
        {
            Employee employee = new Employee();
     
            employee.Name = name;
            employee.Surname = surname;
            employee.NickName = nickName;
            employee.AllResolvedTaskConst = AllTasks.Count;

            lstEmployee.Add(employee);       
        }
        
        public void printEmployee()
        {

            Console.WriteLine(
               "Name: ", Name +
               " Surname: ", Surname +
               " Nick name: ", NickName +
               " All resolvedTask: ", AllResolvedTaskConst
               );
        }
       

    }
  
}
