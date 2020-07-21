using System;

namespace ISTA220Quiz03
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateReciprocal();
        }
        private static void calculateReciprocal()
        {
            int number;
            Console.WriteLine("To calculate the reciprocal of an integer, enter a positive integer: ");
            string stringnumber = Console.ReadLine();
            try
            {
                number = int.Parse(stringnumber);
                if (number < 0)
                    throw new Exception("Your number has to be a positive number");
                double reciprocal = (double)1.0 / number;
                if (double.IsInfinity(reciprocal))
                    throw new DivideByZeroException();
                Console.WriteLine($"The reciprocal is {reciprocal}");
            }
            catch (FormatException fex)
            {

                Console.WriteLine(fex.Message);
                calculateReciprocal();
            }
            catch (DivideByZeroException fex)
            {

                Console.WriteLine(fex.Message);
                calculateReciprocal();
            }
            catch (Exception fex)
            {

                Console.WriteLine(fex.Message);
                calculateReciprocal();
            }
        }
    }
}
