using System;
using static System.Console;

namespace AdventurerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string adventurerName = "";
            int numberOfDungeons = 0;
            bool flashlight = false;
            float speed = 0f;
            decimal money = 0m;

            WriteLine("Welcome to the Adventurer Recruitment Centre!");
            WriteLine("If you wish to join our ranks, you will need to sign up with us.\n");

            // Gathers data and overwrites blank data members with pass by reference
            GetData(ref adventurerName, ref numberOfDungeons,
                    ref flashlight, ref speed, ref money);

            Adventurer applicant = new Adventurer(adventurerName, numberOfDungeons,
                                                  flashlight, speed, money);

            WriteLine("\nThank you for your application. Here is what you wrote:\n");
            WriteLine(applicant);
            
        }

        // Prompts the user for information about adventurer
        static void GetData(ref string adventurerName, ref int numberOfDungeons,
                            ref bool flashlight, ref float speed, ref decimal money)
        {
            Write("What is your name? ");
            adventurerName = ReadLine();
            Write("How many dungeons did you already explore? ");
            numberOfDungeons = int.Parse(ReadLine());
            Write("Is it true that you have a flashlight? ");
            flashlight = bool.Parse(ReadLine());
            Write("How fast can you run? ");
            speed = float.Parse(ReadLine());
            Write("How much money do you have on hand? ");
            money = decimal.Parse(ReadLine());
        }
    }
}
