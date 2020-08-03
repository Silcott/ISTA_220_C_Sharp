using System;

namespace Quiz4
{
    class Firearm
    {
        public void fire(string name, string noise)
        {
            Console.WriteLine($"I am a {name} and I go {noise}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Charp quiz 4");
            Firearm shotgun = new Firearm();
            shotgun.fire("shotgun", "boom");
            Firearm rifle = new Firearm();
            rifle.fire("rifle", "Bang");
            Firearm pistol = new Firearm();
            pistol.fire("pistol", "Pop");

        }
    }
}
