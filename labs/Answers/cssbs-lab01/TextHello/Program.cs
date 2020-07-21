using System;

namespace TextHello //namespace is an object
{ //curly bracket or braces
    public class Program //public, protected, or private -
                         //a class is a blueprint or design -
                         //Program is the name of the class
    { //saves the stack that is higher and allocates a new stack
        public static void Main(string[] args) //added public but doesn't need it -
                                        //static line - pulls the shoot for you and you can only have one
                                        //void - returns nothing
                                        //Main is the name and it can be anything, unless
                                        //you dont have a Main method already
                                        //parameter list, args is the name of the parameter (just a name)
                                        //
        {
            string appelation; //declares a variable of a type string which is named name
            System.Console.Write("Enter your name: "); //System is the namespace
                                                      //Console is the class
            appelation = System.Console.ReadLine(); //Readline method reads the line and belongs to Console Class
            System.Console.WriteLine($"Hello, {appelation}"); //Calls writeline method
                                                              //$ means string interpulation
            Console.ReadLine();
        }//this de-allocates and whatever is on the top level is restored


    }//this de-allocates and whatever is on the top level is restored
}//this is de-allocated but nothing is higher sot he program terminates
