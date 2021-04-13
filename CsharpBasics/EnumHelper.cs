using System;
using System.Linq;

namespace CsharpBasics
{
    public static class EnumHelper
    {
        public static void Next(this CarBrand value)
        {
            var nextValue = (from CarBrand val in Enum.GetValues(typeof(CarBrand))
                             where val > value
                             orderby val
                             select val).DefaultIfEmpty().First();

            Console.WriteLine($"{value} next: {nextValue}");
        }

        public static void Previous(this CarBrand value)
        {
            var nextPrevious = (from CarBrand val in Enum.GetValues(typeof(CarBrand))
                                where val > (value - 2)
                                orderby val
                                select val).DefaultIfEmpty().First();

            Console.WriteLine($"{value} previous: {nextPrevious}");
        }

        public static void ShowAll()
        {
            foreach (CarBrand carBrand in Enum.GetValues(typeof(CarBrand)))
            {
                Console.Write(carBrand + " ");
            }
            Console.WriteLine();
        }
    }
}
