using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            while (i > 0 )
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine(i);
            i = i--;

        }
    }
}