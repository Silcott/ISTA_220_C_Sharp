using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a number to count down from");
            int numberChosen = Convert.ToInt32(Console.ReadLine());

            int i = numberChosen;
            while (i > 0 )
            {
                Console.WriteLine(i);
                i--;
            }


        }
    }
}