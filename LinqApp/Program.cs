using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ApplicationUser> applicationUsers = new List<ApplicationUser>
            {
                new ApplicationUser("Tofan", "Petru",0,"373 69 772 462","Coding"),
                new ApplicationUser("Alin", "Alexandrii",1,"373 78 000 444","Coding"),
                new ApplicationUser("Alex", "Zdb",2,"373 78 144 333","Books"),
                new ApplicationUser("Mihai", "Crudu",6,"373 69 777 111","Anonim")
            };

            Console.WriteLine("\tFiltering");

            Console.WriteLine("\nWhere");
            Console.WriteLine(applicationUsers.Where(e => e.FirstName.Contains("Tofan"))
                                              .FirstOrDefault()
                                              .ToString());
            Console.WriteLine("\nTake");
            var takeQuery = applicationUsers.Take(3);
            takeQuery.PrintList();

            Console.WriteLine("\nTakeWhile");
            var takeWhileQuery = applicationUsers.TakeWhile(e => e.FavoriteNumber <= 2);
            takeWhileQuery.PrintList();

            Console.WriteLine("\nSkipWhile");
            var skipWhile = applicationUsers.SkipWhile(e => e.FavoriteActivity == "Coding");
            skipWhile.PrintList();

            Console.WriteLine("\nDistinct");
            var distinctQuery = applicationUsers.Distinct();
            distinctQuery.PrintList();

            Console.WriteLine("\n\tProjection");
            Console.WriteLine("\nSelect");
            var selectQuery = applicationUsers.Select(e => e.FirstName);
            selectQuery.PrintQuery();

            Console.WriteLine("\nSelectMany");
            var selectManyQuery = applicationUsers.SelectMany(e => e.FavoriteActivity.Distinct());
            selectManyQuery.PrintQuery();


            Console.WriteLine("\n\tJoining");

            Console.WriteLine("\nZip");
            string[] FavoriteNumberStr = { "one", "two", "three" };
            var zipQuery = applicationUsers.Zip(FavoriteNumberStr, (first, secound) => "[" + secound + "] [" + first + "]").Take(3);
            zipQuery.PrintQuery();

            Console.WriteLine("\n\tOrdering");

            Console.WriteLine("\nOrderBy");
            var orderBy = applicationUsers.OrderBy(e => e.FirstName.Length);
            orderBy.PrintList();

            Console.WriteLine("\nOrderByDescending");
            var orderByDescending = applicationUsers.OrderBy(e => e.FirstName.Length);
            orderByDescending.PrintList();

            Console.WriteLine("\nReverse");
            var reverseQuery = applicationUsers.Select(e => e.MobilePhone).Reverse();
            reverseQuery.PrintQuery();

            Console.WriteLine("\n\tGrouping");

            Console.WriteLine("\nGroup by");
            var groupByQuery = applicationUsers.GroupBy(e => e.FavoriteNumber).FirstOrDefault();
            groupByQuery.PrintList();

            Console.WriteLine("\n\tSet operators");

            string[] container1 = { "one", "two", "three" };
            string[] container2 = { "1", "two", "3" };
            int[] container3 = { 5, 6, 1, 4 };

            Console.WriteLine("\nConcat");
            var concatQuery = container1.Concat(container2);
            concatQuery.PrintQuery();

            Console.WriteLine("\nUnion");
            var unionQuery = container1.Union(container2);
            unionQuery.PrintQuery();

            Console.WriteLine("\nIntersect");
            var intersectQuery = container1.Intersect(container2);
            intersectQuery.PrintQuery();

            Console.WriteLine("\nExcept");
            var exceptQuery = container1.Except(container2);
            exceptQuery.PrintQuery();

            Console.WriteLine("\n\tConverting methods");

            Console.WriteLine("\nToList");
            var toListQuery = container1.ToList();
            foreach (var item in toListQuery)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("\nToArray");
            var toArrayQuery = container2.ToArray();
            for (int i = 0; i < toArrayQuery.Length; i++)
            {
                Console.Write(toArrayQuery[i]);
            }
            Console.WriteLine();

            Console.WriteLine("\n\tElement operators");

            Console.WriteLine("\nFirstOrDefault");
            var firstOrDefaultQuery = container2.FirstOrDefault();
            firstOrDefaultQuery.PrintQuery();

            Console.WriteLine("\nLastOrDefault");
            var lastOrDefaultQuery = container2.LastOrDefault();
            lastOrDefaultQuery.PrintQuery();

            Console.WriteLine("\nSingleOrDefault");
            var singleOrDefaultQuery = container2.SingleOrDefault(e => e.Length > 2);
            singleOrDefaultQuery.PrintQuery();

            Console.WriteLine("\nElementAtOrDefault");
            var elementAtOrDefaultQuery = container2.ElementAtOrDefault(1);
            elementAtOrDefaultQuery.PrintQuery();

            Console.WriteLine("\nDefaultEmpty");
            var defaultEmptyQuery = container2.DefaultIfEmpty();
            defaultEmptyQuery.PrintQuery();

            Console.WriteLine("\n\tAggregation methods");

            Console.WriteLine("\nCount");
            var countQuery = container1.Count();
            Console.WriteLine(countQuery);

            Console.WriteLine("\nMinQuery");
            var minQuery = container3.Min();
            Console.WriteLine(minQuery);

            Console.WriteLine("\nMaxQuery");
            var maxQuery = container3.Max();
            Console.WriteLine(maxQuery);

            Console.WriteLine("\nSumQuery");
            var sumQuery = container3.Sum();
            Console.WriteLine(sumQuery);

            Console.WriteLine("\nAverage");
            var averageQuery = container3.Average();
            Console.WriteLine(averageQuery);

            Console.WriteLine("\nAggregate");
            var aggregateQuery = container3.Aggregate((a, b) => a + b);
            Console.WriteLine(aggregateQuery);

            Console.WriteLine("\n\tQuantifiers");

            Console.WriteLine("\nContains");
            Console.WriteLine(container1.Contains("one"));

            Console.WriteLine("\nAny");
            Console.WriteLine(container3.Any(e => e < 5));

            Console.WriteLine("\nAll");
            Console.WriteLine(container3.All(e => e >= 0));

            Console.WriteLine("\nSequenceEqual");
            Console.WriteLine(container1.SequenceEqual(container2));

            Console.WriteLine("\n\tGeneration methods");

            Console.WriteLine("\nEmpty");
            var emptyContainer = Enumerable.Empty<string>();
            emptyContainer.PrintQuery();

            Console.WriteLine("\nRepeat");
            var repeatQuery = Enumerable.Repeat("C#", 5);
            repeatQuery.PrintQuery();

            Console.WriteLine("\nRange");
            var rangeQuery = Enumerable.Range(1, 8);
            rangeQuery.PrintQuery();
        }
    }
}
