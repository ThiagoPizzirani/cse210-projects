using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);

        int guess = -1; 
        int guessNumber = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher");
                guessNumber++;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                guessNumber++;
            }
            else
            {
                Console.WriteLine("You guessed it");
            }

        }

        Console.WriteLine($"It took you {guessNumber} guesses ");

 }
}