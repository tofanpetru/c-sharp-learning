using System;
using System.Collections;

namespace DataApp
{
    public class IEnumerable
    {

        public Employee[] employeeList;
        int position = -1;

        public IEnumerator Enumerator { get; set; }
        public object Current
        {
            get
            {
                try
                {
                    return employeeList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            yield return new Employee(employeeList);
        }

        public bool MoveNext()
        {
            position++;
            return (position < employeeList.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}