using System;
using System.Net.WebSockets;

namespace ISTA220Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1 , sum 10 numbers. ");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers. ");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3 , average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");


            Console.WriteLine("\nPart 4, average non−predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }
        static char ConvertNumericToLetterGrade(double grade)
        {
                char letterGrade = ' ';
                if (grade > 89)
                    letterGrade = 'A';
                else
                    if (grade > 79)
                    letterGrade = 'B';
                else
                        if (grade > 69)
                    letterGrade = 'C';
                else
                            if (grade > 59)
                    letterGrade = 'D';
                else
                                if (grade <= 59)
                    letterGrade = 'F';
                return letterGrade;
        }
        static double AvgAnyInts(int sum, int count)
        {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return AvgAnyInts(sum, count);
                else
                    return sum / 10.0;
        }


        static double AvgUnkInts(int sum, int count, int numScores)
        {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return AvgUnkInts(sum, count, numScores);
                else
                    return sum / 10.0;
        }



        static double AvgTenInts(int sum, int count)
        {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return SumTenInts(sum, count);
                else
                    return sum / 10.0;
        }
        static int SumTenInts(int sum, int count)
        {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return SumTenInts(sum, count);
                else
                    return sum;
        }

        
    }
}


