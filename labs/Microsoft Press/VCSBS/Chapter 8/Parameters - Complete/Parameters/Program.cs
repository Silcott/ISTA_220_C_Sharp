#region using directives

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#endregion

namespace Parameters//use class as a namespace
{
    class Program
    {
        static void doWork()//declares method, private method by default
        {
            int i = 0;//value type
            Console.WriteLine($"In part 1: i is {i}");//display 'i' in console
            Pass.Value(i);//call a calss method named value passin 'i' 
            Console.WriteLine($"In part 1 i is still {i}");
            Console.WriteLine("===========================");

            WrappedInt wi = new WrappedInt();//wi is assigned a memory address
            Console.WriteLine($"in part 2 ei.number is {wi.Number}");
            Pass.Reference(wi);//call class method named Reference and pass it 'wi' and passes the address
            Console.WriteLine($"in part 2 ei.number is now {wi.Number}");
            var wiAddress = Marshal.StringToCoTaskMemUni(wi);
            Console.WriteLine($"the address of wi is: {wiAddress}");
            Console.WriteLine("===========================");

            Console.WriteLine($"In part 3: i is {i}");//display 'i' in console
            Pass.Value2(ref i);//call a class method named value passin 'i' 
            Console.WriteLine($"In part 3 i is still {i}");
            Console.WriteLine("===========================");

            Console.ReadLine();
        }

        static void Main(string[] args)//main entry point static means makes it a class method
        {
            try
            {
                doWork();//calls method
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
