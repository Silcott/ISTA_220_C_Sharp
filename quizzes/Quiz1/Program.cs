using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 1.");
            Console.WriteLine("PART 1");
            Console.WriteLine("MM         MM  SSSSSSSS  SSSSSSSS     AAAAAA\n" +
                              "MMM       MMM  SSSSSSSS  SSSSSSSS     AA  AA\n" +
                              "MMMM     MMMM  SS        SS          AA    AA\n" +
                              "MM MM  MM  MM  SS        SS          AA    AA\n" +
                              "MM  MMMM   MM  SSSSSSSS  SSSSSSSS    AAAAAAAA\n" +
                              "MM   MM    MM  SSSSSSSS  SSSSSSSS    AAAAAAAAA\n" +
                              "MM         MM        SS        SS   AA       AA\n" +
                              "MM         MM        SS        SS   AA       AA\n" +
                              "MM         MM  SSSSSSSS  SSSSSSSS   AA       AA\n" +
                              "MM         MM  SSSSSSSS  SSSSSSSS   AA       AA\n" +
                              "");

            Console.WriteLine("PART 2");
            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"phi is {phi}");
        }
    }
}