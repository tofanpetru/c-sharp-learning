using System;

namespace CsharpAdvanced1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Generic<string> valueContainer = new Generic<string>
            {
                Value = "Super value"
            };

            Console.WriteLine(valueContainer.ToString());

            Console.WriteLine("Task 2");
            int[] firstArray = { 1, 2, 3, 4 };
            int[] secondArray = { 5, 6, 7 };

            Console.WriteLine(firstArray.Concatenate(secondArray));

            Console.WriteLine("Task 3");
            GenericList<int> genericList = new GenericList<int>(5, 6);

            genericList.PrintList();
        }
    }
}
