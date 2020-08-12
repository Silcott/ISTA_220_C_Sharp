using System;


namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is lab 11");
            Console.WriteLine(Util.Sum(1,2,3,4,5,6,7,8,9,10));
            //Console.WriteLine("Using Parameter Array");
            Console.WriteLine(Util.Sum(1));
            Console.WriteLine(Util.Sum(1,3));
            Console.WriteLine(Util.Sum(1,3,5));
            Console.WriteLine(Util.Sum(1,3,5,7));
            Console.WriteLine(Util.Sum(1,3,5,7,9));

            Console.WriteLine("===============================================");

            Util james = new Util();//returns a memory address, new object reference
            Console.WriteLine(james.Total(5,8));



            Console.ReadLine();
        }

        static void Main()
        {
            
                doWork();
            
        }
    }
}
