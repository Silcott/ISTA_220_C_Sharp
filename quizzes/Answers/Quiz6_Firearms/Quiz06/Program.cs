// Name: James Silcott
// Date: 11 August 2020
// File: Quiz06-Silcott.cs


using System;

namespace Quiz06
{
    class Program
    {
        static void doWork()
        {
            Firearm myFirearm = new Firearm();
            myFirearm.typeOfFirearm();
            myFirearm.actionOfFirearm("shoot things");

            Shotgun myShotgun = new Shotgun();
            myShotgun.typeOfFirearm();
            myShotgun.actionOfFirearm("go Boom");

            Rifle myRifle = new Rifle();
            myRifle.typeOfFirearm();
            myRifle.actionOfFirearm("go Bang");

            Pistol myPistol = new Pistol();
            myPistol.typeOfFirearm();
            myPistol.actionOfFirearm("go Pop");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz 6");
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.ReadLine();
        }


    }
    class Firearm
    {
        public virtual void typeOfFirearm()
        {
            Console.Write($"I am a firearm ");
        }
        public void actionOfFirearm(string action)
        {
            Console.Write($"and I {action}\n");
        }

    }
    class Shotgun : Firearm
    {
        public override void typeOfFirearm()
        {
            Console.Write("I am a Shotgun ");
        }
    }
    class Rifle : Firearm
    {
        public override void typeOfFirearm()
        {
            Console.Write("I am a Rifle ");
        }
    }
    class Pistol : Firearm
    {
        public override void typeOfFirearm()
        {
            Console.Write("I am a Pistol ");
        }
    }
}


//Quiz 06 — Inheritance
//C# Programming
//Create a Firearm base class with one method, a void method that prints a message to console.Then create
//three derived classes, a Shotgun class, a Rifle class, and a Pistol class.In your main program, instantiate four
//objects, one of each class, a Firearm instance, a Shotgun instance, a Rifle instance, and a Pistol instance.Put
//your Program class and your other classes in the same file.In other words, use this template:

//Here is the expected output.
//This is C Sharp quiz 6.
//I am a firearm and I shoot things.
//I am a shotgun and I go Boom.
//I am a rifle and I go Bang.
//I am a pistol and I go Pop.
//Press any key to continue .
