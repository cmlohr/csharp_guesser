using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                //create random int with random object
                Random random = new Random();
                int randomNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 & 10");

                while (guess != randomNumber)
                {
                    string inputNumber = Console.ReadLine();

                    // check input is an int
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        ColorMessage(ConsoleColor.Yellow, "Sorry, that wasn't a number.");

                        continue;
                    }
                    guess = Int32.Parse(inputNumber);

                    if (guess != randomNumber)
                    {
                        ColorMessage(ConsoleColor.Red, "Wrong Number, try again?");
                    }
                }

                // success
                ColorMessage(ConsoleColor.Green, "Correct!!");

                // play again
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {                 
                    return;
                }
                {         
                    return;
                }
            }
        }

        static void GreetUser()
        {
            // get user name
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a game!", inputName);
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Colleen Lohr";

            // set text color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }
    }
}