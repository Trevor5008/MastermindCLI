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
            int tryCount = 0;

            while (true)
            {

                string userInput = "";

                for (int i = 0; i < 4; i++)
                {

                    // Prompts the user to enter their number choice
                    Console.Write("Please enter a number between 1 and 7 (inclusive): ");
                    userInput += Console.ReadLine();

                    while (true)
                    {
                        if (invalidInt < 1 || invalidInt > 7)
                        {
                            userInput.Remove(i);
                            Console.Write("Please enter a value within range...");
                            Console.WriteLine();
                            continue;
                        }

                        break;
                    }


                    if (userInput.Substring(i, 1) == masterCombo.Substring(i, 1))
                    {
                        Console.Write("+");
                        Console.WriteLine("");
                    }
                    else if (masterCombo.Contains(userInput.Substring(i, 1)))
                    {
                        Console.Write("-");
                        Console.WriteLine("");
                    }
                    //else if (userInput==null)
                    //{

                    //}
                    else { Console.WriteLine(); }

                }
                tryCount++;
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

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}

