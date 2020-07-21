using System;

namespace ISTA220Quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is C Sharp quiz 2.");
            Console.Write("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is {sum}");
        }
        private static int GetSums(int start, int end, int sum)
        {
            Console.WriteLine($"The sum of {sum} and {start} is {sum + start}");
            if (end <= 0)
                return sum;
            else
                return GetSums(start + sum, --end, ++sum);
        }
    }
}
//Sample output
//This is C Sharp quiz 2.
//Please enter the number of integers to add: 10
//The sum of 0 and 0 is 0
//The sum of 1 and 0 is 1
//The sum of 2 and 1 is 3
//The sum of 3 and 3 is 6
//The sum of 4 and 6 is 10
//The sum of 5 and 10 is 15
//The sum of 6 and 15 is 21
//The sum of 7 and 21 is 28
//The sum of 8 and 28 is 36
//The sum of 9 and 36 is 45
//The sum of 10 and 45 is 55
//the sum is 55
//Press any key to continue