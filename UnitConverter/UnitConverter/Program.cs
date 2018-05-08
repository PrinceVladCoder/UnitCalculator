using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*                             *");
            Console.WriteLine("*     Welcome to Unit         *");
            Console.WriteLine("*         Converter           *");
            Console.WriteLine("*                             *");
            Console.WriteLine("*******************************");
            Console.WriteLine("                               ");
            Console.WriteLine("What would you like to convert?");
            Console.WriteLine("                               ");
            Console.WriteLine("Please make you selections from the option below: ");
            Console.WriteLine("                               ");
            Console.WriteLine(" 1. Length");
            Console.WriteLine(" 2. Volume");
            Console.WriteLine(" 3. Weight");
            Console.WriteLine(" 4. Area");
            Console.WriteLine(" 5. Temperature");
            Console.WriteLine(" 6. Fuel Economy");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if(userChoice == 1)
            {
                ConvertLength();
                ConvertVolume();
            }
                    
        }

        static void ConvertLength()
        {
            Console.Clear();
            Console.WriteLine("Please enter the number you want to convert: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What do you want to convert? ");
            Console.WriteLine("1. From Meter to Yard?");
            Console.WriteLine("2. From Meter to Feet?");
            Console.WriteLine("3. From Meter to Inches?");
            Console.WriteLine("4. From Centimetre to Inches?");
            Console.WriteLine("5. From Inches to Centimetre?");
            Console.WriteLine("6. From Inches to Meter?");
            Console.WriteLine("7. From Feet to Meter?");
            Console.WriteLine("8. From Yard to Meter");
            Console.WriteLine("Please make your selection");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            if(userChoice == 1)
            {
                Console.WriteLine(userNumber + " meters " + " is equal to " + (userNumber * 1.09361) + " yards. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if(userChoice == 2)
            {
                Console.WriteLine(userNumber + " meters " + " is equal to " + (userNumber * 3.28084) + " feet. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if(userChoice == 3)
            {
                Console.WriteLine(userNumber + " meters " + " is equal to " + (userNumber * 39.3701) + " inches. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if (userChoice == 4)
            {
                Console.WriteLine(userNumber + " centimeters " + " is equal to " + (userNumber * 0.393701) + " inches. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if(userChoice == 5)
            {
                Console.WriteLine(userNumber + " inches " + " is equal to " + (userNumber * 2.54) + " centimetres. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if(userChoice == 6)
            {
                Console.WriteLine(userNumber + " inches " + " is equal to " + (userNumber * 0.0254) + " metres. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if(userChoice == 7)
            {
                Console.WriteLine(userNumber + " feet " + " is equal to " + (userNumber * 0.3048) + " metres. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if (userChoice == 8)
            {
                Console.WriteLine(userNumber + " yard " + " is equal to " + (userNumber * 0.9144) + " metres. ");
                Console.WriteLine("Do you want to make another calculation: y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("You have not made a valid selection, please enter t to try again.");
                string tryAgain = Console.ReadLine();
                if(tryAgain == "t")
                {
                    Console.Clear();
                    ConvertLength();
                }
            }

        }

        static void ConvertVolume()
        {

        }
    }
}
