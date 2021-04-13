using System;
using System.Linq;

namespace CsharpAdvanced1
{
    public static class ArrayExtensions
    {
        public static void PrintArray<T>(this T[] arrayToPrint)
        {
            foreach (var array in arrayToPrint)
            {
                Console.Write(array + " ");
            }
            Console.WriteLine();
        }

        public static string Concatenate<T>(this T[] firstArray, T[] secondArray)
        {
            if (firstArray == null)
            {
                return secondArray.ToString();
            }
            if (secondArray == null)
            {
                return firstArray.ToString();
            }

            return string.Join(", ", firstArray.Concat(secondArray).ToArray());
        }
    }
}
