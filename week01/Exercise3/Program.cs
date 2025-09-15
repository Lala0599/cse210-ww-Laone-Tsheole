using System;

class Program
{
    static void Main(string[] args)
    {
        //generate random number instead of user out put
        Random randomGenerator = new Random();

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0; //track number of guesses 

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            //loop until correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; //increment guess counter

                //check if higher, lower, or correct
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
                    //display guess count
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }
            //assk if the user wants to play again
            Console.Write("Would you like to play again? (yes/no)");
            playAgain = Console.ReadLine();
            Console.WriteLine(); // blank line for readability
        }

        Console.WriteLine("Thanks for playing!");
    }
}