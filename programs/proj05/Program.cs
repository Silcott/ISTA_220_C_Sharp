//Name: James Silcott
//Date: 10 Aug 2020


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

            Console.WriteLine(arrayA);
            Console.WriteLine(arrayB);
            Console.WriteLine(arrayC);

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
            printRotatedArray(arrayA, 3);
            printRotatedArray(arrayB, 3);
            printRotatedArray(arrayC, 3);

            Console.WriteLine("\nPart 4: sort arrays.");
            Console.WriteLine("Array A sorted");
            SortArray(arrayA);
            SortArray(arrayB);
            SortArray(arrayC);

            Console.ReadLine();



        }

        static void printArray(int[] array)
        {
            var countArray = array.Count();
            var sumArray = array.Sum();
            var meanArray = sumArray / countArray;
            Console.Write(" Array Count is: " + countArray);
            Console.Write(" Array Sum is: " + sumArray);
            Console.Write(" Array Mean is: " + meanArray);
            Console.WriteLine();
        }

        static void printReverseArray(int[] temp)
        {
            Array.Reverse(temp);
            foreach (var i in temp)
            {
                Console.Write(i + " ");
            }
        }

        static void printRotatedArray(int[] array, int places)
        {
            var temp = array[0];
            int len = array.Length;
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
                array[array.Length - 1] = temp;
                Console.Write(String.Join($" , ", array[(i + places) % len]));
            }
        }
        
        private static void SortArray(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int e in array)
            {
                Console.Write($"{e} ");
                
            }
            Console.WriteLine();

        }


    }

}


