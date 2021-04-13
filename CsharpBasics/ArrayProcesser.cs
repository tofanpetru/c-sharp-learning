using System;
using System.Linq;

namespace CsharpBasics
{
    public static class ArrayProcesser
    {
        public static int CountEvenNumbers(int[] arrToCount)
        {
            int evenCount = 0;

            for (int i = 0; i < arrToCount.Length; i++)
            {
                if ((arrToCount[i] & 2) == 0)
                    evenCount++;
            }
            return evenCount;
        }

        public static void IsContains(this int[] intArray, int firstValue, int secoundValue)
        {
            if (intArray.CheckExistValue(firstValue) || intArray.CheckExistValue(secoundValue))
            {
                Console.WriteLine($"Number {firstValue} or {secoundValue} contain in this array");
            }
            else
            {
                Console.WriteLine("It does not contain");
            }
        }

        public static void IsContainsAfterNumber(this int[] intArray, int value, int isContainValue)
        {
            if (intArray.Contains(value))
            {
                int containValue = 0;
                int indexValue = intArray.FindIndex(value);

                for (int i = indexValue; i < intArray.Length; i++)
                {
                    if (intArray[i] == isContainValue)
                    {
                        containValue = intArray[i];
                        break;
                    }
                }
                if (containValue != 0)
                {
                    Console.WriteLine($"The value {value},{containValue} are contained after {value}");
                }
                else
                {
                    Console.WriteLine($"The value are not contained after {value}");
                }

            }
            else
            {
                Console.WriteLine($"It does not contain {value}");
            }
            Console.WriteLine();
        }
    }
}
