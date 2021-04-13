using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpBasics
{
    public static class ArrayExtensions
    {
        public static void PrintArray<T>(this IEnumerable<T> arrayToPrint)
        {
            foreach (var array in arrayToPrint)
            {
                Console.Write(array + " ");
            }

            Console.WriteLine();
        }

        public static void SortIntArrayAscending(this int[] arrayToSort)
        {
            int tmp;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = i + 1; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[j] < arrayToSort[i])
                    {
                        tmp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = tmp;
                    }
                }
            }

            arrayToSort.PrintArray();
        }

        public static void FindMaxValueInArray<T>(this IEnumerable<T> anArray)
        {
            var maxValue = anArray.Select((value) => new { value })
                             .OrderByDescending(vi => vi.value)
                             .First();

            Console.WriteLine(maxValue);
        }

        public static int FindIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }

        public static bool CheckExistValue<T>(this T[] array, T target)
        {
            return Array.IndexOf(array, target) != -1;
        }
    }
}
