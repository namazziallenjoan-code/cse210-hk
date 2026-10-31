using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your username: ");
        string userName = Console.ReadLine();

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1,101);

           int guess;

           Console.WriteLine($"Welcome {userName}! Let's play!");

           do
           {
              Console.Write("What is your guess? ");
              guess = int.Parse(Console.ReadLine());

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
                Console.WriteLine($"Congratulations {userName}! You guessed it!");
              }
            }while (guess != magicNumber);
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine($"Thank you for playing {userName}.");
    }
}