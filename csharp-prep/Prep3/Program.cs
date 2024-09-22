using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random random = new Random();
        bool playAgain;

        do
        {

            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int numberOfGuesses = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");


            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;


                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You took {numberOfGuesses} guesses to find the magic number.");


            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";

        } while (playAgain);

        Console.WriteLine("Thanks for playing!");
    }
}