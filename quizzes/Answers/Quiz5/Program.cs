using System;

namespace GFG
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz 05");
            string quiz = "I think, therefore I am";
            Console.WriteLine($"The quiz string is [{quiz}].");
            string[] quizArray = quiz.Split(" ");
            int lengthOfArray = quizArray.Length;
            Console.WriteLine($"Length of the string array is {lengthOfArray}");

            for (int i = lengthOfArray - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i} {quizArray[i]}");
            }

        }
    }
}