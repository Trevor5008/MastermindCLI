using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Mastermind challenge...\n(press any key to continue)\n");
            Console.ReadKey();
            Console.Clear();

            string masterCombo = "";
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                int num = 0;
                num = rnd.Next(1, 7);
                masterCombo += num;
            }

            //Console.WriteLine(masterCombo);

            while (true)
            {
                int tryCount = 0;

                string userInput = "";

                for (int x = 0; x < 4; x++)
                {

                    // Prompts the user to enter their number choice
                    Console.Write("Please enter a number between 1 and 7 (inclusive): ");
                    userInput += Console.ReadLine();

                    if (userInput.Substring(x, 1) == masterCombo.Substring(x, 1))
                    {
                        Console.Write("+");
                        Console.WriteLine("");
                    }
                    else if (masterCombo.Contains(userInput.Substring(x, 1)))
                    {
                        Console.Write("-");
                        Console.WriteLine("");
                    }
                    else { Console.WriteLine(); }

                }
                tryCount++;
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
                
                if (tryCount == 10)
                {
                    Console.WriteLine("You're all out of guesses...");

                    string userChoice = "";
                    Console.Write("Would you like to see the correct combination? (Y/N): ");
                    userChoice = Console.ReadLine();

                    if (userChoice.ToLower() == "y")
                    {
                        Console.Write(masterCombo);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Thanks for playing...");
                        Console.WriteLine();
                        break;
                    }
                    break;

                }
                else if (userInput == masterCombo)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You're a Mastermind...");
                    Console.WriteLine();
                    break;
                }

            }
        }
    }
}

