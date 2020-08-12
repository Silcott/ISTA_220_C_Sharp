// Name: James Silcott
// Date: 6 August 2020
// File: Quiz6-Silcott


using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Quiz6_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deck = {
                "two of Clubs", "three of Clubs", "four of Clubs", "five of Clubs",
                "six of Clubs", "seven of Clubs", "eight of Clubs", "nine of Clubs",
                "ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
                "Ace of Clubs", "two of Diamonds", "three of Diamonds",
                "four of Diamonds", "five of Diamonds", "six of Diamonds",
                "seven of Diamonds", "eight of Diamonds", "nine of Diamonds",
                "ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds",
                "King of Diamonds", "Ace of Diamonds", "two of Hearts", "three of Hearts",
                "four of Hearts", "five of Hearts", "six of Hearts", "seven of Hearts",
                "eight of Hearts", "nine of Hearts", "ten of Hearts", "Jack of Hearts",
                "Queen of Hearts", "King of Hearts", "Ace of Hearts", "two of Spades",
                "three of Spades", "four of Spades", "five of Spades", "six of Spades",
                "seven of Spades", "eight of Spades", "nine of Spades", "ten of Spades",
                "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Spades"
            };

            string[] playerDirection = {
                "North",
                "East",
                "South",
                "West"
            };
            void Shuffle()
            {
                var random = new Random();
                for (int i = 0; i < deck.Length; i++)
                {
                    int r = random.Next(i, deck.Length);
                    var temp = deck[i];
                    deck[i] = deck[r];
                    deck[r] = temp;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Shuffle();
                Console.WriteLine(playerDirection[i] + " was dealt:");
                Console.WriteLine(string.Join(", \n", deck.Skip(i % 13).Take(12)));
                Console.WriteLine(deck[i], ", \n");
                Console.WriteLine();
            }
            Console.WriteLine("All Done!");
            Console.ReadLine();
        }
    }
}




//PrintHand(4);
//PrintCard(52);

//static void PrintHand(int deck)
//{
//    if (deck % 4 == 0) Console.Write(" ~~North~~ ");
//    else if (deck % 4 == 0) Console.Write(" ~~West~~ ");
//    else if (deck % 4 == 0) Console.Write(" ~~South~~ ");
//    else if (deck % 4 == 0) Console.Write(" ~~East~~ ");
//    else Console.Write("ERROR in PrintHand()");

//}

//static void PrintCard(int i, string cr = " ")
//{
//    string[] value = {"two", "three", "four", "five", "six", "seven", "eight", "nine",
//                "ten", "Jack", "Queen", "King", "Ace"};
//    string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
//    string card = $"{value[i % 13]} of {suit[i / 13]}";
//    Console.Write($"{card}{cr} ");
//}





