using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace progex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //card info
            //int cards[] = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51 };
            //int length = cards.Length;//shows the length
            //int value = (cards[i] % 13);//gets the value of the card
            //int suit = (cards[i] / 4);//gets the suit of the card
            //var nextCard = Random.Next(length);//gives a random integer between 0 and 51 the first time
            //cards.RemoveAt(nextCard);//Delete method removes and returns the argument and reduces the size opf teh array by one




            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            double avg = 0.0;

            Console.WriteLine("Part 0, Print the Arrays.");
            printArray(arrayA);
            printArray(arrayB);
            printArray(arrayC);



        }

        static void printArray(int[] arrayName)
        {
            string ExampleFunction(int[] arrayName)
            {
                //Construct your log statement using c# 6.0 string interpolation
                return $"Error occurred in {arrayName}";
            }
            var convert
            string whatIsNameOfArray = ExampleFunction(nameof(arrayName));
            Console.WriteLine(whatIsNameOfArray);
            Console.WriteLine("[{0}]", string.Join(", ", arrayName));
        }
        

    }

}
