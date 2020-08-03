using System;
using System.Runtime.CompilerServices;

namespace ISTA220Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateCircumference();
        }
        private static void calculateCircumference()
        {
            double r, per_cir;
            double PI = 3.14;

            try
            {
                Console.WriteLine("Input the radius of the circle : ");
                r = Convert.ToDouble(Console.ReadLine());
                per_cir = 2 * PI * r;
                var area = PI * r * r;
                if (r < 0)
                    throw new Exception("Your number has to be a positive number");
                if (double.IsInfinity(per_cir))
                    throw new DivideByZeroException();
                Console.WriteLine($"The circumferenece is {per_cir}");
                Console.WriteLine($"The area is {area}");
            }

            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calculateCircumference();
            }

            catch (DivideByZeroException fex)
            {
                Console.WriteLine(fex.Message);
                calculateCircumference();

            }

            catch (Exception fex)
            {
                Console.WriteLine(fex.Message);
                calculateCircumference();

            }
        }
    }
}
