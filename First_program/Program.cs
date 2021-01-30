using System;
//Ideal weight Calculator :)
namespace First_program
{
    class Program //declararea clasei
    {
        static void Main()
        {
            double personWeight;

            Console.WriteLine("Enter your weight :");

            personWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weight is: {0}",personWeight);
        }
    }
}
