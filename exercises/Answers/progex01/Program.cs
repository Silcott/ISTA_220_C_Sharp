using System;
using System.Globalization;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            var tryAgain = true;
            do
            {
                while (tryAgain = true)
                {
                    // Part 1
                    // Partially worked example
                    Console.WriteLine("\nPart 1, circumference and area of a circle.");
                    Console.Write("Enter an integer for the radius: ");
                    string strradius = Console.ReadLine();
                    int intradius = int.Parse(strradius);
                    double circumference = 2 * Math.PI * intradius;
                    double area = Math.PI * Math.Pow(intradius, 2);
                    double volume = (4 / 3 * Math.PI * Math.Pow(intradius, 3)) / (2);

                    Console.WriteLine($"The circumference is {circumference}");

                    // Implementation for area here
                    Console.WriteLine($"The area is: {area}");

                    // Part 2
                    Console.WriteLine("\nPart 2, volume of a hemisphere.");

                    // Implementation here
                    Console.WriteLine($"The volume is: {volume}");

                    Console.WriteLine("\nNow let's do Heron's Formula, so I need the " +
                                      "side lengths of a triangle:");

                    Console.WriteLine("What's the first length?");
                    string strside1 = Console.ReadLine();
                    double intside1 = double.Parse(strside1);

                    Console.WriteLine("What's the second length?");
                    string strside2 = Console.ReadLine();
                    double intside2 = double.Parse(strside2);

                    Console.WriteLine("What's the third length?");
                    string strside3 = Console.ReadLine();
                    double intside3 = double.Parse(strside3);

                    double halfCircumference = (intside1 + intside2 + intside3) / 2;
                    double triangleAreaBeforeSqRt = (halfCircumference * (halfCircumference - intside1) *
                                                     (halfCircumference - intside2) *
                                                     (halfCircumference - intside3));
                    double triangleArea = Math.Sqrt(triangleAreaBeforeSqRt);
                    Console.WriteLine($"Half of the triangle circumference is {halfCircumference}");

                    // Part 3
                    Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

                    // Implementation here
                    Console.WriteLine($"The area is: {triangleArea}");

                    // Part 4
                    Console.WriteLine("\nPart 4, solving a quadratic equation.");
                    Console.WriteLine("In order to solve a quadratic equation, we need to know some coefficients," +
                                      "\nsuch as the values for a, b, c");
                    Console.WriteLine("First, what is the value of a:");
                    var a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Second, what is the value of b:");
                    var b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Finally, what is the value of c:");
                    var c = Convert.ToInt32(Console.ReadLine());

                    var d = b * b - 4 * a * c;
                    double x1, x2;
                    if (d == 0)
                    {
                        Console.Write("Both roots are equal.\n");
                        x1 = -b / (2.0 * a);
                        x2 = x1;
                        Console.Write($"First  Root Root1= {x1}\n");
                        Console.Write($"Second Root Root2= {x2}\n");
                    }
                    else if (d > 0)
                    {
                        Console.Write("Both roots are real and diff-2\n");

                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);

                        Console.Write($"First  Root Root1= {x1}\n");
                        Console.Write($"Second Root root2= {x2}\n");
                    }
                    else
                        Console.Write("Root are imaginary;\nNo Solution. \n\n");

                    Console.WriteLine("Would you like to try again? [Y] or [N]");
                    var tryAgainResponse = Console.ReadLine();
                    var upperCaseResponse = tryAgainResponse.ToUpper();
                    if (upperCaseResponse == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine("Thanks for wanting to continue!");
                        tryAgain = true;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                    }
                }
            } while (tryAgain == true);
        }
    }
}