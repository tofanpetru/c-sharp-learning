using System;

namespace WeightCalculator
{
    class Program
    {
        static void Main()
        {
            double personWeight=45;//45kg
            double personHeight=1.6;//1.6m

            weightClassification(personWeight, personHeight);
        }
  

        static void weightClassification(double Weight, double Height)
        {
            double IMC = Weight / Height;

            double iMC = IMC;
            if (IMC < 0)
            {
                Console.WriteLine("Error");
            }else if(inRange(iMC, 0,18.49))
            {
                Console.WriteLine("Underweight");
            }else if(inRange(iMC, 18.5, 24.9))
            {
                Console.WriteLine("Normal Weight");
            }else if (inRange(iMC, 25.0, 29.9))
            {
                Console.WriteLine("Overweight");
            }
            else if (inRange(iMC, 30.0, 34.9))
            {
                Console.WriteLine("Obesity gr. 1");
            }else if (inRange(iMC, 35.0, 39.0))
            {
                Console.WriteLine("Obesity gr. 2");
            } else
            {
                Console.WriteLine("Obesity gr. 2");
            }
        }

        public static bool inRange(double value, double minimum, double maximum)
        {
            return value >= minimum && value <= maximum;
        }

    }
}
