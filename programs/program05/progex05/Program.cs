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


            Console.WriteLine("Part 1: count, sum, mean arrays.");
            printArray(arrayA);
            printArray(arrayB);
            printArray(arrayC);

            Console.WriteLine("\nPart 2: reverse arrays.");
            Console.WriteLine("Array A Reversed");
            printReverseArray(arrayA);
            Console.WriteLine("\nArray B Reversed");
            printReverseArray(arrayB);
            Console.WriteLine("\nArray C Reversed");
            printReverseArray(arrayC);

            Console.WriteLine("\nPart 3: rotate arrays.");
            Console.WriteLine("Array A rotated");
            printRotatedArray(arrayA, 6);
            rightRotateByTwo(array, 2, 7);
            printRotatedArray(array, 7);

        }

        static void printArray(int [] array)
        {
            var countArray = array.Count();
            var sumArray = array.Sum();
            var meanArray = sumArray / countArray;
            Console.Write(" Array Count is: " + countArray);
            Console.Write(" Array Sum is: " + sumArray);
            Console.Write(" Array Mean is: " + meanArray);
            Console.WriteLine();
        }

        static void printReverseArray(int [] temp)
        {
            Array.Reverse(temp);
            foreach (var i in temp)
            {
                Console.Write(i + " ");
            }
        }




        //static void rotateArray(int[] array, int d, int n)
        //{
        //    for (int i = 0; i < d; i++)
        //    {
        //        rightRotateByTwo(array, n);
        //    }
           
        //}

        //static void rightRotateByTwo(int[] array, int n)
        //{
        //    int i, temp = array[0];
        //    for (int i = 0; i < n +2; i++)
        //    {
        //        array[1] = array[i + 2];

        //        array[i] = temp;
        //    }
        //}
        //static void printRotatedArray(int[] array, int size)
        //{
        //    for (int i = 0; i < size; i++)
        //        Console.Write(array[i] + " ");
        //}

        // Driver code 

    }
    //2:15

    //static void printArray(int[] arrayName)
    //{
    //    string ExampleFunction(int[] arrayName)
    //    {
    //        //Construct your log statement using c# 6.0 string interpolation
    //        return $"Error occurred in {arrayName}";
    //    }
    //    var convert
    //    string whatIsNameOfArray = ExampleFunction(nameof(arrayName));
    //    Console.WriteLine(whatIsNameOfArray);
    //    Console.WriteLine("[{0}]", string.Join(", ", arrayName));
    //}


}


