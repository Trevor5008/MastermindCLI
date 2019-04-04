using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            Random rnd = new Random();
            int num = 0;
            string masterCombo = "";

            Console.Write("Please enter a number between 1 and 7 (inclusive): ");
            userInput = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter another number (same range): ");
                userInput += Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
                num = rnd.Next(1, 7);

                masterCombo += num;

                // This compares the index position value in the user's input to the same index position
                // in the randomly generated "mastermind" combo
                if (userInput.Substring(i, 1) == masterCombo.Substring(i, 1))
                {
                    Console.WriteLine("+");
                }
                // If the above condition is not met, the program will then check to see if the index position value
                // is located anywhere in the master combination
                else if (masterCombo.Contains(userInput.Substring(i,1)))
                {
                    Console.WriteLine("-");
                }
                // If neither the above conditions are met, the console will display nothing for that index position value
                Console.WriteLine("");
            }

            string userChoice = "";
            Console.Write("Would you like to see the correct combination? (Y/N): ");
            userChoice = Console.ReadLine();

            if(userChoice.ToLower()=="y")
            {
                Console.Write(masterCombo);
                Console.WriteLine();
            }
            else {
                Console.Clear();
                Console.Write("Thanks for playing, ");
                Console.WriteLine();
            }
        }
    }
}
