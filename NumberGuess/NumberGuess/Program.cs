using System;

namespace NumberGuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is too high!");
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine(guess + "is too low!");
                    }
                    guesses++;

                }
                Console.WriteLine("");
                Console.WriteLine("Number:\n" + number);
                Console.WriteLine("");
                Console.WriteLine("YOU WIN!\n");
                Console.WriteLine("");
                Console.WriteLine("Guesses:\n" + guesses);

                Console.WriteLine("");

                Console.WriteLine("Would you like to play again (Y/N):\n");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();

        }
    }
}
