using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CsharpBasics
{
    public static class StringExtensions
    {
        public static void IsPalindromNonAlphaNumeric(this string strArr)
        {
            string clearStr = RemoveNonAlphaNumericCharacters(strArr);

            if (!string.IsNullOrWhiteSpace(strArr))
            {
                if (clearStr.SequenceEqual(clearStr.Reverse()))
                {
                    Console.WriteLine($"{strArr} is palindrome");
                }
                else
                {
                    Console.WriteLine($"{strArr} is not a palindrome");
                }
            }
        }

        public static void IsPalindrom(this string strArr)
        {
            if (!string.IsNullOrWhiteSpace(strArr))
            {
                if (strArr.SequenceEqual(strArr.Reverse()))
                {
                    Console.WriteLine($"{strArr} is palindrome");
                }
                else
                {
                    Console.WriteLine($"{strArr} is not a palindrome");
                }
            }
        }

        public static string RemoveNonAlphaNumericCharacters(string strArr)
        {
            strArr = new Regex("[^a-zA-Z0-9_.]").Replace(strArr, "").ToLower();

            return strArr;
        }
    }
}
