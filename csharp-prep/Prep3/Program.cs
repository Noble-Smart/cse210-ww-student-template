using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
Random random = new Random();

while (playAgain)
{
    int magicNumber = 18; // Replace with random.Next(1, 101) for random number
    int guesses = 0;
    int maxGuesses = 5;

    Console.WriteLine("Welcome to Guess My Number!");

    while (guesses < maxGuesses)
    {
        Console.Write($"Guess ({guesses + 1}/{maxGuesses}): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int guess))
        {
            guesses++;

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
                Console.WriteLine($"It took you {guesses} guesses.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    if (guesses == maxGuesses)
    {
        Console.WriteLine("You've completed your guesses and failed. Try again later!");
        Console.WriteLine($"The magic number was {magicNumber}.");
    }

    Console.Write("Would you like to play again? (yes/no): ");
    string response = Console.ReadLine().ToLower();

    playAgain = response == "yes";
}
    }
}