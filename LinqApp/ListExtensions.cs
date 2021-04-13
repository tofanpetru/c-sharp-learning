using System;
using System.Collections.Generic;

namespace LinqApp
{
    public static class ListExtensions
    {
        public static void PrintList(this IEnumerable<ApplicationUser> applicationUsers)
        {
            foreach (var user in applicationUsers)
            {
                Console.Write($"Name:{user.FirstName + ' ' + user.LastName}, favorite number:{user.FavoriteNumber}," +
                $" favorite activity:{user.FavoriteActivity}, phone number:{user.MobilePhone}, created on :{user.CreatedOn}\n");
            }
        }
        public static void PrintQuery<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
