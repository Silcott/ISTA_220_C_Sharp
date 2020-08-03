using System;//using namespace system

namespace Parameters//creates namespace
{
    class Pass//creates calss named Pass
    {
        public static void Value(int param)//declares a class method 
        {//allocates a block of memory to the stack
            Console.WriteLine($"    In method value param is {param}");
            param = 42;//assigns value 42 to param, this is a value type 
            Console.WriteLine($"    In method value param is now {param}");

        }

        public static void Value2(ref int param)//declares a class method 
        {//allocates a block of memory to the stack
            Console.WriteLine($"    In method value2 param is {param}");
            param = 42;//assigns value 42 to param, this is a value type 
            Console.WriteLine($"    In method value2 param is now {param}");

        }
        public static void Reference(WrappedInt param)//contains memory address
        {
            Console.WriteLine($"    In method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"    In method Reference param is now {param}");
        }//deallocates everythoigna nd everything goes away
    }
}
