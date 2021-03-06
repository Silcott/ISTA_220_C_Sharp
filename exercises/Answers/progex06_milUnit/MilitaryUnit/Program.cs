﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;

namespace MilitaryUnit
{
    class Program
    {
        //ASCII TEXT Art of USA Flag
        #region USA Flag ART
        static void ASCIIFlagArt()
        {
            //this sets varibales so I can divide the screen in half by pixels to center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            //Text Color Red
            void TextColorRed()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            //Text Color Gray
            void TextColorGray()
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //Background Black
            void BackColorBlack()
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            //Background Blue
            void BackColorBlue()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            //Background Red
            void BackColorRed()
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }

            //Background White
            void BackColorWhite()
            {
                Console.BackgroundColor = ConsoleColor.White;
            }

            //ASCII American Flag
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            Console.ResetColor();
        }
        #endregion

        //ASCII TEXT Art of a big tank
        #region TANK ASCII ART
        static void ASCIIArt()
        {
            //this sets varibales so I can divide the screen in half by pixels to center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((spaces.Remove(0, 18) + "                                                     _..----.._       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                                    ]_.--._____[      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                                  ___|'--'__..|--._      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                              __               \"\"\"    ;            :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                            ()_ \"\"\"\"---...__.'\"\"!\":  / ___       :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                               \"\"\"-- - ...__\\]..__] | /    [0]      :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                          \"\"\"!--./ / \"\"\"        :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                   __  ...._____;\"\"'.__________..--..:_       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                  /  !\"''''''!'''''''''' | '''' / ' ' ' ' \"--..__  __..      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                 /  /.--.    |          |  .'          \' ' '.\"\"--.{'.       "));
            Console.WriteLine((spaces.Remove(0, 18) + "             _...__            >=7 //.-.:    |          |.'             \\ ._.__  ' '\"\"'.      "));
            Console.WriteLine((spaces.Remove(0, 18) + "          .-' /    \"\"\"\"----..../ \"\">==7-.....:______    |                \\| |  \"\";.;-\" > \\       "));
            Console.WriteLine((spaces.Remove(0, 18) + "          \"\"\"\";           __..\".--\"/\"\"\"\"\"----....\"\"\"\"\"----.....H_______\\_!....'----\"\"\"\"]     "));
            Console.WriteLine((spaces.Remove(0, 18) + "        _..---|._ __..--\"\"       _!.-=_.            \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"                   ; \"\"\"       "));
            Console.WriteLine((spaces.Remove(0, 18) + "       /   .-\"; -.'--...___     .\" .-\"\"; '; \"\" - \"\" - ...^..__...-v.^ ___,  ,__v.__..--^\"--\"\"-v.^v,     "));
            Console.WriteLine((spaces.Remove(0, 18) + "      ;   ;   |'.         \"\"\" -/ ./; ; ;\\P.        ; ; \"\"\"\"____; ;.--\"\"\"\"// '\"\"<,      "));
            Console.WriteLine((spaces.Remove(0, 18) + "      ;   ;   | 1            ;  ;  '.: .'  ;<   ___.-'._.'------\"\"\"\"\"\"____'..'.--\"\"\"; ; '  o '; "));
            Console.WriteLine((spaces.Remove(0, 18) + "      '.   \\__:/__           ;  ;--\"\"()_   ;'  /___ .-\" ____-- - \"\"\"\"\"\"\" __.._ __._   '>.,  ,/;      "));
            Console.WriteLine((spaces.Remove(0, 18) + "        \\   \\    /\"\"\" < --...__; '_.-' /; \"\"; ;.'.'  \"-..'    \" -.      / \"/    `__. '.   \"-- - \";      "));
            Console.WriteLine((spaces.Remove(0, 18) + "         '.  'v ; ;     ;;    \\  \\ .'  \\ ; ////    _.-\" \"-._   ;    : ;   .-'__ '. ;   .^\".'     "));
            Console.WriteLine((spaces.Remove(0, 18) + "           '.  '; '.   .'/     '. `-.__.' /;;;   .o__.---.__o. ;    : ;   '\"\";;\"\"' ;v^\".^ "));
            Console.WriteLine((spaces.Remove(0, 18) + "             '-. '-.___.'<__v.^,v'.  '-.-' ;|:   '    :      ` ;v^v^'.'.    .;'.__/_..-'      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                '-...__.___...---\"\"'-.   '-'.;\\     'WW\\     .'_____..>.\" ^ \"-\"\"\"\"\"\"\"\"     "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                      '--..__ '\"._..'  '\"-;;\"\"\"       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                             \"\"\"-- - '\"\"\"\"\"\"     "));
            Console.WriteLine();
            Console.ResetColor();

        }
        #endregion

        //Start up screen with a timer
        #region TIMER
        static Timer timer = new Timer(1000);
        static int i = 9;

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //this sets varibales so I can divide the screen in half by pixels to center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            #region Tank Shooting Art
            //Create a list of strings
            List<string[]> TankArtShooting = new List<string[]>()
            { 
                //Expolsion 1
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "  __                                           \n",
                spaces.Remove(0, 0) + "|\"\"\"\\-=                                        \n",
                spaces.Remove(0, 0) + "(____)                                         \n",
                },
                //Expolsion 2
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "   _.                                          \n",
                spaces.Remove(0, 0) + " |\"\"\"\\-=                                       \n",
                spaces.Remove(0, 0) + " (____)                                        \n",
                },
                //Expolsion 3
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "    ,'                                         \n",
                spaces.Remove(0, 0) + "  |\"\"\"\\-=                                      \n",
                spaces.Remove(0, 0) + "  (____)                                       \n",
                },
                //Expolsion 4
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "     /_                                        \n",
                spaces.Remove(0, 0) + "   |\"\"\"\\-=                                     \n",
                spaces.Remove(0, 0) + "   (____)                                      \n",
                },
                //Expolsion 5
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "     |-._                                      \n",
                spaces.Remove(0, 0) + "    |\"\"\"\\-=                                    \n",
                spaces.Remove(0, 0) + "    (____)                                     \n",
                },
                //Expolsion 1
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "     \\;\":-                                     \n",
                spaces.Remove(0, 0) + "     |\"\"\"\\-=                                   \n",
                spaces.Remove(0, 0) + "     (____)                                    \n",
                },
                //Expolsion 6
                new string[]
                {
                spaces.Remove(0, 0) + "                                               \n",
                spaces.Remove(0, 0) + "      -;\":-                                    \n",
                spaces.Remove(0, 0) + "      \\| |                                     \n",
                spaces.Remove(0, 0) + "      |\"\"\"\\-=                                  \n",
                spaces.Remove(0, 0) + "      (____)                                   \n",
                },
                //Expolsion 7
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         | ;-                                  \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                spaces.Remove(0, 0) + "        (____)                                 \n",
                },
                //Expolsion 8
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         |'+                                   \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                spaces.Remove(0, 0) + "        (____)                                 \n",
                },
                //Expolsion 9
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         ^-^     __,-.                         \n",
                spaces.Remove(0, 0) + "        \\|_|    ( .`-')                        \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-= (_(_, _)                        \n",
                spaces.Remove(0, 0) + "        (____)   `--'                          \n",
                },
                //Expolsion 10
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         ^-^     __,-.                         \n",
                spaces.Remove(0, 0) + "        \\|_|    ( .`-')_.o                     \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-= (_(_, _)                        \n",
                spaces.Remove(0, 0) + "        (____)   `--'                          \n",
                },
                //Expolsion 11
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         ^-^     ..,-.      _.--\"\"\"\"o          \n",
                spaces.Remove(0, 0) + "        \\|_|    : .`-';_.-\"                    \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-=:. (.,.)                        \n",
                spaces.Remove(0, 0) + "        (____)   `:-'                          \n",
                },
                //Expolsion 12
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         ^-^     .. .       _.--\"\"\"\"--.        \n",
                spaces.Remove(0, 0) + "        \\|_|    : . : ; . \"             \"-.    \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-=:. :.,.;                    `.  \n",
                spaces.Remove(0, 0) + "        (____)   `.:'                        o \n",
                },
                //Expolsion 13
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         ^-^                                   \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 14
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         `-'                                   \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"\" -=                                 \n",
                spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 15
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         `-'                                   \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"\" =                                  \n",
                spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 16
                new string[]
                {
                spaces.Remove(0, 0) + "        _.-._                                  \n",
                spaces.Remove(0, 0) + "         `-'                                   \n",
                spaces.Remove(0, 0) + "        \\|_|                                   \n",
                spaces.Remove(0, 0) + "        |\"\"o\\                                  \n",
                spaces.Remove(0, 0) + "        (____)                                _\n",
                }
            };

            //This reverses the array since the timer counts down throught the indexes
            TankArtShooting.Reverse();
            #endregion

            #region Explosion Art
            //Create a list of strings
            List<string[]> TNTfinal = new List<string[]>() 
            { 
            //Expolsion 1
            new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "      )\n",
                spaces.Remove(0, 0) + "     (\n",
                spaces.Remove(0, 0) + "    .-`-.\n",
                spaces.Remove(0, 0) + "    :   :\n",
                spaces.Remove(0, 0) + "    :TNT:\n",
                spaces.Remove(0, 0) + "    :___:\n"
                },
                //Explosion 2
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "    \\|/\n",
                spaces.Remove(0, 0) + "   - o -\n",
                spaces.Remove(0, 0) + "    /-`-.\n",
                spaces.Remove(0, 0) + "    :   :\n",
                spaces.Remove(0, 0) + "    :TNT:\n",
                spaces.Remove(0, 0) + "    :___:\n"
                },
                //Explosion 3
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "    .---.\n",
                spaces.Remove(0, 0) + "    : | :\n",
                spaces.Remove(0, 0) + "    :-o-:\n",
                spaces.Remove(0, 0) + "    :_|_:\n"
                },
                //Explosion 4
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "    .---.\n",
                spaces.Remove(0, 0) + "    (\\|/)\n",
                spaces.Remove(0, 0) + "    --0--\n",
                spaces.Remove(0, 0) + "    (/|\\)\n"
                },
                //Explosion 5
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "   '.\\|/.'\n",
                spaces.Remove(0, 0) + "   (\\   /)\n",
                spaces.Remove(0, 0) + "   - -O- -\n",
                spaces.Remove(0, 0) + "   (/   \\)\n",
                spaces.Remove(0, 0) + "   ,'/|\'.\n"
                },
                //Explosion 6
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "'.  \\ | /  ,'\n",
                spaces.Remove(0, 0) + "  `. `.' ,'\n",
                spaces.Remove(0, 0) + " ( .`.|,' .)\n",
                spaces.Remove(0, 0) + " - ~ -0- ~ -\n",
                spaces.Remove(0, 0) + " (\n"
                },
                //Explosion 7
                new string[]
                {
                spaces.Remove(0, 0) + "         \n",
                spaces.Remove(0, 0) + "','|'.` )\n",
                spaces.Remove(0, 0) + "  .' .'. '.\n",
                spaces.Remove(0, 0) + ",'  / | \\  '.\n",
                spaces.Remove(0, 0) + "    \\ '  \"\n",
                spaces.Remove(0, 0) + " ` . `.' ,'\n",
                spaces.Remove(0, 0) + " . `` ,'. \"\n",
                spaces.Remove(0, 0) + "   ~ (   ~ -\n",
                spaces.Remove(0, 0) + "'\n"
                },
                //Explosion 8
                new string[]
                {
                spaces.Remove(0, 0) + ". ','|` ` .\n",
                spaces.Remove(0, 0) + "  .'  \"  '\n",
                spaces.Remove(0, 0) + ",   ' , '  `\n",
                spaces.Remove(0, 0) + "             \n",
                spaces.Remove(0, 0) + "   (  ) (\n",
                spaces.Remove(0, 0) + "    ) ( )\n",
                spaces.Remove(0, 0) + "    (  )\n",
                spaces.Remove(0, 0) + "     ) /\n",
                spaces.Remove(0, 0) + "    ,---.\n"
                },
                //Explosion 9
                new string[]
                {
                spaces.Remove(0, 0) + ". ','|` ` .\n",
                spaces.Remove(0, 0) + "  .'  \"  '\n",
                spaces.Remove(0, 0) + ",   ' , '  `\n",
                spaces.Remove(0, 0) + "             \n",
                spaces.Remove(0, 0) + "   (  ) (\n",
                spaces.Remove(0, 0) + "    ) ( )\n",
                spaces.Remove(0, 0) + "    (  )\n",
                spaces.Remove(0, 0) + "     ) /\n",
                spaces.Remove(0, 0) + "    ,---.\n"
                }
            };

            //This reverses the array since the timer counts down throught the indexes
            TNTfinal.Reverse();
            #endregion

            //this starts the opening screen showing a timer
            i--;
            Console.ResetColor();
            Console.Clear();

            ASCIIFlagArt();

            //This is to center in the screen
            EmptySpace();

            Console.WriteLine((spaces.Remove(0, 18) + "================================================="));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((spaces.Remove(0, 18) + "I have changed your Console width to: " + Console.WindowWidth + " pixels"));
            Console.WriteLine((spaces.Remove(0, 18) + "I have changed your Console height to: " + Console.WindowHeight + " pixels"));
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((spaces.Remove(0, 18) + "        This program will begin in:  " + i.ToString()));

            //This loops through to print the string array list - explosion 1-9
            var indexTNT = TNTfinal[i];
            foreach (var array in indexTNT)
            {
                foreach (var item in array)
                {
                    //Console.WriteLine(spaces.Remove(0, 18));
                    Console.Write(item);
                }
            }

            ////This loops through to print the string array list - explosion 1-16
            //var indexTankShooting = TankArtShooting[i];
            //foreach (var array in indexTankShooting)
            //{
            //    foreach (var item in array)
            //    {
            //        //Console.WriteLine(spaces.Remove(0, 18));
            //        Console.Write(item);
            //    }
            //}
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.WriteLine((spaces.Remove(0, 18) + "               PLEASE STAND-BY  "));
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.WriteLine((spaces.Remove(0, 18) + "         WE'RE ROLLING IN THE TANKS "));
            Console.WriteLine((spaces.Remove(0, 18) + "================================================="));

            if (i == 0)
            {
                Console.Clear();

                //This is to center in the screen
                EmptySpace();

                //Display US Flag
                ASCIIFlagArt();
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((spaces.Remove(0, 18) + "                 W E L C O M E "));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                      T O "));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                JAMES SILCOTT'S"));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                MILITARY UNITS"));
                Console.WriteLine((spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.ResetColor();
                Console.WriteLine((spaces.Remove(0, 18) + "             PRESS ENTER TO ENTER"));

                timer.Close();
                timer.Dispose();
            }
            GC.Collect();
        }
        #endregion

        //Make Fullscreen
        #region FULLSCREEN MODE
        //this is for the fullscreen mode
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        //This will set the console window to full screen
        static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
        #endregion

        //Main Program
        static void Main(string[] args)
        {
            //This will set the console window to full screen
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            //Call the widescreen method
            WideScreenMethod();

            //start the timer method and set the timer to add itself then read console 
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            Console.ReadLine();
            Console.Clear();

            //Variable names for each tank (WW1 and WW2)
            #region TANK NAMES
            //Names of World War ONE tanks
            var tank1WW1 = "Marks I-V Male (Britain)";
            var tank2WW1 = "Medium Mark A \"Whippet\" (Britain)";
            var tank3WW1 = "A7V Sturmpanzerwagen (Germany)";
            var tank4WW1 = "Schneider M.16 CA1 (France)";
            var tank5WW1 = "Light Renault FT17 (France)";

            //Names of World War TWO tanks
            var tank1WW2 = "Comet IA 34 (Britain)";
            var tank2WW2 = "Tiger I (Germany)";
            var tank3WW2 = "IS 2 Iosif Stalin Tank (Soviet Union)";
            var tank4WW2 = "M26 Pershing Tank (United States)";
            var tank5WW2 = "Jagdpanther (Germany)";
            #endregion

            //Set the loop condition
            string tryAgainResponse = "Y";
            
            //Start the loop to the condition 
            while (tryAgainResponse == "Y") 
            {
                //Call the Intro Method
                Intro();

                //Intro and menu selection method at startup
                #region INTRO METHOD
                void Intro()
                {
                    //Call the ASCII Art Method to display the big tank
                    ASCIIArt();

                    //Call the Sound Method to play Asterisk Sound
                    SoundAsterisk();

                    //Menu for WW1 or WW2 Tanks

                    Console.WriteLine((spaces.Remove(0, 18) + "WELCOME TO MILITARY UNITS - WORLD WAR TANKS"));
                    Console.WriteLine();
                    Console.WriteLine((spaces.Remove(0, 18) + "Choose a World War: [1] or [2]"));
                    Console.WriteLine((spaces.Remove(0, 18) + "1. World War I - 1914 to 1918"));
                    Console.WriteLine((spaces.Remove(0, 18) + "2. World War II - 1939 to 1945"));
                    string response = Console.ReadLine();
                    int number;

                    //convert string response to integer
                    if (int.TryParse(response, out number))
                    {
                        // string interpolation expression
                        Console.WriteLine((spaces.Remove(0, 18) + $"You selected: {number}"));
                        
                        //if number is equal to 1, show WW1 tanks
                        if (number == 1)
                        {
                            Console.Clear();

                            //This is to center in the screen
                            EmptySpace();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine((spaces.Remove(0, 18) + "Here are the Top 5 Tanks from WORLD WAR 1 ERA"));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank1WW1));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank2WW1));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank3WW1));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank4WW1));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank5WW1));
                            Console.ResetColor();
                            Console.WriteLine();

                            //Call the WW1 Tank Method
                            TankSelectionWW1();
                        }
                        //if number is equal to 2, show WW2 tanks
                        else if (number == 2)
                        {
                            Console.Clear();

                            //This is to center in the screen
                            EmptySpace();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine((spaces.Remove(0, 18) + "Here are the Top 5 Tanks from WORLD WAR 2 ERA"));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank1WW2));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank2WW2));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank3WW2));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank4WW2));
                            Console.WriteLine((spaces.Remove(0, 18) + "- " + tank5WW2));
                            Console.ResetColor();
                            Console.WriteLine();

                            //Call the WW2 Tank Method
                            TankSelectionWW2();
                        }
                        //if anything other than a 1 or 2 is entered clear the screen and returnt to intro
                        else
                        {
                            Console.Clear();
                            Intro();
                        }
                    }
                    //if the response is anything other than a number
                    else
                    {

                        //This is to center in the screen
                        EmptySpace();

                        Console.WriteLine((spaces.Remove(0, 18) + "You typed: {0}", response));
                        Console.WriteLine((spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                        Console.WriteLine((spaces.Remove(0, 18) + "Press Enter"));
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                }
                #endregion

                //Selection Menu for the Tank Categories
                #region METHOD: CATEGORY SELECTION
                void SelectionCategories()
                {

                    //This is to center in the screen
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine((spaces.Remove(0, 18) + "Choose what to Learn: [1], [2], [3], [4] or [5]"));
                    Console.WriteLine((spaces.Remove(0, 18) + "1. Firepower"));
                    Console.WriteLine((spaces.Remove(0, 18) + "2. Speed"));
                    Console.WriteLine((spaces.Remove(0, 18) + "3. Distance"));
                    Console.WriteLine((spaces.Remove(0, 18) + "4. Armour"));
                    Console.WriteLine((spaces.Remove(0, 18) + "5. Crew Size"));
                }
                #endregion

                //WW1 TANK METHOD
                #region METHOD: WW1 TANK MENU (Firepower, Speed, Distance, Armour, Crew Size) 
                void TankSelectionWW1()
                {
                    int number;
                    SelectionCategories();
                    string response = Console.ReadLine();
                    Console.Clear();

                    //This is to center in the screen
                    EmptySpace();

                    //convert string response to integer
                    if (Int32.TryParse(response, out number))
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Firepower\n"));
                                TankFirepowerWW1();
                                break;
                            case 2:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Speed\n"));
                                TankSpeedWW1();
                                break;
                            case 3:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Distance\n"));
                                TankDistanceWW1();
                                break;
                            case 4:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Armour\n"));
                                TankArmourWW1();
                                break;
                            case 5:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Crew Size\n"));
                                TankCrewSizeWW1();
                                break;
                        }
                        //if number is greater than 5, clear and replay intro
                        if (number > 5)
                        {
                            Console.Clear();
                            Intro();
                        }
                        Console.WriteLine();
                    }
                    //if the response is anything other than a number
                    else
                    {

                        //This is to center in the screen
                        EmptySpace();

                        Console.WriteLine((spaces.Remove(0, 18) + "You typed: {0}", response));
                        Console.WriteLine((spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                        Console.WriteLine((spaces.Remove(0, 18) + "Press Enter"));
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                    TryAgain();
                }
                #endregion

                //WW2 TANK METHOD
                #region METHOD: WW2 TANK MENU (Firepower, Speed, Distance, Armour, Crew Size) 
                void TankSelectionWW2()
                {
                    int number;
                    SelectionCategories();
                    string response = Console.ReadLine();
                    Console.Clear();

                    //This is to center in the screen
                    EmptySpace();

                    //convert string response to integer
                    if (Int32.TryParse(response, out number))
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Firepower\n"));
                                TankFirepowerWW2();
                                break;
                            case 2:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Speed\n"));
                                TankSpeedWW2();
                                break;
                            case 3:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Distance\n"));
                                TankDistanceWW2();
                                break;
                            case 4:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Armour\n"));
                                TankArmourWW2();
                                break;
                            case 5:
                                Console.WriteLine((spaces.Remove(0, 18) + $"You selected {number}: " + "Crew Size\n"));
                                TankCrewSizeWW2();
                                break;
                        }
                        //if number is greater than 5, clear and replay intro
                        if (number > 5)
                        {
                            Console.Clear();
                            Intro();
                        }
                        Console.WriteLine();
                    }
                    //if the response is anything other than a number
                    else
                    {
                        //This is to center in the screen
                        EmptySpace();

                        Console.WriteLine((spaces.Remove(0, 18) + "You typed: {0}", response));
                        Console.WriteLine((spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                        Console.WriteLine((spaces.Remove(0, 18) + "Press Enter"));
                        Console.ReadLine();
                        Console.Clear();
                        Intro();
                    }
                    TryAgain();
                }
                #endregion

                //Try Again Method - Option to play the application again
                #region METHOD: TRY AGAIN 
                void TryAgain()
                {
                    //This is to find the pixels in the screen divid by two and center the text using spaces
                    var consoleWidth = Console.WindowWidth;
                    var dividedWidth = consoleWidth / 2;
                    string spaces = ' '.Repeat(dividedWidth);

                    //This is to center in the screen
                    EmptySpace();

                    Console.WriteLine((spaces.Remove(0, 18) + "Want to play again? [Y] or [N]"));
                    Console.WriteLine();
                    Console.WriteLine((spaces.Remove(0, 18) + "[B]attle"));
                    var response = Console.ReadLine();
                    var responseUpper = response.ToUpper();
                    //If Yes
                    if (responseUpper == "Y")
                    {
                        Console.Clear();
                        Intro();
                    }
                    //If No
                    else if (responseUpper == "N")
                    {
                        Console.Clear();
                        tryAgainResponse = "N";
                        
                        //Display US Flag Art
                        ASCIIFlagArt();

                        //Display Thank You Art
                        ThankYouEnding();
                        SoundSysHand();
                    }
                    #region EGG
                    //EASTER EGG - Mini Tank Battle Game 
                    else if (responseUpper == "B")
                    {
                        //Message
                        Console.Clear();

                        //This is to center in the screen
                        EmptySpace();

                        Console.WriteLine((spaces.Remove(0, 18) + "YOU'VE FOUND AN EASTER EGG!"));
                        Console.WriteLine((spaces.Remove(0, 18) + "By James Silcott"));
                        Console.WriteLine();
                        Console.WriteLine((spaces.Remove(0, 18) + "This is a mini game that simulates a battle with WW1 and WW2 tanks"));

                        //Change Color
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        //Add Art
                        Console.WriteLine((spaces.Remove(0, 18) + "    .--._____,           ,_____.--."));
                        Console.WriteLine((spaces.Remove(0, 18) + " .-='=='==-, \"    vs     \"  .-='=='==-, "));
                        Console.WriteLine((spaces.Remove(0, 18) + "(O_o_o_o_o_O)              (O_o_o_o_o_O) "));

                        //Rest Color
                        Console.ResetColor();

                        //Continue Message
                        Console.WriteLine();
                        Console.WriteLine((spaces.Remove(0, 18) + "First a tank from WW1 ERA and a tank from the WW2 ERA is choosen to fight!"));
                        Console.WriteLine((spaces.Remove(0, 18) + "Then those two tanks battle -- See if you can guess the winner"));
                        Console.WriteLine();
                        Console.WriteLine((spaces.Remove(0, 18) + "--Press Enter--"));
                        Console.WriteLine();
                        Console.WriteLine((spaces.Remove(0, 18) + "And Good Luck!"));
                        Console.ReadLine();
                        
                        //This sets the max number to randomly pick from
                        const int maxTanksWW1 = 5;
                        const int maxTanksWW2 = 5;

                        //This creates a dictionary of the tanks
                        var tankNamesWW1 = new Dictionary<int, string>
                        {
                            {0, tank1WW1},
                            {1, tank2WW1},
                            {2, tank3WW1},
                            {3, tank4WW1},
                            {4, tank5WW1},
                        };
                        var tankNamesWW2 = new Dictionary<int, string>
                        {
                            {0, tank1WW2},
                            {1, tank2WW2},
                            {2, tank3WW2},
                            {3, tank4WW2},
                            {4, tank5WW2}
                        };
                        //Random funtcion assigned
                        var random = new Random();
                        //Set a condiontal statement
                        bool conditionModifer = true;
                        //Create a loop
                        while (conditionModifer == true)
                        {
                            Console.Clear();
                            //Use the random function and next object to generate random tank
                            var tankSelectedWW1 = random.Next(maxTanksWW1);
                            var tankSelectedWW2 = random.Next(maxTanksWW2);

                            var tankSelectedFinalWW1 = tankNamesWW1[tankSelectedWW1];
                            var tankSelectedFinalWW2 = tankNamesWW2[tankSelectedWW2];
                            //Change Color
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            //This is to center in the screen
                            EmptySpace();

                            //Add Art
                            Console.WriteLine((spaces.Remove(0, 18) + "    .--._____,           ,_____.--."));
                            Console.WriteLine((spaces.Remove(0, 18) + " .-='=='==-, \"    vs     \"  .-='=='==-, "));
                            Console.WriteLine((spaces.Remove(0, 18) + "(O_o_o_o_o_O)              (O_o_o_o_o_O) "));

                            //Rest Color
                            Console.ResetColor();

                            Console.WriteLine((spaces.Remove(0, 18) + $"World War 1 Tank: {tankSelectedFinalWW1}"));
                            Console.WriteLine();
                            Console.WriteLine((spaces.Remove(0, 18) + "             VERSUS "));
                            Console.WriteLine();
                            Console.WriteLine((spaces.Remove(0, 18) + $"World War 2 Tank: {tankSelectedFinalWW2}"));
                            Console.WriteLine();
                            Console.WriteLine((spaces.Remove(0, 18) + "Who Will Conquer?"));
                            Console.WriteLine();
                            Console.WriteLine((spaces.Remove(0, 18) + "Press Enter to Battle"));
                            Console.ReadLine();
                            
                            //Variable to indicate which decision wins
                            int decision;
                            
                            //Create a Random Object
                            Random randFinal = new Random();
                            
                            //Get a Random integer in range of 0 through 1
                            //0 means WW1 tank, 1 means WW2 tank
                            decision = randFinal.Next(2);
                            
                            //Display on console the winner
                            if (decision == 0)
                            {
                                Console.Clear();

                                //This is to center in the screen
                                EmptySpace();

                                //Change Color
                                Console.ForegroundColor = ConsoleColor.DarkRed;

                                Console.WriteLine((spaces.Remove(0, 18) + "   [ O ]     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "     \\ \\      p     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "      \\ \\  \\o/     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "       \\ \\--'---_     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "       /\\ \\   / ~~\\_     "));
                                Console.WriteLine((spaces.Remove(0, 18) + " ./---/__|=/_/------//~~~\\     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "/___________________/O   O \\     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "(===(\\_________(===(Oo o o O)       "));
                                Console.WriteLine((spaces.Remove(0, 18) + " \\~~~\\____/     \\---\\Oo__o--     "));
                                Console.WriteLine((spaces.Remove(0, 18) + "   ~~~~~~~       ~~~~~~~~~~     "));

                                //Reset Color
                                Console.ResetColor();

                                Console.WriteLine();
                                Console.WriteLine((spaces.Remove(0, 18) + $"The Winner is World War-1: {tankSelectedFinalWW1}"));
                                Console.WriteLine();
                                SoundAsterisk();
                                Console.WriteLine((spaces.Remove(0, 18) + "Press 'Enter' for a different battle"));
                                Console.WriteLine((spaces.Remove(0, 18) + "                 OR"));
                                Console.WriteLine((spaces.Remove(0, 18) + "Press a different key to exit out"));
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Clear();

                                //This is to center in the screen
                                EmptySpace();

                                //Change Color
                                Console.ForegroundColor = ConsoleColor.DarkCyan;

                                Console.WriteLine((spaces.Remove(0, 18) + "            __.---.___         "));
                                Console.WriteLine((spaces.Remove(0, 18) + "        ___/__\\_O_/___\\___         "));
                                Console.WriteLine((spaces.Remove(0, 18) + "       /___ __________ ___\\         "));
                                Console.WriteLine((spaces.Remove(0, 18) + "       |===|\\________/|===|         "));
                                Console.WriteLine((spaces.Remove(0, 18) + "_______|===|__________|===|______         "));
                                
                                //Reset Color
                                Console.ResetColor();

                                Console.WriteLine();
                                Console.WriteLine((spaces.Remove(0, 18) + $"The Winner is World War-2: {tankSelectedFinalWW2}"));
                                Console.WriteLine();
                                SoundSysHand();
                                Console.WriteLine((spaces.Remove(0, 18) + "Press 'Enter' for a different battle"));
                                Console.WriteLine((spaces.Remove(0, 18) + "                 OR"));
                                Console.WriteLine((spaces.Remove(0, 18) + "Press a different key to exit out"));
                                Console.WriteLine();
                            }
                            //set the condional to not run forever
                            //conditionModifer = false;
                            while (Console.ReadKey().Key != ConsoleKey.Enter)
                            {
                                conditionModifer = false;
                            }
                            Console.Clear();
                            ASCIIArt();
                        }
                        //Rerun the method
                        TryAgain();
                    }
                    #endregion
                    //Catch all other keys
                    else
                    {
                        //This is to center in the screen
                        EmptySpace();

                        Console.WriteLine((spaces.Remove(0, 18) + "Wrong input, Try Again"));
                        Console.Clear();
                        TryAgain();
                    }
                }
                #endregion
            }

            //WW1 Tank Methods
            #region METHOD: WORLD WAR 1 TANKS CLASS CALLS
            void TankFirepowerWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.firepower("a mounted large-calibre cannon called tank gun in a rotating gun turret ");
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
                mySturmpanzerwagen.firepower("six 7.92 mm MG08 machine guns and a 5.7 cm Maxim-Nordenfelt cannon");
                Console.WriteLine();

                Schneider mySchneider = new Schneider();
                mySchneider.typeoftank();
                mySchneider.firepower("a short 75 mm cannon, in a sponson on the right side");
                Console.WriteLine();

                Renault myRenault = new Renault();
                myRenault.typeoftank();
                myRenault.firepower("a fully rotating turret, a Hotchkiss 8mm machine gun and 37mm Puteaux gun.");
            }
            void TankSpeedWW1()
            {
                TankWW1 myTankWW1 = new TankWW1();
                myTankWW1.typeoftank();
                myTankWW1.speed("30 mph");
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
                myTankWW1.armour("30 mm");
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
                myTankWW1.crewSize("(commander/brakesman, driver, two gearsmen and four gunners)");
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

            //WW2 Tank Methods
            #region METHOD: WORLD WAR 2 TANKS CLASS CALLS
            void TankFirepowerWW2()
            {
                TankWW2 myTankWW2 = new TankWW2();
                myTankWW2.typeoftank();
                myTankWW2.firepower("88-mm guns");
                Console.WriteLine();

                Comet myComet = new Comet();
                myComet.typeoftank();
                myComet.firepower("mounted the new 17 pdr High Velocity (HV) (3 inch; 76.2 mm) gun, ");
                Console.WriteLine();

                Tiger myTiger = new Tiger();
                myTiger.typeoftank();
                myTiger.firepower("mounted the 8.8 cm KwK 36 gun (derived from the 8.8 cm Flak 36)");
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
                myTankWW2.distance("150 miles");
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
                myTankWW2.armour("120 mm");
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
        //Empty Space to Center Screen
        #region METHOD: Empty Space
        //This is to center in the screen
        static void EmptySpace()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
        #endregion

        //ASCII TEXT Art of Thank You
        #region METHOD: THANK YOU ENDING - ASCII Test Art
        //Thank You in ASCII Text, make sure to use teh CHAREXT Class for teh Repeat Object
        static void ThankYouEnding()
        {
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "                Have a nice day!                   "));

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine((spaces.Remove(0, 18) + " _   _                 _                           "));
            Console.WriteLine((spaces.Remove(0, 18) + "| | | |               | |                          "));
            Console.WriteLine((spaces.Remove(0, 18) + "| |_| |__   __ _ _ __ | | ___   _  ___  _   _      "));
            Console.WriteLine((spaces.Remove(0, 18) + "| __| '_ \\ / _` | '_ \\| |/ / | | |/ _ \\| | | |  "));
            Console.WriteLine((spaces.Remove(0, 18) + "| |_| | | | (_| | | | |   <| |_| | (_) | |_| |     "));
            Console.WriteLine((spaces.Remove(0, 18) + "\\___|_| |_|\\__,_|_| |_|_|\\_\\__, |\\___/ \\__,__|"));
            Console.WriteLine((spaces.Remove(0, 18) + "                            __/  |                 "));
            Console.WriteLine((spaces.Remove(0, 18) + "                           |____/                  "));
        }
        #endregion

        //This plays a default windows sound
        #region METHOD: PLAY SOUNDS (SoundAsterisk, SoundSysHand)
        static void SoundAsterisk()
        {
            //Plays Asterik Beep
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));
        }
        static void SoundSysHand()
        {
            //Plays Hand Beep
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));
        }
        #endregion
    }
    //Class for Win32 Sounds
    #region CLASS: Win32 - PlaySound Function
    //Class created to playt he defualt sounds in WIN32 folder
    internal static class Win32
    {
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern bool PlaySound(string pszSound, UIntPtr hmod, uint fdwSound);

        [Flags]
        public enum SoundFlags
        {
            /// <summary>play synchronously (default)</summary>
            SND_SYNC = 0x0000,
            /// <summary>play asynchronously</summary>
            SND_ASYNC = 0x0001,
            /// <summary>silence (!default) if sound not found</summary>
            SND_NODEFAULT = 0x0002,
            /// <summary>pszSound points to a memory file</summary>
            SND_MEMORY = 0x0004,
            /// <summary>loop the sound until next sndPlaySound</summary>
            SND_LOOP = 0x0008,
            /// <summary>don't stop any currently playing sound</summary>
            SND_NOSTOP = 0x0010,
            /// <summary>Stop Playing Wave</summary>
            SND_PURGE = 0x40,
            /// <summary>The pszSound parameter is an application-specific alias in the registry. You can combine this flag with the SND_ALIAS or SND_ALIAS_ID flag to specify an application-defined sound alias.</summary>
            SND_APPLICATION = 0x80,
            /// <summary>don't wait if the driver is busy</summary>
            SND_NOWAIT = 0x00002000,
            /// <summary>name is a registry alias</summary>
            SND_ALIAS = 0x00010000,
            /// <summary>alias is a predefined id</summary>
            SND_ALIAS_ID = 0x00110000,
            /// <summary>name is file name</summary>
            SND_FILENAME = 0x00020000,
            /// <summary>name is resource name or atom</summary>
            SND_RESOURCE = 0x00040004
        }
    }
    #endregion

    //Class for Repeat Function - used for the text spaces and dividing the screen
    #region CLASS: CharExtensions - Repeat Function
    //Class was created to use the Repeat with spaces to center the text
    public static class CharExtensions
    {
        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }
    }
    #endregion

    //Class for WW1 Tanks
    #region CLASS: WW1 - (TankWW1, MarksIVMale, Whippet, Sturmpanzerwagen, Schneider, Renault) 
    class TankWW1
    {
        public virtual void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + $"I am a World War 1 Tank"));
        }
        public void firepower(string action)
        {
            Console.Write($" and armed with: {action}\n");
        }
        public void speed(string speed)
        {
            Console.Write($" and has a max speed of: {speed}\n");
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
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a British Marks I-V Male"));
        }
    }
    class Whippet : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a British Medium Mark A “Whippet"));
        }
    }
    class Sturmpanzerwagen : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a German A7V Sturmpanzerwagen"));
        }
    }
    class Schneider : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a French Schneider M.16 CA1"));
        }
    }
    class Renault : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a French Light Renault FT17"));
        }
    }
    #endregion

    //Class for WW2 Tanks
    #region CLASS: WW2 - (TankWW2, Comet, Tiger, Stalin, Pershing, Jagdpanther)
    class TankWW2
    {
        public virtual void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + $"I am a World War 2 Tank"));
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
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Comet IA 34 (Britain)"));
        }
    }
    class Tiger : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Tiger I (Germany)"));
        }
    }
    class Stalin : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a IS 2 Iosif Stalin Tank (Soviet Union)"));
        }
    }
    class Pershing : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a M26 Pershing Tank (United States)"));
        }
    }
    class Jagdpanther : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Jagdpanther (Germany)"));
        }
    }
    #endregion
}

//Notes and project info
#region NOTES
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