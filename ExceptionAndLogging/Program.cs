using NLog;
using System;

namespace ExceptionAndLogging
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //1. At least one System Exception
            DivideByNumber(0);

            //2. At least one Custom Exception
            IsZero(0);
            //3. 
            logger.Info("This is an informational message");
            logger.Error("This is an error message");


            Console.ReadLine();
        }

        private static void DivideByNumber(int number)
        {
            int x = number;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e.Message}");
            }
            Console.WriteLine();
        }

        private static void IsZero(int number)
        {
            try
            {
                if (number != 0)
                {
                    Console.WriteLine("It's not zero");
                }
                else
                {
                    throw new NotZeroException();
                }
            }
            catch (NotZeroException e)
            {

                Console.WriteLine($"NotZeroException Handler: {e.Message}");
            }
        }
    }
}