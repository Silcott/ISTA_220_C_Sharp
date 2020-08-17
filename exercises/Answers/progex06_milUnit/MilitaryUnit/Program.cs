using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgainResponse = "Y";
            while (tryAgainResponse == "Y") 
            {
                Intro();
                int introSelection;
                void Intro()
                {
                    Console.WriteLine("Choose Which World War: [1] or [2]");
                    Console.WriteLine("1. World War I - 1914 to 1918");
                    Console.WriteLine("2. World War II - 1939 to 1945");
                    string response = Console.ReadLine();
                    int number;

                    //convert string response to integer
                    if (int.TryParse(response, out number))
                    {
                        // string interpolation expression
                        Console.WriteLine("You selected: {0}", number);
                        
                        //if number is greater than 2, clear and replay intro
                        if (number == 2)
                        {
                            TankSelectionWW2();
                        }
                        else if (number == 1)
                        {
                            TankSelectionWW1();
                        }
                        else

                        {
                            Console.Clear();
                            Intro();
                        }
                    }
                    //if the response is anything other than a number
                    else
                    {
                        Console.WriteLine("You typed: {0}", response);
                        Console.WriteLine("Incorrect Response Format, Try Again:");
                        Console.WriteLine("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                    introSelection = number;
                }

                //Names of World War ONE tanks
                var tank1WW1 = "British Marks I-V Male";
                var tank2WW1 = "British Medium Mark A “Whippet";
                var tank3WW1 = "German A7V Sturmpanzerwagen";
                var tank4WW1 = "French Schneider M.16 CA1";
                var tank5WW1 = "French Light Renault FT17";

                //Names of World War TWO tanks
                var tank1WW2 = "Comet IA 34 (Britain)";
                var tank2WW2 = "Tiger I (Germany";
                var tank3WW2 = "IS 2 Iosif Stalin Tank (Soviet Union)";
                var tank4WW2 = "M26 Pershing Tank (United States)";
                var tank5WW2 = "Jagdpanther (Germany)";

                while (tryAgainResponse == "Y")
                {
                    if (introSelection == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Here are the Top 5 Tanks from WORLD WAR 1 ERA");
                        Console.WriteLine(tank1WW1);
                        Console.WriteLine(tank2WW1);
                        Console.WriteLine(tank3WW1);
                        Console.WriteLine(tank4WW1);
                        Console.WriteLine(tank5WW1);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Here are the Top 5 Tanks from WORLD WAR 2 ERA");
                        Console.WriteLine(tank1WW2);
                        Console.WriteLine(tank2WW2);
                        Console.WriteLine(tank3WW2);
                        Console.WriteLine(tank4WW2);
                        Console.WriteLine(tank5WW2);
                        Console.WriteLine();
                    }
                }

                void SelectionCategories()
                {
                    Console.WriteLine("Choose what to Learn: [1], [2], [3], [4] or [5]");
                    Console.WriteLine("1. Firepower");
                    Console.WriteLine("2. Speed");
                    Console.WriteLine("3. Distance");
                    Console.WriteLine("4. Armour");
                    Console.WriteLine("5. Crew Size");
                }
                //WW1 TANK METHOD
                void TankSelectionWW1()
                {
                    int number;
                    Console.Clear();
                    SelectionCategories();
                    string response = Console.ReadLine();

                    //convert string response to integer
                    if (Int32.TryParse(response, out number))
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("You selected: {0}: " + "Firepower", number);
                                TankFirepowerWW1();
                                break;
                            case 2:
                                Console.WriteLine("You selected: {0}: " + "Speed", number);
                                TankSpeedWW1();
                                break;
                            case 3:
                                Console.WriteLine("You selected: {0}: " + "Distance", number);
                                TankDistanceWW1();
                                break;
                            case 4:
                                Console.WriteLine("You selected: {0}: " + "Armour", number);
                                TankArmourWW1();
                                break;
                            case 5:
                                Console.WriteLine("You selected: {0}: " + "Crew Size", number);
                                TankCrewSizeWW1();
                                break;
                        }
                        //if number is greater than 5, clear and replay intro
                        if (number > 5)
                        {
                            Console.Clear();
                            Intro();
                        }
                    }
                    //if the response is anything other than a number
                    else
                    {
                        Console.WriteLine("You typed: {0}", response);
                        Console.WriteLine("Incorrect Response Format, Try Again:");
                        Console.WriteLine("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                    TryAgain();
                }
                //WW2 TANK METHOD
                void TankSelectionWW2()
                {
                    int number;
                    Console.Clear();
                    SelectionCategories();
                    string response = Console.ReadLine();

                    //convert string response to integer
                    if (Int32.TryParse(response, out number))
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("You selected: {0}: " + "Firepower", number);
                                TankFirepowerWW2();
                                break;
                            case 2:
                                Console.WriteLine("You selected: {0}: " + "Speed", number);
                                TankSpeedWW2();
                                break;
                            case 3:
                                Console.WriteLine("You selected: {0}: " + "Distance", number);
                                TankDistanceWW2();
                                break;
                            case 4:
                                Console.WriteLine("You selected: {0}: " + "Armour", number);
                                TankArmourWW2();
                                break;
                            case 5:
                                Console.WriteLine("You selected: {0}: " + "Crew Size", number);
                                TankCrewSizeWW2();
                                break;
                        }
                        //if number is greater than 5, clear and replay intro
                        if (number > 5)
                        {
                            Console.Clear();
                            Intro();
                        }
                    }
                    //if the response is anything other than a number
                    else
                    {
                        Console.WriteLine("You typed: {0}", response);
                        Console.WriteLine("Incorrect Response Format, Try Again:");
                        Console.WriteLine("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                    TryAgain();
                }
                void TryAgain()
                {
                    Console.WriteLine("Want to play again? [Y] or [N]");
                    var response = Console.ReadLine();
                    var responseUpper = response.ToUpper();
                    if (responseUpper == "Y")
                    {
                        Console.Clear();
                        Intro();
                    }
                    else if (responseUpper == "N")
                    {
                        Console.Clear();
                        tryAgainResponse = "N";
                        Console.WriteLine("Have a nice day!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, Try Again");
                        TryAgain();
                    }
                }
            };

            #region WORLD WAR 1 TANKS CLASS CALLS
            void TankFirepowerWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.firepower("a mounted large-calibre cannon called tank gun in a rotating gun turret supplemented by mounted machine guns or other weapons such as anti-tank guided missiles or rockets");
                Console.WriteLine();

                MarksIVMale myMarksIVMale = new MarksIVMale();
                myMarksIVMale.typeoftank();
                myMarksIVMale.firepower("two six pounder naval guns");
                Console.WriteLine();

                Whippet myWhippet = new Whippet();
                myWhippet.typeoftank();
                myWhippet.firepower("four 0.303-inch Hotchkiss Mk 1 machine guns, one covering each direction");
                Console.WriteLine();

                Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
                mySturmpanzerwagen.typeoftank();
                mySturmpanzerwagen.firepower("six 7.92 mm MG08 machine guns and a 5.7 cm Maxim-Nordenfelt cannon mounted at the front");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                mySchneider.firepower("a short 75 mm cannon, in a sponson on the right side. By later standards it would therefore have been an assault gun instead of a tank");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myRenault.firepower("a fully rotating turret, a Hotchkiss 8mm machine gun and a small cannon, the 37mm Puteaux gun.");
            }
            void TankSpeedWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.speed("3.7 mph");
                Console.WriteLine();

                MarksIVMale myMarksIVMale = new MarksIVMale();
                myMarksIVMale.typeoftank();
                myTankWW1.speed("4 mph");
                Console.WriteLine();

                Whippet myWhippet = new Whippet();
                myWhippet.typeoftank();
                myTankWW1.speed("30 mph");
                Console.WriteLine();

                Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
                mySturmpanzerwagen.typeoftank();
                myTankWW1.speed("9.3 mph");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                myTankWW1.speed("5 mph");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myTankWW1.speed("4.5 mph");
            }
            void TankDistanceWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.distance("80 miles");
                Console.WriteLine();

                MarksIVMale myMarksIVMale = new MarksIVMale();
                myMarksIVMale.typeoftank();
                myTankWW1.distance("35 miles");
                Console.WriteLine();

                Whippet myWhippet = new Whippet();
                myWhippet.typeoftank();
                myTankWW1.distance("23.6 miles");
                Console.WriteLine();

                Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
                mySturmpanzerwagen.typeoftank();
                myTankWW1.distance("50 miles");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                myTankWW1.distance("49.7 miles");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myTankWW1.distance("30 miles");
            }
            void TankArmourWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.armour("12 mm");
                Console.WriteLine();

                MarksIVMale myMarksIVMale = new MarksIVMale();
                myMarksIVMale.typeoftank();
                myTankWW1.armour("12 mm");
                Console.WriteLine();

                Whippet myWhippet = new Whippet();
                myWhippet.typeoftank();
                myTankWW1.armour("14 mm");
                Console.WriteLine();

                Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
                mySturmpanzerwagen.typeoftank();
                myTankWW1.armour("30 mm front 20 mm sides");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                myTankWW1.armour("22.8 mm");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myTankWW1.armour("22 mm");
            }
            void TankCrewSizeWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.crewSize("8 (commander/brakesman, driver, two gearsmen and four gunners)");
                Console.WriteLine();

                MarksIVMale myMarksIVMale = new MarksIVMale();
                myMarksIVMale.typeoftank();
                myTankWW1.crewSize("8");
                Console.WriteLine();

                Whippet myWhippet = new Whippet();
                myWhippet.typeoftank();
                myTankWW1.crewSize("3");
                Console.WriteLine();

                Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
                mySturmpanzerwagen.typeoftank();
                myTankWW1.crewSize("A minimum of 18");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                myTankWW1.crewSize("4");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myTankWW1.crewSize("2 (commander, driver)");
            }
            #endregion

            #region WORLD WAR 2 TANKS CLASS CALLS
            void TankFirepowerWW2()
            {
                TankWW2 myTankWW2 = new TankWW2();
                myTankWW2.typeoftank();
                myTankWW2.firepower("88-mm guns");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myComet.firepower("mounted the new 17 pdr High Velocity (HV) (3 inch; 76.2 mm – sometimes referred to as 77  mm) gun, in a lower profile, partly-cast turret");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTiger.firepower("first armoured fighting vehicle that mounted the 8.8 cm KwK 36 gun (derived from the 8.8 cm Flak 36)");
                Console.WriteLine();

                Stalin myStalin = new Stalin();
                myStalin.typeoftank();
                myStalin.firepower("long-barrelled 85 mm cannon (D-5T-85-BM)");
                Console.WriteLine();

                Pershing myPershing = new Pershing();
                myPershing.typeoftank();
                myPershing.firepower("90 mm Gun M3 70 rounds");
                Console.WriteLine();

                Jagdpanther myJagdpanther = new Jagdpanther();
                myJagdpanther.typeoftank();
                myJagdpanther.firepower("7.5 cm Pak 39 L/48 gun");
            }
            void TankSpeedWW2()
            {
                TankWW2 myTankWW2 = new TankWW2();
                myTankWW2.typeoftank();
                myTankWW2.speed("45 mph");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myTankWW2.speed("32 mph");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTankWW2.speed("28.2 mph");
                Console.WriteLine();

                Stalin myStalin = new Stalin();
                myStalin.typeoftank();
                myTankWW2.speed("23 mph");
                Console.WriteLine();

                Pershing myPershing = new Pershing();
                myPershing.typeoftank();
                myTankWW2.speed("25 mph");
                Console.WriteLine();

                Jagdpanther myJagdpanther = new Jagdpanther();
                myJagdpanther.typeoftank();
                myTankWW2.speed("28.6 mph");
            }
            void TankDistanceWW2()
            {
                TankWW2 myTankWW2 = new TankWW2();
                myTankWW2.typeoftank();
                myTankWW2.distance("29 miles");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myTankWW2.distance("170 miles");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTankWW2.distance("121 miles");
                Console.WriteLine();

                Stalin myStalin = new Stalin();
                myStalin.typeoftank();
                myTankWW2.distance("150 miles");
                Console.WriteLine();

                Pershing myPershing = new Pershing();
                myPershing.typeoftank();
                myTankWW2.distance("100 miles");
                Console.WriteLine();

                Jagdpanther myJagdpanther = new Jagdpanther();
                myJagdpanther.typeoftank();
                myTankWW2.distance("99 miles");
            }
            void TankArmourWW2()
            {
                TankWW1 myTankWW2 = new TankWW1();
                myTankWW2.typeoftank();
                myTankWW2.armour("85 mm");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myTankWW2.armour("102 mm");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTankWW2.armour("120 mm");
                Console.WriteLine();

                Stalin myStalin = new Stalin();
                myStalin.typeoftank();
                myTankWW2.armour("120 mm");
                Console.WriteLine();

                Pershing myPershing = new Pershing();
                myPershing.typeoftank();
                myTankWW2.armour("102 mm");
                Console.WriteLine();

                Jagdpanther myJagdpanther = new Jagdpanther();
                myJagdpanther.typeoftank();
                myTankWW2.armour("100 mm");
            }
            void TankCrewSizeWW2()
            {
                TankWW1 myTankWW2 = new TankWW1();
                myTankWW2.typeoftank();
                myTankWW2.crewSize("5 crew members (commander, gunner, loader, driver and co-driver)");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myTankWW2.crewSize("5");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTankWW2.crewSize("5");
                Console.WriteLine();

                Stalin myStalin = new Stalin();
                myStalin.typeoftank();
                myTankWW2.crewSize("4");
                Console.WriteLine();

                Pershing myPershing = new Pershing();
                myPershing.typeoftank();
                myTankWW2.crewSize("5");
                Console.WriteLine();

                Jagdpanther myJagdpanther = new Jagdpanther();
                myJagdpanther.typeoftank();
                myTankWW2.crewSize("5");
            }
            #endregion
        }
    }
    #region WORLD WAR 1 CLASSES
    class TankWW1
    {
        public virtual void typeoftank()
        {
            Console.Write($"I am a World War 1 Tank");
        }
        public void firepower(string action)
        {
            Console.Write($" and armed with: {action}\n");
        }
        public void speed(string speed)
        {
            Console.Write($" and have a max speed of: {speed}\n");
        }
        public void distance(string distance)
        {
            Console.Write($" and a range of: {distance}\n");
        }
        public void armour(string action)
        {
            Console.Write($" and armour thickness of: {action}\n");
        }
        public void crewSize(string action)
        {
            Console.Write($" and a crew size of: {action}\n");
        }
    }
    class MarksIVMale : TankWW1
    {
        public override void typeoftank()
        {
            Console.Write("I am a British Marks I-V Male");
        }
    }
    class Whippet : TankWW1
    {
        public override void typeoftank()
        {
            Console.Write("I am a British Medium Mark A “Whippet");
        }
    }
    class Sturmpanzerwagen : TankWW1
    {
        public override void typeoftank()
        {
            Console.Write("I am a German A7V Sturmpanzerwagen");
        }
    }
    class Schneider : TankWW1
    {
        public override void typeoftank()
        {
            Console.Write("I am a French Schneider M.16 CA1");
        }
    }
    class Renault : TankWW1
    {
        public override void typeoftank()
        {
            Console.Write("I am a French Light Renault FT17");
        }
    }
    #endregion

    #region WORLD WAR 2 CLASSES
    class TankWW2
    {
        public virtual void typeoftank()
        {
            Console.Write($"I am a World War 2 Tank");
        }
        public void firepower(string action)
        {
            Console.Write($" and armed with: {action}\n");
        }
        public void speed(string speed)
        {
            Console.Write($" and have a max speed of: {speed}\n");
        }
        public void distance(string distance)
        {
            Console.Write($" and a range of: {distance}\n");
        }
        public void armour(string action)
        {
            Console.Write($" and armour thickness of: {action}\n");
        }
        public void crewSize(string action)
        {
            Console.Write($" and a crew size of: {action}\n");
        }
    }
    class Comet : TankWW2
    {
        public override void typeoftank()
        {
            Console.Write("I am a Comet IA 34 (Britain)");
        }
    }
    class Tiger : TankWW2
    {
        public override void typeoftank()
        {
            Console.Write("I am a Tiger I (Germany)");
        }
    }
    class Stalin : TankWW2
    {
        public override void typeoftank()
        {
            Console.Write("I am a IS 2 Iosif Stalin Tank (Soviet Union)");
        }
    }
    class Pershing : TankWW2
    {
        public override void typeoftank()
        {
            Console.Write("I am a M26 Pershing Tank (United States)");
        }
    }
    class Jagdpanther : TankWW2
    {
        public override void typeoftank()
        {
            Console.Write("I am a Jagdpanther (Germany)");
        }
    }
    #endregion
}

#region NOTES
//var tank1WW1 = "British Marks I-V Male";
//var tank2WW1 = "British Medium Mark A “Whippet";
//var tank3WW1 = "German A7V Sturmpanzerwagen";
//var tank4WW1 = "French Schneider M.16 CA1";
//var tank5WW1 = "French Light Renault FT17";




//Programming Exercise 06
//Military Unit (Implementing Inheritance)
//C# Step by Step
//This activity consists of four programming exercises. The following exercises are open book and open note.
//You are free to use any written documentation you wish. However, these are individual exercises, and you
//cannot consult with each other in writing your programs.
//This programming exercise has four parts consisting of four requirements. The grade for each requirement
//is indicated, for a maximum of 100 points. You have two options for the first part. Select one. At a minimum,
//your program must compile successfully and run.
//Using inheritance, abstraction, classes and objects, implement a military unit. Create super or abstract
//classes representing several components of a military unit. Examples might include personnel, weapons, equipment, vehicles, missions, etc. Each parent class should be subclassed several times. Thinking about test first
//development, you may want to write the main program first, before you create any other classes or objects. That
//way, you can create classes with the appropriate properties and methods, and instantiate objects as needed to
//carry out the mission.
//First part: 70 points Choose one option.
//Option 1, main class first Write your main class first. This will consist of your variables and methods
//that execute the mission of your unit. Since you have not built your unit, you cannot actually run the program,
//so you will have to supply your methods with appropriate print statements to have your programn run to
//completion.
//Option 2, parent classes first Write your parent classes first. These will be the classes you will subclass
//to create the appropriate objects. For example, you might have a personnel class, a weapons class, a missions
//class, and a vehicles class.
//Second part: 80 points If you chose to implement Option 1 in the first part, implement Option 2 in
//in this part. If you chose to implement Option 2 in the first part, in this part, implement the appropriate
//subclasses. For example, if one of your parent classes is Weapon, in this class you may elect to implement
//SmallCaliberWeapon, IndirectFireWeapon, and DirectFireWeapon.
//Third part: 90 points If you chose to implement Option 2 in the first part, in this part implement the
//appropriate methods as virtual and overidden methods, or use another suitable technique. As an example, if
//you have a method named mount(), it will exhibit different behavior depending on whether it’s called on a type
//RifleSight or a type Helicopter. As another example, if you have a method named load(), it will exhibit
//different behavior depending on whether it’s called on a type AutomaticWeapon or a type Howitzer. Otherwise,
//implement your subclasses.
//Fourth part: 100 points If you chose to implement Option 2 in the first part, in this part implement
//Option 1 in this part. Otherwise, implement the methods as instructed for the third part.
//Note that you may chose to implement the main class first and the data type classes second, or the data
//type classes first and the main class second. In both cases, you need a main class to instantiate objects of the
//data types you create and exercise the methods of those data types. Generally most developers will implement
//the data types first and the main class second. Doing it the other way is part of a discipline called test driven
//development, and is associated with agile techniques. Regardless of what you choose, you should be familiar
//with both processes.
#endregion