using System;
using System.Collections.Generic;

namespace CsharpAdvanced1
{
    public class GenericList<T>
    {
        private readonly List<int> ListOfValues = new List<int>();

        public GenericList(int item, int item2)
        {
            ListOfValues.Add(item);
            ListOfValues.Add(item2);
        }

        public void PrintList()
        {
            foreach (var item in ListOfValues)
            {
                Console.Write(item + " ");
            }
        }
    }
}
