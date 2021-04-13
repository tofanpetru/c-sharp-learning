using System;

namespace CsharpBasics
{
    public static class Multiplier
    {
        public static void MultiplierByNumber()
        {
            int N;

            Console.Write("N=");
            try
            {
                N = int.Parse(Console.ReadLine());

                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"{i}\t {10 * i}\t {100 * i}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
