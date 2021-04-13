using System;
using static CsharpBasics.ArrayProcesser;
using static CsharpBasics.EnumHelper; //ShowAll()
using static CsharpBasics.Multiplier;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            /* Task 1 */
            string[] strArr =
            {
                "acca ",
                "expert",
                " ",
                "level",
                "a-cc,a",
            };
            strArr.PrintArray();

            /* Task 2 */
            IsPalindrom(strArr);

            /* Task 3 */
            int[] intArr =
            {
                2, 6, 4, 8, 9, 5, 1, 2, 3
            };
            intArr.SortIntArrayAscending();

            /* Task 4 */
            intArr.FindMaxValueInArray();

            /* Task 5 */
            MultiplierByNumber();

            /* Task 6 */
            ShowAll();
            CarBrand.BMW.Next();
            CarBrand.BMW.Previous();

            /* Task 7 */
            int[] arrayContainer =
            {
                2, 3, 1
            };

            int[] arrayContainer2 =
            {
                6, 3, 7, 1, 5, 8, 2
            };
            arrayContainer.IsContains(1, 4);

            arrayContainer.PrintArray();
            arrayContainer.IsContainsAfterNumber(1, 2);

            arrayContainer2.PrintArray();
            arrayContainer2.IsContainsAfterNumber(1, 2);

            int countEvenNumbers = CountEvenNumbers(arrayContainer);
            Console.WriteLine($"Even numbers = {countEvenNumbers}");
        }

        private static void IsPalindrom(string[] strArr)
        {
            Console.WriteLine("\nWith non alpha numeric characters");
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i].IsPalindromNonAlphaNumeric();
            }

            Console.WriteLine("\nWith alpha numeric characters");
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i].IsPalindrom();
            }
            Console.WriteLine();
        }
    }
}
